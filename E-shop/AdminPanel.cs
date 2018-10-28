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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void newproductb_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            np.ShowDialog();
        }

        private void updateproductb_Click(object sender, EventArgs e)
        {
            Update_Product up = new Update_Product();
            up.ShowDialog();
        }

        private void deleteproductb_Click(object sender, EventArgs e)
        {
            DeleteProduct dp = new DeleteProduct();
            dp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_Staff ns = new New_Staff();
            ns.ShowDialog();
        }

        private void udstaffb_Click(object sender, EventArgs e)
        {
            UDStaff uds = new UDStaff();
            uds.ShowDialog();
        }

        private void stafflistb_Click(object sender, EventArgs e)
        {
            Stafflist sl = new Stafflist();
            sl.ShowDialog();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void audb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
