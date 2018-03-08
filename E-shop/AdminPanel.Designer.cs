namespace E_shop
{
    partial class AdminPanel
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
            this.newproductb = new System.Windows.Forms.Button();
            this.updateproductb = new System.Windows.Forms.Button();
            this.deleteproductb = new System.Windows.Forms.Button();
            this.newstaffb = new System.Windows.Forms.Button();
            this.udstaffb = new System.Windows.Forms.Button();
            this.stafflistb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.audb = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newproductb
            // 
            this.newproductb.Location = new System.Drawing.Point(12, 48);
            this.newproductb.Name = "newproductb";
            this.newproductb.Size = new System.Drawing.Size(75, 36);
            this.newproductb.TabIndex = 0;
            this.newproductb.Text = "New Product";
            this.newproductb.UseVisualStyleBackColor = true;
            this.newproductb.Click += new System.EventHandler(this.newproductb_Click);
            // 
            // updateproductb
            // 
            this.updateproductb.Location = new System.Drawing.Point(110, 48);
            this.updateproductb.Name = "updateproductb";
            this.updateproductb.Size = new System.Drawing.Size(75, 36);
            this.updateproductb.TabIndex = 1;
            this.updateproductb.Text = "Update Product";
            this.updateproductb.UseVisualStyleBackColor = true;
            this.updateproductb.Click += new System.EventHandler(this.updateproductb_Click);
            // 
            // deleteproductb
            // 
            this.deleteproductb.Location = new System.Drawing.Point(212, 48);
            this.deleteproductb.Name = "deleteproductb";
            this.deleteproductb.Size = new System.Drawing.Size(75, 36);
            this.deleteproductb.TabIndex = 2;
            this.deleteproductb.Text = "Delete Product";
            this.deleteproductb.UseVisualStyleBackColor = true;
            this.deleteproductb.Click += new System.EventHandler(this.deleteproductb_Click);
            // 
            // newstaffb
            // 
            this.newstaffb.Location = new System.Drawing.Point(12, 110);
            this.newstaffb.Name = "newstaffb";
            this.newstaffb.Size = new System.Drawing.Size(75, 39);
            this.newstaffb.TabIndex = 3;
            this.newstaffb.Text = "New Staff";
            this.newstaffb.UseVisualStyleBackColor = true;
            this.newstaffb.Click += new System.EventHandler(this.button4_Click);
            // 
            // udstaffb
            // 
            this.udstaffb.Location = new System.Drawing.Point(110, 110);
            this.udstaffb.Name = "udstaffb";
            this.udstaffb.Size = new System.Drawing.Size(75, 39);
            this.udstaffb.TabIndex = 4;
            this.udstaffb.Text = "Update/Delete Staff";
            this.udstaffb.UseVisualStyleBackColor = true;
            this.udstaffb.Click += new System.EventHandler(this.udstaffb_Click);
            // 
            // stafflistb
            // 
            this.stafflistb.Location = new System.Drawing.Point(212, 110);
            this.stafflistb.Name = "stafflistb";
            this.stafflistb.Size = new System.Drawing.Size(75, 39);
            this.stafflistb.TabIndex = 5;
            this.stafflistb.Text = "Staff List";
            this.stafflistb.UseVisualStyleBackColor = true;
            this.stafflistb.Click += new System.EventHandler(this.stafflistb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Customer List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // audb
            // 
            this.audb.Location = new System.Drawing.Point(12, 178);
            this.audb.Name = "audb";
            this.audb.Size = new System.Drawing.Size(110, 46);
            this.audb.TabIndex = 6;
            this.audb.Text = "Add/Update/Delete Customer";
            this.audb.UseVisualStyleBackColor = true;
            this.audb.Visible = false;
            this.audb.Click += new System.EventHandler(this.audb_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "Product List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 265);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.audb);
            this.Controls.Add(this.stafflistb);
            this.Controls.Add(this.udstaffb);
            this.Controls.Add(this.newstaffb);
            this.Controls.Add(this.deleteproductb);
            this.Controls.Add(this.updateproductb);
            this.Controls.Add(this.newproductb);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newproductb;
        private System.Windows.Forms.Button updateproductb;
        private System.Windows.Forms.Button deleteproductb;
        private System.Windows.Forms.Button newstaffb;
        private System.Windows.Forms.Button udstaffb;
        private System.Windows.Forms.Button stafflistb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button audb;
        private System.Windows.Forms.Button button4;
    }
}