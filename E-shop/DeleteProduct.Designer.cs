namespace E_shop
{
    partial class DeleteProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteb = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.quantitytext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.productidtext = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.Label();
            this.searchb = new System.Windows.Forms.Button();
            this.invnf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteb
            // 
            this.deleteb.Enabled = false;
            this.deleteb.Location = new System.Drawing.Point(108, 81);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(75, 23);
            this.deleteb.TabIndex = 45;
            this.deleteb.Text = "Delete";
            this.deleteb.UseVisualStyleBackColor = true;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(247, 81);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 59;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(89, 219);
            this.pricetext.Name = "pricetext";
            this.pricetext.ReadOnly = true;
            this.pricetext.Size = new System.Drawing.Size(100, 20);
            this.pricetext.TabIndex = 56;
            // 
            // quantitytext
            // 
            this.quantitytext.Location = new System.Drawing.Point(89, 180);
            this.quantitytext.Name = "quantitytext";
            this.quantitytext.ReadOnly = true;
            this.quantitytext.Size = new System.Drawing.Size(100, 20);
            this.quantitytext.TabIndex = 55;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(89, 145);
            this.nametext.Name = "nametext";
            this.nametext.ReadOnly = true;
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 54;
            // 
            // productidtext
            // 
            this.productidtext.Location = new System.Drawing.Point(108, 36);
            this.productidtext.Name = "productidtext";
            this.productidtext.Size = new System.Drawing.Size(100, 20);
            this.productidtext.TabIndex = 53;
            this.productidtext.TextChanged += new System.EventHandler(this.productidtext_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(234, 145);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 135);
            this.pictureBox.TabIndex = 51;
            this.pictureBox.TabStop = false;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(30, 222);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 49;
            this.price.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(30, 183);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 48;
            this.quantity.Text = "Quantity";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(30, 145);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 47;
            this.name.Text = "Name";
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(46, 39);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(56, 13);
            this.pid.TabIndex = 46;
            this.pid.Text = "Product Id";
            // 
            // searchb
            // 
            this.searchb.Location = new System.Drawing.Point(247, 34);
            this.searchb.Name = "searchb";
            this.searchb.Size = new System.Drawing.Size(75, 23);
            this.searchb.TabIndex = 60;
            this.searchb.Text = "Search";
            this.searchb.UseVisualStyleBackColor = true;
            this.searchb.Click += new System.EventHandler(this.searchb_Click);
            // 
            // invnf
            // 
            this.invnf.AutoSize = true;
            this.invnf.ForeColor = System.Drawing.Color.Red;
            this.invnf.Location = new System.Drawing.Point(165, 295);
            this.invnf.Name = "invnf";
            this.invnf.Size = new System.Drawing.Size(63, 13);
            this.invnf.TabIndex = 61;
            this.invnf.Text = "Not Found!!";
            this.invnf.Visible = false;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 317);
            this.Controls.Add(this.invnf);
            this.Controls.Add(this.searchb);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.quantitytext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.productidtext);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.deleteb);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox quantitytext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox productidtext;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.Button searchb;
        private System.Windows.Forms.Label invnf;
    }
}