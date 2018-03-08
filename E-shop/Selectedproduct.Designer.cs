namespace E_shop
{
    partial class Selectedproduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.quantitytext = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addchart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rl = new System.Windows.Forms.RadioButton();
            this.rm = new System.Windows.Forms.RadioButton();
            this.spql = new System.Windows.Forms.Label();
            this.sps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(80, 48);
            this.idtext.Name = "idtext";
            this.idtext.ReadOnly = true;
            this.idtext.Size = new System.Drawing.Size(100, 20);
            this.idtext.TabIndex = 4;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(80, 101);
            this.nametext.Name = "nametext";
            this.nametext.ReadOnly = true;
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 5;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(80, 154);
            this.pricetext.Name = "pricetext";
            this.pricetext.ReadOnly = true;
            this.pricetext.Size = new System.Drawing.Size(100, 20);
            this.pricetext.TabIndex = 6;
            this.pricetext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // quantitytext
            // 
            this.quantitytext.Location = new System.Drawing.Point(80, 195);
            this.quantitytext.Name = "quantitytext";
            this.quantitytext.Size = new System.Drawing.Size(100, 20);
            this.quantitytext.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(210, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(212, 258);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // addchart
            // 
            this.addchart.Location = new System.Drawing.Point(75, 283);
            this.addchart.Name = "addchart";
            this.addchart.Size = new System.Drawing.Size(105, 34);
            this.addchart.TabIndex = 9;
            this.addchart.Text = "Add to chart";
            this.addchart.UseVisualStyleBackColor = true;
            this.addchart.Click += new System.EventHandler(this.addchart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rl
            // 
            this.rl.AutoSize = true;
            this.rl.Location = new System.Drawing.Point(136, 234);
            this.rl.Name = "rl";
            this.rl.Size = new System.Drawing.Size(31, 17);
            this.rl.TabIndex = 11;
            this.rl.Text = "L";
            this.rl.UseVisualStyleBackColor = true;
            // 
            // rm
            // 
            this.rm.AutoSize = true;
            this.rm.Checked = true;
            this.rm.Location = new System.Drawing.Point(93, 234);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(34, 17);
            this.rm.TabIndex = 12;
            this.rm.TabStop = true;
            this.rm.Text = "M";
            this.rm.UseVisualStyleBackColor = true;
            this.rm.CheckedChanged += new System.EventHandler(this.rm_CheckedChanged);
            // 
            // spql
            // 
            this.spql.AutoSize = true;
            this.spql.ForeColor = System.Drawing.Color.Red;
            this.spql.Location = new System.Drawing.Point(90, 218);
            this.spql.Name = "spql";
            this.spql.Size = new System.Drawing.Size(90, 13);
            this.spql.TabIndex = 13;
            this.spql.Text = "Specify Quantity!!";
            this.spql.Visible = false;
            // 
            // sps
            // 
            this.sps.AutoSize = true;
            this.sps.ForeColor = System.Drawing.Color.Red;
            this.sps.Location = new System.Drawing.Point(90, 254);
            this.sps.Name = "sps";
            this.sps.Size = new System.Drawing.Size(71, 13);
            this.sps.TabIndex = 14;
            this.sps.Text = "Specify Size!!";
            this.sps.Visible = false;
            // 
            // Selectedproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 329);
            this.Controls.Add(this.sps);
            this.Controls.Add(this.spql);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.rl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addchart);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.quantitytext);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Selectedproduct";
            this.Text = "Selectedproduct";
            this.Load += new System.EventHandler(this.Selectedproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox quantitytext;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button addchart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rl;
        private System.Windows.Forms.RadioButton rm;
        private System.Windows.Forms.Label spql;
        private System.Windows.Forms.Label sps;
    }
}