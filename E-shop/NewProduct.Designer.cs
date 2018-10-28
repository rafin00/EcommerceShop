namespace E_shop
{
    partial class NewProduct
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
            this.name = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.imgpath = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.browse = new System.Windows.Forms.Button();
            this.nametext = new System.Windows.Forms.TextBox();
            this.quantitytext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.pathtext = new System.Windows.Forms.TextBox();
            this.saveb = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(12, 99);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "Quantity";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(12, 138);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            // 
            // imgpath
            // 
            this.imgpath.AutoSize = true;
            this.imgpath.Location = new System.Drawing.Point(7, 207);
            this.imgpath.Name = "imgpath";
            this.imgpath.Size = new System.Drawing.Size(58, 13);
            this.imgpath.TabIndex = 4;
            this.imgpath.Text = "ImagePath";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(209, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 135);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(239, 153);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 6;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(71, 61);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 8;
            // 
            // quantitytext
            // 
            this.quantitytext.Location = new System.Drawing.Point(71, 96);
            this.quantitytext.Name = "quantitytext";
            this.quantitytext.Size = new System.Drawing.Size(100, 20);
            this.quantitytext.TabIndex = 9;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(71, 135);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(100, 20);
            this.pricetext.TabIndex = 10;
            // 
            // pathtext
            // 
            this.pathtext.Location = new System.Drawing.Point(71, 204);
            this.pathtext.Name = "pathtext";
            this.pathtext.Size = new System.Drawing.Size(281, 20);
            this.pathtext.TabIndex = 11;
            // 
            // saveb
            // 
            this.saveb.Location = new System.Drawing.Point(59, 241);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(75, 23);
            this.saveb.TabIndex = 12;
            this.saveb.Text = "Save";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(209, 241);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type";
            // 
            // typeBox1
            // 
            this.typeBox1.FormattingEnabled = true;
            this.typeBox1.Items.AddRange(new object[] {
            "Men",
            "Women"});
            this.typeBox1.Location = new System.Drawing.Point(71, 170);
            this.typeBox1.Name = "typeBox1";
            this.typeBox1.Size = new System.Drawing.Size(121, 21);
            this.typeBox1.TabIndex = 16;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.typeBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.pathtext);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.quantitytext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.imgpath);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label imgpath;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox quantitytext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox pathtext;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox1;
    }
}