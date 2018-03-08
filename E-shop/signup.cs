using Baccess;
using Entity;
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

namespace E_shop
{
    public partial class signup : Form
    {
        
        public signup()
        {
           
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nametext.Text) || String.IsNullOrWhiteSpace(phonetext.Text) || String.IsNullOrWhiteSpace(emailtext.Text) || String.IsNullOrWhiteSpace(addresstext.Text) || String.IsNullOrWhiteSpace(pastext.Text) || String.IsNullOrWhiteSpace(cpastext.Text) || String.IsNullOrWhiteSpace(usernametext.Text))
            {
                if (String.IsNullOrWhiteSpace(nametext.Text))
                {
                    ninv.Visible = true;
                }
                else
                { ninv.Visible = false; }

                if (String.IsNullOrWhiteSpace(usernametext.Text))
                {
                    uinv.Visible = true;
                }
                else
                { uinv.Visible = false; }

                if (String.IsNullOrWhiteSpace(emailtext.Text))
                {
                    einv.Visible = true;
                }
                else
                { einv.Visible = false; }
                if (String.IsNullOrWhiteSpace(phonetext.Text))
                {
                    pinv.Visible = true;
                }
                else
                { pinv.Visible = false; }
                if (String.IsNullOrWhiteSpace(addresstext.Text))
                {
                    ainv.Visible = true;
                }
                else
                { ainv.Visible = false; }
                if (String.IsNullOrWhiteSpace(pastext.Text))
                {
                    pasinv.Visible = true;
                }
                else
                { pasinv.Visible = false; }
            }
            else if (pastext.Text != cpastext.Text)
            {
                dmatch.Visible = true;
            }
            else
            {
               user us = new user();
                us.username = usernametext.Text;
                us.name= nametext.Text;
                us.phone = phonetext.Text;
                us.email = emailtext.Text;
                us.password = pastext.Text;
                us.address = addresstext.Text;
                Access ac = new Access();
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (ac.add(us))
                {
                    MessageBox.Show("Success!!");
                }
                else
                    MessageBox.Show("Failed");
               // string mes = ac.save(us);
              //  MessageBox.Show(mes);
            }
            
        }

        private void signup_Load(object sender, EventArgs e)
        {
           
        }

        private void signup_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void signup_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
        }
    }
}
