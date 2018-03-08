namespace E_shop
{
    partial class profile
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
            this.namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.adresstext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.duebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(26, 51);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(172, 51);
            this.nametext.Name = "nametext";
            this.nametext.ReadOnly = true;
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 11;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(172, 154);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.ReadOnly = true;
            this.passwordtext.Size = new System.Drawing.Size(100, 20);
            this.passwordtext.TabIndex = 12;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(172, 128);
            this.phonetext.Name = "phonetext";
            this.phonetext.ReadOnly = true;
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 13;
            // 
            // adresstext
            // 
            this.adresstext.Location = new System.Drawing.Point(172, 102);
            this.adresstext.Name = "adresstext";
            this.adresstext.ReadOnly = true;
            this.adresstext.Size = new System.Drawing.Size(100, 20);
            this.adresstext.TabIndex = 14;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(172, 79);
            this.emailtext.Name = "emailtext";
            this.emailtext.ReadOnly = true;
            this.emailtext.Size = new System.Drawing.Size(100, 20);
            this.emailtext.TabIndex = 15;
            // 
            // duebox
            // 
            this.duebox.Location = new System.Drawing.Point(172, 184);
            this.duebox.Name = "duebox";
            this.duebox.ReadOnly = true;
            this.duebox.Size = new System.Drawing.Size(100, 20);
            this.duebox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Due:";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 216);
            this.Controls.Add(this.duebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.adresstext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namelabel);
            this.Name = "profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox adresstext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox duebox;
        private System.Windows.Forms.Label label1;
    }
}