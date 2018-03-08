using Baccess;
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
    public partial class Stafflist : Form
    {
        public Stafflist()
        {
            InitializeComponent();
           /* staffdgv.Columns[0].Name = "Username";
            staffdgv.Columns[1].Name = "Name";
            staffdgv.Columns[2].Name = "Phone";
            staffdgv.Columns[3].Name = "Password";
           */ Loadtable();
        }

        void Loadtable()
        {
          
            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getTable();
            staffdgv.DataSource = bs;
            


        }
        Access ac;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  staffdgv.Columns[0].Name = "Username";
            staffdgv.Columns[1].Name = "Name";
            staffdgv.Columns[2].Name = "Phone";
            staffdgv.Columns[3].Name = "Password";
        */}

        private void Stafflist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Deliver' table. You can move, or remove it, as needed.
           // this.deliverTableAdapter.Fill(this.database1DataSet.Deliver);

        }
    }
}
