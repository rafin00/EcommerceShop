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
    public partial class Selectedproduct : Form
    {
        
        user us ;
        public Selectedproduct(string id, string name, int price, int quantity, byte[] img,user us)
        {

            InitializeComponent();
        this.us=us;
            idtext.Text = id;
            nametext.Text = name;
            pricetext.Text = price.ToString();
           // quantitytext.Text = quantity.ToString();
            //pictureBox.Image = img;
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
        }

     /* //  public Selectedproduct()
        {
            // TODO: Complete member initialization
            this.id = id;
            this.Name = name;
            this.price = price;
            this.quantity = quantity;


            this.img = img;
        }*/

        private void Selectedproduct_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addchart_Click(object sender, EventArgs e)
        {
           
                if (String.IsNullOrWhiteSpace(quantitytext.Text))
                {
                    spql.Visible = true;
                }
              
            else
            {
                spql.Visible = false;
                sps.Visible = false;
                if (login.logged)
                {
                    Access ac = new Access();
                    Products pd = new Products();
                    pd.productid = Convert.ToInt32(idtext.Text);
                    pd.price = Convert.ToInt32(pricetext.Text);
                    pd.quantity = Convert.ToInt32(quantitytext.Text);
                    pd.name = nametext.Text;


                    if (ac.addtochart(pd, us))
                    {
                        MessageBox.Show("Yes");
                    }
                    else
                        MessageBox.Show("NOPe");

                }
                else
                {
                    MessageBox.Show("Log in fst");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void rm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
