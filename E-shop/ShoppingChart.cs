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
    public partial class ShoppingChart : Form
    {
        BindingSource bs = new BindingSource();
        Access ac;
        user us;
        public ShoppingChart(user us)
        {
            this.us = us;
            InitializeComponent();
            ac = new Access();
           
            bs.DataSource = ac.gescTable();
            scgdv.DataSource = bs;
                totaltext.Text=gettotal();
        }

        string gettotal()
        {

            int sum = 0;
            for (int i = 0; i < scgdv.Rows.Count; ++i)
            {
                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value))*(Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
            return sum.ToString();
        }


        void update()
        {
            ac.updaterec2();
            Products pd = new Products();
            for (int i = 0; i < scgdv.Rows.Count; ++i)
            {
                pd.productid = Convert.ToInt32(scgdv.Rows[i].Cells["Product ID"].Value);
                pd.quantity = (Convert.ToInt32(scgdv.Rows[i].Cells["Quantity"].Value));
               // MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                ac.updaterec(pd, Convert.ToInt32(totaltext.Text));
//                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
           // return sum.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cashoutb_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(totaltext.Text) == 0)
            {
                scinv.Visible = true;
            }
            else
            {
                if (ac.cashout(Convert.ToInt32(totaltext.Text)))
                {   
                    MessageBox.Show("Done");
                   
                    update();
                    ac.genorder(us);

                }
                else
                    MessageBox.Show("Provlen");

            }
        }

        private void ShoppingChart_Load(object sender, EventArgs e)
        {

        }

        private void totaltext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
