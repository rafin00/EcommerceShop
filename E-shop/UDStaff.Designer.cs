namespace E_shop
{
    partial class UDStaff
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
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.invnf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(124, 195);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(209, 76);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 26;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(71, 150);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(100, 20);
            this.passwordtext.TabIndex = 24;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(71, 111);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 23;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(71, 76);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 22;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(74, 35);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(100, 20);
            this.usernametext.TabIndex = 21;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(12, 153);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(53, 13);
            this.price.TabIndex = 17;
            this.price.Text = "Password";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(12, 114);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(38, 13);
            this.quantity.TabIndex = 16;
            this.quantity.Text = "Phone";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 15;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(12, 38);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(55, 13);
            this.pid.TabIndex = 14;
            this.pid.Text = "Username";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(209, 35);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 28;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(209, 114);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 29;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // invnf
            // 
            this.invnf.AutoSize = true;
            this.invnf.ForeColor = System.Drawing.Color.Red;
            this.invnf.Location = new System.Drawing.Point(133, 222);
            this.invnf.Name = "invnf";
            this.invnf.Size = new System.Drawing.Size(63, 13);
            this.invnf.TabIndex = 30;
            this.invnf.Text = "Not Found!!";
            this.invnf.Visible = false;
            // 
            // UDStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 244);
            this.Controls.Add(this.invnf);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pid);
            this.Name = "UDStaff";
            this.Text = "UDStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label invnf;
    }
}