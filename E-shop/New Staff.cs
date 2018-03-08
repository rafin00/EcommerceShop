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
    public partial class New_Staff : Form
    {
        public New_Staff()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Access ac = new Access();
            Staff st = new Staff();
            st.username = usernametext.Text;
            st.name = nametext.Text;
            st.phone = (phonetext.Text);
            st.password = (phonetext.Text);

            if (ac.addstaff(st))
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Nope");
        }
    }
}
