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
        public profile(user us)
        {
            this.us = us;
            InitializeComponent();
            nametext.Text = us.name;
            emailtext.Text = us.email;
            adresstext.Text = us.address;
            phonetext.Text = us.phone;
            passwordtext.Text = us.password;
            label6.Text = us.username;
            duebox.Text = us.due.ToString();
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
