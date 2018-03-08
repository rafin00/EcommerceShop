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
    public partial class Staffmain : Form
    {
        Staff st;
        public Staffmain(Staff st)
        {
            this.st = st;
            InitializeComponent();
        }

        private void ordersb_Click(object sender, EventArgs e)
        {
            Nottaken nt = new Nottaken(st);
            nt.ShowDialog();
        }

        private void history_Click(object sender, EventArgs e)
        {
            History1 hs = new History1(st);
            hs.ShowDialog();
        }

        private void taken_Click(object sender, EventArgs e)
        {
            Taken tk = new Taken(st);
            tk.ShowDialog();

        }
    }
}
