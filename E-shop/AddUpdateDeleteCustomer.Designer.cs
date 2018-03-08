namespace E_shop
{
    partial class AddUpdateDeleteCustomer
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
            this.invnf = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
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
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invnf
            // 
            this.invnf.AutoSize = true;
            this.invnf.ForeColor = System.Drawing.Color.Red;
            this.invnf.Location = new System.Drawing.Point(180, 295);
            this.invnf.Name = "invnf";
            this.invnf.Size = new System.Drawing.Size(63, 13);
            this.invnf.TabIndex = 43;
            this.invnf.Text = "Not Found!!";
            this.invnf.Visible = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(253, 139);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 42;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(253, 63);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 41;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(168, 269);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 40;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(253, 100);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 39;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(115, 243);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(100, 20);
            this.passwordtext.TabIndex = 38;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(115, 139);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 37;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(115, 102);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 36;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(115, 63);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(100, 20);
            this.usernametext.TabIndex = 35;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(53, 246);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(53, 13);
            this.price.TabIndex = 34;
            this.price.Text = "Password";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(56, 142);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(38, 13);
            this.quantity.TabIndex = 33;
            this.quantity.Text = "Phone";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(56, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 32;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(56, 66);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(55, 13);
            this.pid.TabIndex = 31;
            this.pid.Text = "Username";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(115, 174);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(100, 20);
            this.emailtext.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(115, 209);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(100, 20);
            this.addresstext.TabIndex = 47;
            this.addresstext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Address";
            // 
            // AddUpdateDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label1);
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
            this.Name = "AddUpdateDeleteCustomer";
            this.Text = "AddUpdateDeleteCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invnf;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
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
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.Label label2;
    }
}