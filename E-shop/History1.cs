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
    public partial class History1 : Form
    {
        Staff st; Access ac;
        public History1(Staff st)
        {
            this.st = st;
            InitializeComponent();
            loadtable(st);
        }
        void loadtable(Staff st)
        {
            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.historyTable(st);
            historyd.DataSource = bs;
        }


        private void History1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
