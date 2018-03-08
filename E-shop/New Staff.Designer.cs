namespace E_shop
{
    partial class New_Staff
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
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.Label();
            this.cpasswordtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(115, 141);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(100, 20);
            this.passwordtext.TabIndex = 18;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(115, 102);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 17;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(115, 67);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 16;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(115, 26);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(100, 20);
            this.usernametext.TabIndex = 15;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(12, 141);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(48, 13);
            this.price.TabIndex = 14;
            this.price.Text = "Pasword";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(12, 102);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(38, 13);
            this.quantity.TabIndex = 13;
            this.quantity.Text = "Phone";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 12;
            this.name.Text = "Name";
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(12, 26);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(55, 13);
            this.pid.TabIndex = 11;
            this.pid.Text = "Username";
            // 
            // cpasswordtext
            // 
            this.cpasswordtext.Location = new System.Drawing.Point(115, 179);
            this.cpasswordtext.Name = "cpasswordtext";
            this.cpasswordtext.Size = new System.Drawing.Size(100, 20);
            this.cpasswordtext.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Confirm Password";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(28, 226);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 21;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(140, 226);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // New_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cpasswordtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pid);
            this.Name = "New_Staff";
            this.Text = "New_Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.TextBox cpasswordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button cancel;
    }
}