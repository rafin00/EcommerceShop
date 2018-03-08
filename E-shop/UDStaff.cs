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
    public partial class UDStaff : Form
    {
        Staff st; Access ac;
        public UDStaff()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            st.username = usernametext.Text;
            if (ac.deletestaff(st))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Nope");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            st = new Staff();
            st.username = usernametext.Text;
            ac = new Access();
            object ob = ac.search(st);
            // MessageBox.Show(ob.GetType().ToString());
            if (ob.GetType() == typeof(bool))
            {
                invnf.Visible = true;
            }
            else// if(ob.GetType()==typeof(Products))
            {
                invnf.Visible = false;
                //pd = new Products();
                st = (Staff)ob;
                nametext.Text = st.name;
                phonetext.Text = st.phone;
                passwordtext.Text = st.password;
                
            }

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            st.username = usernametext.Text;
            st.name = nametext.Text;
            st.phone = phonetext.Text;
            st.password = passwordtext.Text;
            
            if (ac.updatestaff(st))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("nope");
            }
        }
    }
}
