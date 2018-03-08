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
    public partial class main : Form
    {
       // public static bool logged = false;
        int t1 = 30;
        user us=new user();
        public main()
        {
            InitializeComponent();
            loginb.BringToFront();
            Loadtable();
            uidgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        Access ac;
        void Loadtable()
        {

            ac = new Access();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac.getuiTable();
           uidgv.DataSource = bs;
            ((DataGridViewImageColumn)uidgv.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;
           


        }
        
        private void login_Click(object sender, EventArgs e)
        {
           // this.Hide();
            if (login.logged)
            {
                login.logged = false;
                loginb.Text = "Login";
            }
            else
            {
                login log = new login(loginb, us);
                log.ShowDialog();
            }
            
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.panel1.Size = new Size(this.panel1.Size.Width, t1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           // this.mcata.Size = new Size(this.mcata.Size.Width,150);
            //timer1.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           // this.mcata.Size = new Size(this.mcata.Size.Width, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void men_Click(object sender, EventArgs e)
        {

        }

        private void women_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void womenbutton_Click(object sender, EventArgs e)
        {

        }

        private void watches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void mensbutton_MouseLeave(object sender, EventArgs e)
        {
            //menpanel.Visible = false;
        }

        private void mensbutton_MouseHover(object sender, EventArgs e)
        {
            //menpanel.Size(316, 30);
            menpanel.Size = new Size(316, 30);
        }

        private void menpanel_MouseHover(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void menpanel_MouseLeave(object sender, EventArgs e)
        {
           // menpanel.Size = new Size(95, 30);
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void watches_MouseHover(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void menpanel_MouseEnter(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void watches_MouseEnter(object sender, EventArgs e)
        {
            menpanel.Size = new Size(316, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filldata()
        {
           /* //mtshirtsdataGrid
            uidgv.ColumnCount = 3;
            uidgv.Columns[0].Name = "Name";
            uidgv.Columns[1].Name = "Position";
            uidgv.Columns[2].Name = "Team";
            //CONSTRUCT THE IMAGE COLUMN
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Photo";
            imgCol.Name = "Photo";
            uidgv.Columns.Add(imgCol);
            //DATA
            //FIRST row

            Image img = Image.FromFile(@"C:\Users\User\Pictures\Saved Pictures\pic.png");
            //THEN AD ROW DATA
            Object[] row = new Object[] { "Van Perise", "Striker", "Man Utd", img };
            ((DataGridViewImageColumn)uidgv.Columns[3]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            uidgv.Rows.Add(row);
           // mtshirtsdataGrid.r*/
            

        }

        private void tshirt_MouseClick(object sender, MouseEventArgs e)
        {
           // filldata();
        }

        private void uidgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = uidgv.SelectedRows[0].Cells[0].Value.ToString();
            string name = uidgv.SelectedRows[0].Cells[1].Value.ToString();
            int price = Convert.ToInt32(uidgv.SelectedRows[0].Cells[2].Value);
            int quantity = Convert.ToInt32(uidgv.SelectedRows[0].Cells[3].Value);
            byte[] img = (byte[])uidgv.SelectedRows[0].Cells[4].Value;
            
            Selectedproduct spd = new Selectedproduct(id, name, price, quantity, img,us);
            spd.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
        }

        private void shchl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (login.logged)
            {
                ShoppingChart sc = new ShoppingChart(us);
                sc.ShowDialog();
            }
            else MessageBox.Show("Log in first");
        }

        private void cagories_Click(object sender, EventArgs e)
        {

        }

        private void refreshb_Click(object sender, EventArgs e)
        {
            Loadtable();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (login.logged)
            {
                Trans ts = new Trans(us);
                ts.ShowDialog();
            }
            else
                MessageBox.Show("Login First");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (login.logged)
            {
                profile p = new profile(us);
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login first");
            }
        }
    }
}
