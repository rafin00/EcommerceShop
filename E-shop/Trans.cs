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
    public partial class Trans : Form
    {
        Access ac = new Access(); user us;
        public Trans(user us)
        {
            this.us = us;
            InitializeComponent();
            loadtable(us);
        }

        void loadtable(user us)
        {
            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.gettrTable(us);
            trdgv.DataSource = bs;
        }

        private void Trans_Load(object sender, EventArgs e)
        {

        }
    }
}
