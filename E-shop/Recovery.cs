using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace E_shop
{
    public partial class Recovery : Form
    {
        public Recovery()
        {
            InitializeComponent();
        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        { 
        }

        private void srecovery_Click(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (String.IsNullOrWhiteSpace(emailtext.Text))
            {
                einv.Visible = true;
            }
            else
            {
                if (Regex.IsMatch(emailtext.Text, pattern))
                {
                    /*using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "gmail.com";
                        smtp.UseDefaultCredentials = false;
                        NetworkCredential netCred = new NetworkCredential("utshaw00@gmail.com", "ulti@MATE5");
                        smtp.Credentials = netCred;
                        smtp.EnableSsl = true;

                        using (MailAddress msg = new MailAddress("utshaw00@gmail.com", emailtext.Text))
                        {
                            msg.s = "Hello";

                        }

                    }*/
                    einv.Visible =false;
                    try
                    {
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress("utshaw00@gmail.com");
                        message.To.Add(new MailAddress(emailtext.Text));
                        message.Subject = "Test";
                        message.Body = "Content";

                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("utshaw00@gmail.com", "ulti@MATE5");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("err: " + ex.Message);
                    }


                }
                else
                {
                    einv.Visible = true;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
        }

        private void Recovery_Load(object sender, EventArgs e)
        {

        }
    }
}
