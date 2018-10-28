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
        string dir;
        public Update_Product()
        {
            InitializeComponent();

            dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            dir = (dir.Substring(0, dir.LastIndexOf("\\") + 1) + "Data\\Products\\");

        }
        Products pd;
        Access ac;
        private void searchb_Click(object sender, EventArgs e)
        {
            invnf.Visible = false;
            pd = new Products();
            if (productidtext.Text != "")
            {
                invnf.Text = "Not Found";
                pd.productid = Convert.ToInt32(productidtext.Text);

                ac = new Access();
                object ob = ac.search(pd);
                // MessageBox.Show(ob.GetType().ToString());
                if (ob.GetType() == typeof(bool))
                {
                    invnf.Visible = true;
                }
                else// if(ob.GetType()==typeof(Products))
                {
                    invnf.Visible = false;
                    //pd = new Products();
                    pd = (Products)ob;
                    nametext.Text = pd.name;
                    quantitytext.Text = pd.quantity.ToString();
                    pricetext.Text = pd.price.ToString();
                    
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(dir+pd.path);
                    pathtext.Text = dir+pd.path;
                  
                    // MessageBox.Show("here");
                }
            }
            else
            {
                invnf.Text = "Id cannot be empty"; invnf.Visible = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            pd.productid = Convert.ToInt32(productidtext.Text);
            pd.name = nametext.Text;
            pd.quantity = Convert.ToInt32(quantitytext.Text);
            pd.price = Convert.ToInt32(pricetext.Text);
            pd.path = pathtext.Text;
            Products pro = new Products { productid = pd.productid };
            pro = (Products)ac.search(pro);
           
            if (ac.updateproduct(pd))
            {
                MessageBox.Show("Success");
               // File.Delete(dir + pro.path);
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
                ofd.Dispose();
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
