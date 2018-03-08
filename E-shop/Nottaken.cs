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
    public partial class Nottaken : Form
    {
        Access ac; Staff st;
        public Nottaken(Staff st)
        {
            this.st = st;
            InitializeComponent();
            loadtable();
        }
        void loadtable()
        {
            ac = new Access();

            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getntTable();
           ntdgv.DataSource = bs;
        }

        private void Nottaken_Load(object sender, EventArgs e)
        {

        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            loadtable();
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            Update(st);
           // loadtable();
        }
        void Update(Staff st)
        {
         
        
             Order od = new Order(); 
            for (int i = 0; i < ntdgv.Rows.Count; i++)
            {
                od.staffusername = st.username;
                od.taken = (bool)(ntdgv.Rows[i].Cells["Take"].Value);
                od.Id = Convert.ToInt32(ntdgv.Rows[i].Cells["Order ID"].Value);
               // od.taken = (bool)(spdgv.Rows[i].Cells["Take Order"].Value);
                // MessageBox.Show(pd.productid.ToString()+""+pd.quantity.ToString());
                  //if(od.taken)
                  {ac.updatent(od);}
                  
                //                sum += (Convert.ToInt32(scgdv.Rows[i].Cells[2].Value)) * (Convert.ToInt32(scgdv.Rows[i].Cells[1].Value));
            }
        }
        
    }
}
