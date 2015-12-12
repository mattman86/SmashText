using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SmashText
{
    public static class CsvParser
    {
        private static LinkedList<LinkedList<string>> _rows;

        public static DataTable ParseCSVFile(string path, bool firstRowIsHeader = false)
        {
            DataTable dt;
            if (File.Exists(path))
            {
                new DataTable();
                var sr = new StreamReader(path);
                dt = ParseCSVText(sr.ReadToEnd(), firstRowIsHeader);
                sr.Close();
            }
            else
                dt = null;

            return dt;
        }

        public static DataTable ParseCSVText(string text, bool firstRowIsHeader = false)
        {
            var dt = new DataTable();
            bool tableIsPrepared = false;
            if (text.Length > 0)
            {
                ParseCSV(text);
                foreach (var row in _rows)
                {
                    string[] vals = row.ToArray();
                    if (!tableIsPrepared)
                    {
                        PrepareTable(dt, vals.Length);
                        tableIsPrepared = true;
                    }
                    bool addedRow = false;
                    while (!addedRow)
                    {
                        try
                        {
                            dt.Rows.Add(vals);
                            addedRow = true;
                        }
                        catch (Exception)
                        {
                            var col = new DataColumn("Column " + dt.Columns.Count) { DefaultValue = "", AllowDBNull = false };
                            dt.Columns.Add(col);
                        }
                    }
                }
            }

            if (firstRowIsHeader)
                SetFirstRowAsHeaders(dt);

            return dt;
        }

        private static void ParseCSV(string inputString)
        {
            _rows = new LinkedList<LinkedList<string>>();
            var rowValues = new LinkedList<string>();
            CSVState state = CSVState.BeginString;
            CSVState prevState = state;
            string currentToken = "";
            int i = 0;
            while (i < inputString.Length)
            {
                char curChar = inputString[i];
                switch (state)
                {
                    case CSVState.BeginString:
                        if (curChar == '\'')
                        {
                            state = CSVState.InQuoteString;
                            i++;
                        }
                        else if (curChar == '\"')
                        {
                            state = CSVState.InDoubleQuoteString;
                            i++;
                        }
                        else
                        {
                            state = CSVState.InString;
                        }
                        break;

                    case CSVState.InQuoteString:
                        if (curChar == '\\')
                        {
                            i++;
                            prevState = state;
                            state = CSVState.Escape;
                        }
                        else if (curChar == '\'')
                        {
                            i++;
                            state = CSVState.OutOfString;
                            rowValues.AddLast(currentToken);
                            currentToken = "";
                        }
                        else
                        {
                            i++;
                            currentToken += curChar;
                        }
                        break;

                    case CSVState.InDoubleQuoteString:
                        if (curChar == '\\')
                        {
                            i++;
                            prevState = state;
                            state = CSVState.Escape;
                        }
                        else if (curChar == '\"')
                        {
                            i++;
                            state = CSVState.OutOfString;
                            rowValues.AddLast(currentToken);
                            currentToken = "";
                        }
                        else
                        {
                            i++;
                            currentToken += curChar;
                        }
                        break;

                    case CSVState.InString:
                        if (curChar == '\\')
                        {
                            i++;
                            prevState = state;
                            state = CSVState.Escape;
                        }
                        else if (curChar == '\r' || curChar == '\n')
                        {
                            i++;
                            state = CSVState.EndOfRow;
                        }
                        else if (curChar == ',')
                        {
                            state = CSVState.OutOfString;
                            rowValues.AddLast(currentToken);
                            currentToken = "";
                        }
                        else
                        {
                            i++;
                            currentToken += curChar;
                        }
                        break;

                    case CSVState.OutOfString:
                        if (curChar == '\r' || curChar == '\n')
                        {
                            i++;
                            state = CSVState.EndOfRow;
                        }
                        else
                        {
                            i++;
                            state = CSVState.BeginString;
                        }
                        break;

                    case CSVState.Escape:
                        currentToken += curChar;
                        i++;
                        state = prevState;
                        break;

                    case CSVState.EndOfRow:
                        if (currentToken != "")
                        {
                            rowValues.AddLast(currentToken);
                            currentToken = "";
                        }
                        if (rowValues.Count > 0)
                        {
                            _rows.AddLast(rowValues);
                            rowValues = new LinkedList<string>();
                        }
                        state = CSVState.BeginString;
                        break;
                }
            }
            if (state != CSVState.OutOfString)
            {
                if (rowValues.Count == 0 && currentToken == "")
                {
                }
                else
                {
                    rowValues.AddLast(currentToken);
                    _rows.AddLast(rowValues);
                }
            }
        }

        private static void PrepareTable(DataTable table, int columns)
        {
            for (int i = 0; i < columns; i++)
                table.Columns.Add("Column " + i);
        }

        private static void SetFirstRowAsHeaders(DataTable dt)
        {
            DataRow row = dt.Rows[0];
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string newTitle = row["Column " + i].ToString();
                if (newTitle != "")
                {
                    int columnsWithSameName = 0;
                    var titles = new HashSet<string>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        titles.Add(col.ColumnName);
                    }

                    string tempTitle = newTitle;
                    while (titles.Contains(tempTitle))
                    {
                        columnsWithSameName++;
                        tempTitle = newTitle + " (" + columnsWithSameName + ")";
                    }

                    newTitle = tempTitle;

                    dt.Columns[i].ColumnName = newTitle;
                }
            }
            dt.Rows.Remove(row);
        }

        #region Nested type: CSVState

        private enum CSVState
        {
            BeginString,
            InString,
            InQuoteString,
            InDoubleQuoteString,
            OutOfString,
            Escape,
            EndOfRow
        }

        #endregion Nested type: CSVState
    }
}