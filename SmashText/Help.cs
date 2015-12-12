using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SmashText
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            if (MainUI.UserName != null)
            {
                emailBox.Text = MainUI.UserName;
            }
            else
            {
                emailBox.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress(emailBox.Text, nameBox.Text);
            var toAddress = new MailAddress("support@smashtext.com", "Matthew Despain");
            string fromPassword = Login.Passwrd;
            string subject = subjectBox.Text;
            string body = "From: " + nameBox.Text + " <" + emailBox.Text + ">" + Environment.NewLine +
                          Environment.NewLine + messageBox.Text;

            try
            {
                var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                {
                    smtp.Send(message);
                }

                MessageBox.Show(this, "Your message has been sent.", "Message Sent", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Close();
            }
            catch
            {
            }
        }
    }
}