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
    public partial class StaffPanel : Form
    {
        Access ac; //Button bt;
        Staff st;
        public StaffPanel(Staff st)
        {
           // bt = saveb;
            this.st = st;
            InitializeComponent();
           // Loadtable();
                userl.Text=st.name;
        }
       /* void Loadtable()
        {
            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getspTable();
            spdgv.DataSource = bs;
           

        }*/
        void update()
        {

            Order od = new Order(); od.staffusername = st.username;
            for (int i = 0; i < spdgv.Rows.Count-1; i++)
            {
                od.staffusername = st.username;
               // od.complete = (bool)(spdgv.Rows[i].Cells["Delivered"].Value);
                od.Id = Convert.ToInt32(spdgv.Rows[i].Cells["Order ID"].Value);
                od.taken = (bool)(spdgv.Rows[i].Cells["Take Order"].Value);
                // MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                   ac.updatespo(od);
                //                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
        }

        private void apdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveb_Click(object sender, EventArgs e)
        {
           // saveb = bt;
           // Loadtable();
        }

        private void takenorders_Click(object sender, EventArgs e)
        {
            //saveb=ts;
            Loadtakentable();
            Taken tk = new Taken(st);
            tk.ShowDialog();
            
        }
        void Loadtakentable()
        {
            
                ac = new Access();
                BindingSource bs = new BindingSource();
                bs.DataSource = ac.getsptakenTable(st);
                spdgv.DataSource = bs;
               /* od.Id = Convert.ToInt32(spdgv.Rows[i].Cells["Order ID"].Value);
                od.taken = (bool)(spdgv.Rows[i].Cells["Take Order"].Value);
                */// MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                  
                //                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            
        }

        private void refreshb_Click(object sender, EventArgs e)
        {

        }

        private void saveb_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void StaffPanel_Load(object sender, EventArgs e)
        {
            Loadhistory();
        }
        void Loadhistory()
        {
            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getsphistoryTable(st);
            spdgv.DataSource = bs;
        }

        private void history_Click(object sender, EventArgs e)
        {
            Loadhistory();
        }

        private void ts_Click(object sender, EventArgs e)
        {
            updatesave();
        }
        void updatesave()
        {
            Order od = new Order(); od.staffusername = st.username;
            for (int i = 0; i < spdgv.Rows.Count - 1; i++)
            {
                od.staffusername = st.username;
                // od.complete = (bool)(spdgv.Rows[i].Cells["Delivered"].Value);
                od.Id = Convert.ToInt32(spdgv.Rows[i].Cells["Order ID"].Value);
                od.complete = (bool)(spdgv.Rows[i].Cells["Delivered"].Value);
                // MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                ac.updatedsp(od);
                //                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
        }


    }
}
