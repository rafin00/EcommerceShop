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
    public partial class DeleteProduct : Form
    {
        string dir;
        public DeleteProduct()
        {
            InitializeComponent();

            dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            dir = (dir.Substring(0, dir.LastIndexOf("\\") + 1) + "Data\\Products\\");
        }
        Products pd; Access ac;
        private void deleteb_Click(object sender, EventArgs e)
        {
            pd.productid = Convert.ToInt32(productidtext.Text);
            if (ac.deleteproduct(pd))
            {
                MessageBox.Show("Success");
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Nope");
            }
        }

        private void productidtext_TextChanged(object sender, EventArgs e)
        {
            deleteb.Enabled = false;
        }

        private void searchb_Click(object sender, EventArgs e)
        {
            pd = new Products();
            pd.productid = Convert.ToInt32(productidtext.Text);
            ac = new Access();
            object ob = ac.search(pd);
            // MessageBox.Show(ob.GetType().ToString());
            if (ob.GetType() == typeof(bool))
            {
                invnf.Visible = true;
               // return false;
            }
            else// if(ob.GetType()==typeof(Products))
            {
                invnf.Visible = false;
                //pd = new Products();
                pd = (Products)ob;

                nametext.Text = pd.name;
                quantitytext.Text = pd.quantity.ToString();
                pricetext.Text = pd.price.ToString();
               
                pictureBox.Image = Image.FromFile(dir+pd.path);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                deleteb.Enabled = true;
            }
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
