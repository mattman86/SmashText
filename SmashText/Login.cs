using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SmashText
{
    public partial class Login : Form
    {
        public static string Passwrd;

        public Login()
        {
            InitializeComponent();
            CreateSmashFile("Preferences.smash");
            CreateSmashFile("Messages.smash");

            Cancel = false;

            LoadPrefs();
        }

        public bool Cancel { get; set; }

        private void Button1Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            if (userName.IndexOf('@') < 0)
                userName += "@gmail.com";
            Visible = false;
            Passwrd = password.Text;
            if (cbSaveLogin.Checked)
            {
                SetNode("Username", username.Text);
                SetNode("Password", Crypto.Encrypt(password.Text, username.Text));
                SetNode("CSVPath", csvpath.Text);
                SetNode("FirstName", firstName.Text);
                SetNode("LastName", lastName.Text);
                SetNode("EmailAddress", emailAddress.Text);
                SetNode("MobilePhone", mobilePhone.Text);
                SetNode("Categories", categories.Text);
                SetNode("SaveLogin", "true");
                if (radioButton2.Checked)
                {
                    SetNode("LocalCSV", "true");
                }
                else
                {
                    SetNode("LocalCSV", "false");
                }
            }
            if (!cbSaveLogin.Checked)
            {
                SetNode("UserName", string.Empty);
                SetNode("Password", string.Empty);
                SetNode("SaveLogin", "false");
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            Cancel = true;
            Visible = false;
        }

        private void Button3Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFile.FileName);
                sr.Close();
            }

            csvpath.Text = openFile.FileName;
        }

        private void CreateSmashFile(string fileName)
        {
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName)))
            {
                if (fileName == "Preferences.smash")
                {
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName), "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine + "<Preferences>" + Environment.NewLine + "</Preferences>");
                }
                if (fileName == "Messages.smash")
                {
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName), "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine + "<SavedMessages>" + Environment.NewLine + "</SavedMessages>");
                }
            }
        }

        private void CsvpathKeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPress(sender, e);
        }

        private void EnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Button2Click(sender, e);
            }
        }

        private void LoadPrefs()
        {
            var fi = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Preferences.smash"));
            var xmlDoc = new XmlDocument();
            if (fi.Exists)
            {
                using (FileStream fs = fi.Open(FileMode.Open))
                {
                    xmlDoc.Load(fs);
                }
                XmlNode prefs = xmlDoc.GetElementsByTagName("Preferences")[0];
                foreach (XmlNode xmlNode in prefs.ChildNodes)
                {
                    try
                    {
                        switch (xmlNode.Name)
                        {
                            case "Username":
                                {
                                    username.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "LocalCSV":
                                {
                                    radioButton2.Checked = Boolean.Parse(xmlNode.InnerText.Trim());
                                    break;
                                }
                            case "Password":
                                {
                                    password.Text = Crypto.Decrypt(xmlNode.InnerText.Trim(), username.Text);
                                    break;
                                }
                            case "SaveLogin":
                                {
                                    cbSaveLogin.Checked = Boolean.Parse(xmlNode.InnerText.Trim());
                                    break;
                                }
                            case "Categories":
                                {
                                    categories.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "CSVPath":
                                {
                                    csvpath.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "EmailAddress":
                                {
                                    emailAddress.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "FirstName":
                                {
                                    firstName.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "LastName":
                                {
                                    lastName.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                            case "MobilePhone":
                                {
                                    mobilePhone.Text = xmlNode.InnerText.Trim();
                                    break;
                                }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void PasswordKeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPress(sender, e);
        }

        private void RadioButton1CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Height = 175;

                SetEnabled(false);
                radioButton2.Checked = false;
                firstName.Text = "First Name";
                lastName.Text = "Last Name";
                mobilePhone.Text = "Mobile Phone";
                emailAddress.Text = "E-mail Address";
                categories.Text = "Categories";
                csvpath.Clear();
            }
        }

        private void RadioButton2CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Height = 348;

                SetEnabled(true);
                radioButton1.Checked = false;
                try
                {
                    var fi = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Preferences.smash"));
                    var xmlDoc = new XmlDocument();
                    if (fi.Exists)
                    {
                        using (FileStream fs = fi.Open(FileMode.Open))
                        {
                            xmlDoc.Load(fs);
                        }
                        XmlNode prefs = xmlDoc.GetElementsByTagName("Preferences")[0];
                        foreach (XmlNode xmlNode in prefs.ChildNodes)
                        {
                            try
                            {
                                switch (xmlNode.Name)
                                {
                                    case "Categories":
                                        {
                                            categories.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                    case "CSVPath":
                                        {
                                            csvpath.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                    case "EmailAddress":
                                        {
                                            emailAddress.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                    case "FirstName":
                                        {
                                            firstName.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                    case "LastName":
                                        {
                                            lastName.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                    case "MobilePhone":
                                        {
                                            mobilePhone.Text = xmlNode.InnerText.Trim();
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                catch
                { }
            }
        }

        private void SetEnabled(bool setting)
        {
            csvpath.Enabled = setting;
            browseButton.Enabled = setting;
            firstName.Enabled = setting;
            lastName.Enabled = setting;
            mobilePhone.Enabled = setting;
            emailAddress.Enabled = setting;
            categories.Enabled = setting;
        }

        private void SetNode(string item, string value)
        {
            try
            {
                string fileLoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Preferences.smash");
                XmlDocument doc = new XmlDocument();
                doc.Load(fileLoc);
                XmlNode node = doc.SelectSingleNode("/Preferences/" + item);
                if (node != null)
                {
                    node.InnerText = value;
                }
                else
                {
                    XmlNode child = doc.CreateElement(item);
                    child.InnerText = value;

                    XmlNode preferences = doc.GetElementsByTagName("Preferences")[0];
                    preferences.AppendChild(child);
                }
                doc.Save(fileLoc);
                doc = null;
            }
            catch
            { }
        }

        private void UsernameKeyDown(object sender, KeyEventArgs e)
        {
            EnterKeyPress(sender, e);
        }
    }
}