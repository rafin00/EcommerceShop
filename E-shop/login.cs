using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Baccess;

namespace E_shop
{
    public partial class login : Form
    {
        public static bool logged=false;
        Access ac; Staff st;
       Button loginb;
        user us=new user();
        public login(Button loginb,user us )
        {
            InitializeComponent();
            this.us = us;
            this.loginb = loginb;
        }
        public login()
        {
            InitializeComponent();
            
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(usernametext.Text) || String.IsNullOrWhiteSpace(passwordtext.Text))
            {
                if (String.IsNullOrWhiteSpace(usernametext.Text))
                {
                    invuser.Visible = true;
                }
                else
                { invuser.Visible = false; }

                if (String.IsNullOrWhiteSpace(passwordtext.Text))
                {
                    invpass.Visible = true;
                }
                else
                { invpass.Visible = false; }
            }

            else
            {
               
                
                ac = new Access();

                if (usernametext.Text[0] == 'A' && usernametext.Text[1] == '-')
                {
                  //  MessageBox.Show("kl");
                    admin ad = new admin();
                    ad.username = usernametext.Text;
                    ad.password = passwordtext.Text;
                    if (ac.adminlogin(ad))
                    {
                        invpass.Visible = false;
                        invuser.Visible = false;
                        logged = true;
                        loginb.Text = ad.username;
                        
                        this.Hide();
                        AdminPanel ap = new AdminPanel();
                       ap.ShowDialog();
                      
                    }
                    else
                    {

                        invup.Visible = true;
                        //MessageBox.Show("Nope");
                    }
                }
                else if (usernametext.Text[0] == 'S' && usernametext.Text[1] == '-')
                {
                    st = new Staff();
                    st.username = usernametext.Text;
                    st.password = passwordtext.Text;
                    object ob = ac.stafflogin(st);
                    if (ob.GetType() == typeof(Staff))
                    {
                        invpass.Visible = false;
                        invuser.Visible = false;
                        //logged = true;
                        loginb.Text = us.username;
                        st = (Staff)ob;
                        //ac.genorder(us);
                        this.Hide();
                        /*StaffPanel sp = new StaffPanel(st);
                        sp.ShowDialog();
                        */
                        Staffmain sm = new Staffmain(st);
                        sm.ShowDialog();
                        //MessageBox.Show("Success!!");
                    }
                    else
                    {

                        invup.Visible = true;
                        //MessageBox.Show("Nope");
                    }
                }
                else
                {
                    
                    us.username = usernametext.Text;
                    us.password = passwordtext.Text;
                    object ob = ac.login(us);
                    if (ob.GetType()==typeof(user))
                    {
                        invpass.Visible = false;
                        invuser.Visible = false;
                        logged = true;
                        loginb.Text = us.username;
                        us = (user)ob;
                        ac.genorder(us);
                        this.Hide();

                        //MessageBox.Show("Success!!");
                    }
                    else
                    {

                        invup.Visible = true;
                        //MessageBox.Show("Nope");
                    }
                }
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup sup = new signup();
            sup.ShowDialog();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void fplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Recovery rc = new Recovery();
            rc.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
