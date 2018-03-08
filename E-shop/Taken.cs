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
    public partial class Taken : Form
    {
        Access ac;
        Staff st;
        public Taken(Staff st)
        {
            this.st = st;
            InitializeComponent();
            loadtable(st);
        }
        void loadtable(Staff st)
    {
        ac = new Access();
            
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getspTable(st);
            tdgv.DataSource = bs;
    }


        Order od;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Taken_Load(object sender, EventArgs e)
        {

        }

        private void refreshb_Click(object sender, EventArgs e)
        {
            loadtable(st);
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            upteken(st);
        }
        void upteken(Staff st)
        {
             Order od = new Order(); od.staffusername = st.username;
            for (int i = 0; i < tdgv.Rows.Count; i++)
            {
                od.staffusername = st.username;
                od.complete = (bool)(tdgv.Rows[i].Cells["Delivered"].Value);
                od.Id = Convert.ToInt32(tdgv.Rows[i].Cells["Order ID"].Value);
               // od.taken = (bool)(spdgv.Rows[i].Cells["Take Order"].Value);
                // MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                   ac.updatespo(od);
                   if (od.complete == true)
                   {
                       ac.perup(od);

                   }
                //                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
        }
    }
}
