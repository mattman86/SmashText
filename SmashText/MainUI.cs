using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace SmashText
{
    public partial class MainUI : Form
    {
        public static string UserName;
        public Login prompt = new Login();
        private readonly CookieContainer cookieJar;
        private readonly bool formLoaded;
        private string categories;
        private Dictionary<string, List<Contact>> contactGroups;
        private string csvPath;
        private string email;
        private string fName;
        private string lName;
        private string phone;
        private string rnrKey;

        public MainUI()
        {
            InitializeComponent();
            formLoaded = false;
            cookieJar = new CookieContainer();
            SetEnabled(false);
            formLoaded = true;
            loginWindowTimer.Start();
            PopulateListbox();
        }

        private void AboutMenuItem(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void backgroundSendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundSendingToolStripMenuItem.Checked)
            {
                backgroundSendingToolStripMenuItem.Checked = false;
            }
            if (!backgroundSendingToolStripMenuItem.Checked)
            {
                backgroundSendingToolStripMenuItem.Checked = true;
            }
        }

        private void BuildContactList(DataTable data)
        {
            contactGroups = new Dictionary<string, List<Contact>>();
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow row = data.Rows[i];
                    if (row[fName].ToString() == "") continue;
                    var person = new Contact
                    {
                        Email = row[email].ToString(),
                        MobilePhone = row[phone].ToString(),
                        Name = row[fName] + " " + row[lName],
                        FirstName = row[fName].ToString(),
                        LastName = row[lName].ToString()
                    };

                    string[] groups = row[categories].ToString().Split(';');
                    foreach (string group in groups)
                    {
                        if (!contactGroups.ContainsKey(group))
                            contactGroups[group] = new List<Contact>();
                        contactGroups[group].Add(person);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "There seems to be a problem with your CSV file." + Environment.NewLine + Environment.NewLine + ex.Message, "Error: Invalid CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSavedMessage()
        {
            var fi = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Messages.smash"));
            var xmlDoc = new XmlDocument();
            if (fi.Exists)
            {
                using (FileStream fs = fi.Open(FileMode.Open))
                {
                    xmlDoc.Load(fs);
                }
                XmlNode messages = xmlDoc.GetElementsByTagName("SavedMessages")[0];
                foreach (XmlNode xmlNode in messages.ChildNodes)
                {
                    if (xmlNode.InnerText == savedMessagesBox.SelectedItem.ToString())
                    {
                        xmlNode.ParentNode.RemoveChild(xmlNode);
                    }
                }

                xmlDoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Messages.smash"));
            }

            PopulateListbox();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSavedMessage();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=TPJGB7RJGQDJE");
        }

        private void emailAddressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertItem("{email}");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void firstNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertItem("{firstname}");
        }

        private void getHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

        private void GetLoginInfo()
        {
            prompt.ShowDialog();
            if (prompt.Cancel)
            {
                notifyIcon1.Dispose();
                Environment.Exit(0);
            }
            const string clientLoginPage =
                "https://accounts.google.com/ServiceLogin?service=grandcentral";
            const string clientLoginAuthPage = "https://accounts.google.com/ServiceLoginAuth";
            string data = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(clientLoginPage);
                request.CookieContainer = cookieJar;
                var response = (HttpWebResponse)request.GetResponse();
                var re = new Regex("name=\"GALX\"\\s*type=\"hidden\"\\s*value=\"([^\"]+)\"", RegexOptions.IgnoreCase);
                MatchCollection matches = re.Matches(new StreamReader(response.GetResponseStream()).ReadToEnd());
                string galx = matches[0].Value;
                int location = galx.IndexOf("value=", StringComparison.Ordinal) + 7;
                galx = galx.Substring(location, galx.LastIndexOf('\"') - location);
                response.Close();
                request = (HttpWebRequest)WebRequest.Create(clientLoginAuthPage);
                request.CookieContainer = cookieJar;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                UserName = prompt.username.Text;
                if (UserName.IndexOf('@') < 0)
                    UserName += "@gmail.com";
                data += "Email=" + UserName + "&Passwd=" + prompt.password.Text + "&continue=" +
                        "https://www.google.com/voice/account/signin" + "&GALX=" + galx;

                csvPath = prompt.csvpath.Text;
                fName = prompt.firstName.Text;
                lName = prompt.lastName.Text;
                phone = prompt.mobilePhone.Text;
                email = prompt.emailAddress.Text;
                categories = prompt.categories.Text;

                var encoding = new UTF8Encoding();
                byte[] bytes = encoding.GetBytes(data);
                request.ContentLength = bytes.Length;
                using (Stream writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                    writeStream.Flush();
                }

                response = (HttpWebResponse)request.GetResponse();
                re = new Regex("name=\"_rnr_se\".*?value=\"(.*?)\"", RegexOptions.IgnoreCase);
                matches = re.Matches(new StreamReader(response.GetResponseStream()).ReadToEnd());
                if (matches.Count > 0)
                {
                    rnrKey = matches[0].Value;
                    location = rnrKey.IndexOf("value", StringComparison.Ordinal);
                    location = rnrKey.IndexOf("\"", location, StringComparison.Ordinal) + 1;
                    rnrKey = rnrKey.Substring(location, rnrKey.LastIndexOf('\"') - location);
                }

                response.Close();
            }
            catch (Exception)
            { }
        }

        private string GetUserToken()
        {
            string voiceUrl = "https://www.google.com/voice/c/b/" + UserName + "/ui/ContactManager";
            string result = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(voiceUrl);
                request.CookieContainer = cookieJar;
                var response = (HttpWebResponse)request.GetResponse();
                var inStream = new StreamReader(response.GetResponseStream());
                string fullTextOfResponse = inStream.ReadToEnd();
                inStream.Close();
                response.Close();
                var re = new Regex("var\\s+tok\\s*=\\s*'([^']+)'", RegexOptions.IgnoreCase);
                MatchCollection matches = re.Matches(fullTextOfResponse);
                if (matches.Count > 0)
                {
                    result = matches[0].Value;
                    result = result.Substring(result.IndexOf('\'') + 1);
                    result = result.Substring(0, result.IndexOf('\''));
                }
            }
            catch (Exception)
            { }
            return result;
        }

        private void GroupSelectorSelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = groupSelector.SelectedItem.ToString();
            if (selected != "" && selected != "-Select a group-")
            {
                SetContacts(selected);
                selectedContacts.Focus();
                groupSelector.Items.Remove("-Select a group-");
            }
            else
            {
                selectedContacts.Items.Clear();
            }
            foreach (int i in selectedContacts.CheckedIndices)
            {
                selectedContacts.SetItemCheckState(i, CheckState.Unchecked);
            }
            Invalidate();
        }

        private void InsertItem(string item)
        {
            if (!textMessageInputBox.Text.EndsWith(" ") && textMessageInputBox.Text.Length > 0)
            {
                textMessageInputBox.Text += " ";
            }
            textMessageInputBox.Text += item;
            textMessageInputBox.Select(textMessageInputBox.Text.Length, 0);
        }

        private void lastNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertItem("{lastname}");
        }

        private void LoadContacts()
        {
            if (File.Exists(csvPath) && !prompt.radioButton1.Checked)
            {
                BuildContactList(CsvParser.ParseCSVFile(csvPath, true));
                outputTextBox.Text += DateTime.Now.ToString("hh:mm:ss tt") + ": Loaded contacts from local." + Environment.NewLine;
                return;
            }
            string contactsUrl = "https://www.google.com/voice/c/b/" + UserName +
                                 "/data/export?groupToExport=%5EMine&exportType=ALL&out=OUTLOOK_CSV";
            contactsUrl += "&tok=" + GetUserToken();
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(contactsUrl);
                request.CookieContainer = cookieJar;
                var response = (HttpWebResponse)request.GetResponse();
                var inStream = new StreamReader(response.GetResponseStream());
                string fullTextOfResponse = inStream.ReadToEnd();
                DataTable data = CsvParser.ParseCSVText(fullTextOfResponse, true);
                inStream.Close();
                response.Close();
                BuildContactList(data);
                outputTextBox.Text += DateTime.Now.ToString("hh:mm:ss tt") + ": Loaded contacts from Google." + Environment.NewLine;
            }
            catch (Exception)
            { }
        }

        private void LoginWindowTimerTick(object sender, EventArgs e)
        {
            if (!formLoaded) return;
            loginWindowTimer.Stop();
            PresentLogin();
        }

        private void MainUI_Closing(object sender, CancelEventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void phoneNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertItem("{phone}");
        }

        private void PopulateListbox()
        {
            savedMessagesBox.Items.Clear();

            var fi = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Messages.smash"));
            var xmlDoc = new XmlDocument();
            if (fi.Exists)
            {
                using (FileStream fs = fi.Open(FileMode.Open))
                {
                    xmlDoc.Load(fs);
                }
                XmlNode messages = xmlDoc.GetElementsByTagName("SavedMessages")[0];
                foreach (XmlNode xmlNode in messages.ChildNodes)
                {
                    savedMessagesBox.Items.Add(xmlNode.InnerText.Trim());
                }
            }
        }

        private void PresentLogin()
        {
            GetLoginInfo();
            LoadContacts();
            foreach (string key in contactGroups.Keys.Where(key => key != ""))
            {
                groupSelector.Items.Add(key);
            }
            SetEnabled(true);
            outputTextBox.Text += DateTime.Now.ToString("hh:mm:ss tt") + ": Logged in successfully!" + Environment.NewLine;
            groupSelector.Items.Add("-Select a group-");
            groupSelector.SelectedItem = "-Select a group-";
        }

        private void reloadContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMessageInputBox.Text = "";
            delayBox.Value = 2;
            groupSelector.SelectedItem = "-Select a group-";
            selectAll.Checked = false;
            for (int i = 0; i < selectedContacts.Items.Count; i++)
                selectedContacts.SetItemChecked(i, false);
            contactInfoLabel.Text = "";
            GetUserToken();
            outputTextBox.Text += DateTime.Now.ToString("hh:mm:ss tt") + ": New session started." + Environment.NewLine;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var fi = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Messages.smash"));
            var xmlDoc = new XmlDocument();
            if (fi.Exists)
            {
                using (FileStream fs = fi.Open(FileMode.Open))
                {
                    xmlDoc.Load(fs);
                }
                XmlNode child = xmlDoc.CreateElement("Message");
                child.InnerText = textMessageInputBox.Text;

                XmlNode messages = xmlDoc.GetElementsByTagName("SavedMessages")[0];
                messages.AppendChild(child);

                xmlDoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Messages.smash"));
            }

            PopulateListbox();
        }

        private void savedMessagesBox_DoubleClick(object sender, EventArgs e)
        {
            if (savedMessagesBox.SelectedItem != null)
            {
                if (savedMessagesBox.SelectedItem.ToString().Length != 0)
                {
                    textMessageInputBox.Text = savedMessagesBox.SelectedItem.ToString();
                }
            }
        }

        private void savedMessagesBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSavedMessage();
            }
        }

        private void savedMessagesBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int indexOfItemUnderMouseToDrag;

                indexOfItemUnderMouseToDrag = savedMessagesBox.IndexFromPoint(e.X, e.Y);

                if (indexOfItemUnderMouseToDrag != ListBox.NoMatches)
                {
                    savedMessagesBox.SelectedIndex = indexOfItemUnderMouseToDrag;
                }
            }
        }

        private void SelectAllCheckBox(object sender, EventArgs e)
        {
            if (selectAll.Checked)
            {
                for (int i = 0; i < selectedContacts.Items.Count; i++)
                    selectedContacts.SetItemChecked(i, true);
            }
            if (!selectAll.Checked)
            {
                for (int i = 0; i < selectedContacts.Items.Count; i++)
                    selectedContacts.SetItemChecked(i, false);
            }
        }

        private void SelectedContactsSelectedIndexChanged(object sender, EventArgs e)
        {
            var person = (Contact)selectedContacts.SelectedItem;
            if (person == null)
            {
            }
            else
            {
                contactInfoLabel.Text = "Name: " + person.Name + Environment.NewLine + "Number: " + person.MobilePhone +
                                        Environment.NewLine + "Email: " + person.Email;
            }

            label2.Text = selectedContacts.CheckedIndices.Count.ToString();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (backgroundSendingToolStripMenuItem.Checked)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                notifyIcon1.ShowBalloonTip(1000, "Send From Background", "Messages will be sent in the background.", ToolTipIcon.Info);
            }

            if (Int32.Parse(delayBox.Text.Trim()) < 10 && selectedContacts.CheckedItems.Count > 100)
            {
                var result = MessageBox.Show(
                    "Given your current choices, some of your contacts may not recieve your message. Consider lengthening the delay time. Send anyway?",
                    "Send Anyway?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (textMessageInputBox.Text == "")
                    {
                        MessageBox.Show(this, "Remember to type your message before clicking 'Send'.", "Error: Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Int32.Parse(delayBox.Text.Trim()) < 2)
                        {
                            MessageBox.Show(this, "Number in delay box must be more than 1.", "Error: No Delay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var t = new Thread(TextSelected) { IsBackground = true };
                            t.Start();
                        }
                    }
                }
            }
            else
            {
                if (textMessageInputBox.Text == "")
                {
                    MessageBox.Show(this, "Remember to type your message before clicking 'Send'.", "Error: Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Int32.Parse(delayBox.Text.Trim()) < 2)
                    {
                        MessageBox.Show(this, "Number in delay box must be more than 1.", "Error: No Delay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var t = new Thread(TextSelected) { IsBackground = true };
                        t.Start();
                    }
                }
            }
        }

        private bool SendText(string textMessage, Contact person)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            bool success = false;
            string voiceSMSPage = "https://www.google.com/voice/sms/send/";
            string data = "";

            try
            {
                request = (HttpWebRequest)WebRequest.Create(voiceSMSPage);
                request.CookieContainer = cookieJar;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                data += "_rnr_se=" + HttpUtility.UrlEncode(rnrKey.Trim());
                data += "&phoneNumber=" + HttpUtility.UrlEncode(person.MobilePhone.Trim());
                data += "&text=" + HttpUtility.UrlEncode(textMessage.Trim().Replace("{firstname}", person.FirstName).Replace("{lastname}", person.LastName).Replace("{phone}", person.MobilePhone).Replace("{email}", person.Email));

                UTF8Encoding encoding = new UTF8Encoding();
                byte[] bytes = encoding.GetBytes(data);
                request.ContentLength = bytes.Length;

                using (Stream writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                    writeStream.Flush();
                }

                response = (HttpWebResponse)request.GetResponse();
                string s = new StreamReader(response.GetResponseStream()).ReadToEnd();
                success = s.Contains("\"ok\":true");
                response.Close();
            }
            catch
            {
            }
            return success;
        }

        private void SetContacts(string selected)
        {
            selectedContacts.Items.Clear();
            foreach (Contact person in contactGroups[selected])
            {
                selectedContacts.Items.Add(person);
                selectedContacts.SetItemChecked(selectedContacts.Items.IndexOf(person), true);
            }
        }

        private void SetEnabled(bool setting)
        {
            sendButton.Enabled = setting;
            saveButton.Enabled = setting;
            savedMessagesBox.Enabled = setting;
            textMessageInputBox.Enabled = setting;
            delayBox.Enabled = setting;
            selectAll.Enabled = setting;
            delayBox.Enabled = setting;
            if (setting)
            {
                groupSelector.Focus();
            }
        }

        private void TextMessageInputBoxTextChanged(object sender, EventArgs e)
        {
            int position = textMessageInputBox.SelectionStart;
            int length = textMessageInputBox.Text.Length;
            textMessageInputBox.Text = textMessageInputBox.Text.Replace("\n", "");
            textMessageInputBox.Text = textMessageInputBox.Text.Replace("\r", "");
            textMessageInputBox.SelectionStart = position - (length - textMessageInputBox.Text.Length);
            int textsUsed = textMessageInputBox.Text.Length / 160 + 1;
            int maxCharsRemaining = textMessageInputBox.MaxLength - textMessageInputBox.Text.Length;
            charsRemaining.Text = maxCharsRemaining + " | Message " + textsUsed + " of 3";
            if (textsUsed > 2)
            {
                charsRemaining.Text = maxCharsRemaining + " | Really?";
            }
        }

        private void TextSelected()
        {
            string textMessage = "";
            var selectedPeople = new List<Contact>();
            if (sendButton.InvokeRequired)
            {
                sendButton.Invoke(new MethodInvoker(delegate { sendButton.Enabled = false; }));
            }
            if (textMessageInputBox.InvokeRequired)
            {
                textMessageInputBox.Invoke(new MethodInvoker(delegate
                {
                    textMessageInputBox.Enabled = false;
                    textMessage = textMessageInputBox.Text.Trim();
                }));
            }
            if (selectedContacts.InvokeRequired)
            {
                selectedContacts.Invoke(new MethodInvoker(
                                            () => selectedPeople.AddRange(selectedContacts.CheckedItems.Cast<Contact>())));
            }
            foreach (Contact person in selectedPeople)
            {
                if (person.MobilePhone.Length > 0)
                {
                    bool result = SendText(textMessage, person);

                    if (outputTextBox.InvokeRequired)
                    {
                        Contact person1 = person;
                        Contact person2 = person;

                        outputTextBox.Invoke(new MethodInvoker(
                                                 delegate
                                                 {
                                                     outputTextBox.Text += (result
                                                                                ? DateTime.Now.ToString("hh:mm:ss tt") +
                                                                                  ": Successfully sent to "
                                                                                : DateTime.Now.ToString("hh:mm:ss tt") +
                                                                                  ": Unsuccessful to ") +
                                                                           person1.Name + "." + Environment.NewLine;
                                                     outputTextBox.SelectionStart = outputTextBox.Text.Length;
                                                     outputTextBox.ScrollToCaret();
                                                 }));
                    }
                    Thread.Sleep(Int32.Parse(delayBox.Text.Trim()) * 1000);
                }
                else
                {
                    if (outputTextBox.InvokeRequired)
                    {
                        Contact person1 = person;
                        outputTextBox.Invoke(new MethodInvoker(
                                                 delegate
                                                 {
                                                     outputTextBox.Text += DateTime.Now.ToString("hh:mm:ss tt") + ": " +
                                                                           person1.Name +
                                                                           " does not have a mobile number." + Environment.NewLine;
                                                 }));
                    }
                }
            }
            notifyIcon1.ShowBalloonTip(1000, "Sending Complete", "Sending has completed.", ToolTipIcon.Info);
            if (sendButton.InvokeRequired)
            {
                sendButton.Invoke(new MethodInvoker(delegate { sendButton.Enabled = true; }));
            }
            if (textMessageInputBox.InvokeRequired)
                textMessageInputBox.Invoke(new MethodInvoker(delegate
                {
                    textMessageInputBox.Enabled = true;
                }));
        }

        private void useToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMessageInputBox.Text = savedMessagesBox.SelectedItem.ToString();
        }
    }
}