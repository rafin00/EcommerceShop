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
using Baccess;
using Entity;

namespace E_shop
{
    public partial class NewProduct : Form
    {
        string path;
        public NewProduct()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName ;
                pictureBox.Image = new Bitmap(path);
                pathtext.Text = path;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveb_Click(object sender, EventArgs e)
        {
          
                Access ac = new Access();
                Products pd=new Products();
               // pd.productid=Convert.ToInt32(productidtext.Text);
                pd.name=nametext.Text;
                pd.price=Int32.Parse(pricetext.Text);
                pd.quantity=Int32.Parse(quantitytext.Text);
                pd.path = pathtext.Text;
                pd.type = typeBox1.Text;
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string newFileName = Guid.NewGuid() + Path.GetExtension(pd.path);

            dir = (dir.Substring(0, dir.LastIndexOf("\\") + 1) + "Data\\Products\\"+newFileName);
           
            System.IO.File.Copy(pd.path, dir, true);
            pd.path = newFileName;
            if (ac.addproduct(pd))
                {
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Nope");

            
            
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void typetext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
