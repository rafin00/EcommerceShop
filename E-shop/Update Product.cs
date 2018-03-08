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
using System.IO;

namespace E_shop
{
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }
        Products pd;
        Access ac;
        private void searchb_Click(object sender, EventArgs e)
        {
            pd = new Products();
            pd.productid = Convert.ToInt32(productidtext.Text);
            ac = new Access();
            object ob= ac.search(pd);
           // MessageBox.Show(ob.GetType().ToString());
            if (ob.GetType() == typeof(bool))
            {
                invnf.Visible = true;
            }
            else// if(ob.GetType()==typeof(Products))
            {
                invnf.Visible = false;
                //pd = new Products();
                pd=(Products)ob;
                nametext.Text = pd.name;
                quantitytext.Text = pd.quantity.ToString();
                pricetext.Text = pd.price.ToString();
                MemoryStream ms = new MemoryStream(pd.img);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromStream(ms);
                pathtext.Text = pd.path;
               // MessageBox.Show("here");
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            
            pd.productid = Convert.ToInt32(productidtext.Text);
            pd.name = nametext.Text;
            pd.quantity = Convert.ToInt32(quantitytext.Text);
            pd.price = Convert.ToInt32(pricetext.Text);
            pd.path = pathtext.Text;

            if (ac.updateproduct(pd))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("nope");
            }

        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                pictureBox.Image = new Bitmap(path);
                pathtext.Text = path;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Update_Product_Load(object sender, EventArgs e)
        {

        }

        private void deleteb_Click(object sender, EventArgs e)
        {


        }
    }
}
