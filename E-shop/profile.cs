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

namespace E_shop
{
    public partial class profile : Form
    {
        user us;
        Access ac = new Access();
        public profile(user us)
        {
            this.us = (user)ac.login(us);
            InitializeComponent();
            nametext.Text = this.us.name;
            emailtext.Text = this.us.email;
            adresstext.Text = this.us.address;
            phonetext.Text = this.us.phone;
            passwordtext.Text = this.us.password;
            label6.Text = this.us.username;
            duebox.Text = this.us.due.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
