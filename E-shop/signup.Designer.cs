namespace E_shop
{
    partial class signup
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
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.ninv = new System.Windows.Forms.Label();
            this.einv = new System.Windows.Forms.Label();
            this.pinv = new System.Windows.Forms.Label();
            this.ainv = new System.Windows.Forms.Label();
            this.pastext = new System.Windows.Forms.TextBox();
            this.cpastext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.cpassword = new System.Windows.Forms.Label();
            this.pasinv = new System.Windows.Forms.Label();
            this.cpasinv = new System.Windows.Forms.Label();
            this.dmatch = new System.Windows.Forms.Label();
            this.uinv = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.ll = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.uaeinv = new System.Windows.Forms.Label();
            this.eaeinv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(142, 310);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 0;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address*";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(142, 12);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(214, 20);
            this.nametext.TabIndex = 5;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(142, 97);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(214, 20);
            this.emailtext.TabIndex = 6;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(142, 146);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(214, 20);
            this.phonetext.TabIndex = 7;
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(142, 191);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(214, 20);
            this.addresstext.TabIndex = 8;
            // 
            // ninv
            // 
            this.ninv.AutoSize = true;
            this.ninv.ForeColor = System.Drawing.Color.Red;
            this.ninv.Location = new System.Drawing.Point(362, 15);
            this.ninv.Name = "ninv";
            this.ninv.Size = new System.Drawing.Size(67, 13);
            this.ninv.TabIndex = 9;
            this.ninv.Text = "Invalid value";
            this.ninv.Visible = false;
            // 
            // einv
            // 
            this.einv.AutoSize = true;
            this.einv.ForeColor = System.Drawing.Color.Red;
            this.einv.Location = new System.Drawing.Point(362, 100);
            this.einv.Name = "einv";
            this.einv.Size = new System.Drawing.Size(67, 13);
            this.einv.TabIndex = 10;
            this.einv.Text = "Invalid value";
            this.einv.Visible = false;
            // 
            // pinv
            // 
            this.pinv.AutoSize = true;
            this.pinv.ForeColor = System.Drawing.Color.Red;
            this.pinv.Location = new System.Drawing.Point(361, 149);
            this.pinv.Name = "pinv";
            this.pinv.Size = new System.Drawing.Size(67, 13);
            this.pinv.TabIndex = 11;
            this.pinv.Text = "Invalid value";
            this.pinv.Visible = false;
            // 
            // ainv
            // 
            this.ainv.AutoSize = true;
            this.ainv.ForeColor = System.Drawing.Color.Red;
            this.ainv.Location = new System.Drawing.Point(361, 194);
            this.ainv.Name = "ainv";
            this.ainv.Size = new System.Drawing.Size(67, 13);
            this.ainv.TabIndex = 12;
            this.ainv.Text = "Invalid value";
            this.ainv.Visible = false;
            // 
            // pastext
            // 
            this.pastext.Location = new System.Drawing.Point(142, 229);
            this.pastext.Name = "pastext";
            this.pastext.Size = new System.Drawing.Size(214, 20);
            this.pastext.TabIndex = 13;
            // 
            // cpastext
            // 
            this.cpastext.Location = new System.Drawing.Point(142, 266);
            this.cpastext.Name = "cpastext";
            this.cpastext.Size = new System.Drawing.Size(214, 20);
            this.cpastext.TabIndex = 14;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(48, 232);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 15;
            this.password.Text = "Password";
            // 
            // cpassword
            // 
            this.cpassword.AutoSize = true;
            this.cpassword.Location = new System.Drawing.Point(36, 269);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(91, 13);
            this.cpassword.TabIndex = 16;
            this.cpassword.Text = "Confirm Password";
            // 
            // pasinv
            // 
            this.pasinv.AutoSize = true;
            this.pasinv.ForeColor = System.Drawing.Color.Red;
            this.pasinv.Location = new System.Drawing.Point(362, 232);
            this.pasinv.Name = "pasinv";
            this.pasinv.Size = new System.Drawing.Size(67, 13);
            this.pasinv.TabIndex = 17;
            this.pasinv.Text = "Invalid value";
            this.pasinv.Visible = false;
            // 
            // cpasinv
            // 
            this.cpasinv.AutoSize = true;
            this.cpasinv.ForeColor = System.Drawing.Color.Red;
            this.cpasinv.Location = new System.Drawing.Point(362, 269);
            this.cpasinv.Name = "cpasinv";
            this.cpasinv.Size = new System.Drawing.Size(67, 13);
            this.cpasinv.TabIndex = 18;
            this.cpasinv.Text = "Invalid value";
            this.cpasinv.Visible = false;
            // 
            // dmatch
            // 
            this.dmatch.AutoSize = true;
            this.dmatch.ForeColor = System.Drawing.Color.Red;
            this.dmatch.Location = new System.Drawing.Point(362, 269);
            this.dmatch.Name = "dmatch";
            this.dmatch.Size = new System.Drawing.Size(79, 13);
            this.dmatch.TabIndex = 19;
            this.dmatch.Text = "Doesn\'t Match!";
            this.dmatch.Visible = false;
            // 
            // uinv
            // 
            this.uinv.AutoSize = true;
            this.uinv.ForeColor = System.Drawing.Color.Red;
            this.uinv.Location = new System.Drawing.Point(362, 55);
            this.uinv.Name = "uinv";
            this.uinv.Size = new System.Drawing.Size(67, 13);
            this.uinv.TabIndex = 22;
            this.uinv.Text = "Invalid value";
            this.uinv.Visible = false;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(142, 52);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(214, 20);
            this.usernametext.TabIndex = 21;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(52, 55);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(59, 13);
            this.ll.TabIndex = 20;
            this.ll.Text = "Username*";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(281, 310);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // uaeinv
            // 
            this.uaeinv.AutoSize = true;
            this.uaeinv.ForeColor = System.Drawing.Color.Red;
            this.uaeinv.Location = new System.Drawing.Point(362, 55);
            this.uaeinv.Name = "uaeinv";
            this.uaeinv.Size = new System.Drawing.Size(75, 13);
            this.uaeinv.TabIndex = 24;
            this.uaeinv.Text = "Already Exists!";
            this.uaeinv.Visible = false;
            // 
            // eaeinv
            // 
            this.eaeinv.AutoSize = true;
            this.eaeinv.ForeColor = System.Drawing.Color.Red;
            this.eaeinv.Location = new System.Drawing.Point(361, 100);
            this.eaeinv.Name = "eaeinv";
            this.eaeinv.Size = new System.Drawing.Size(75, 13);
            this.eaeinv.TabIndex = 25;
            this.eaeinv.Text = "Already Exists!";
            this.eaeinv.Visible = false;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.eaeinv);
            this.Controls.Add(this.uaeinv);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.uinv);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.dmatch);
            this.Controls.Add(this.cpasinv);
            this.Controls.Add(this.pasinv);
            this.Controls.Add(this.cpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cpastext);
            this.Controls.Add(this.pastext);
            this.Controls.Add(this.ainv);
            this.Controls.Add(this.pinv);
            this.Controls.Add(this.einv);
            this.Controls.Add(this.ninv);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Name = "signup";
            this.Text = "Sign-up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.signup_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.signup_FormClosed);
            this.Load += new System.EventHandler(this.signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.Label ninv;
        private System.Windows.Forms.Label einv;
        private System.Windows.Forms.Label pinv;
        private System.Windows.Forms.Label ainv;
        private System.Windows.Forms.TextBox pastext;
        private System.Windows.Forms.TextBox cpastext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label cpassword;
        private System.Windows.Forms.Label pasinv;
        private System.Windows.Forms.Label cpasinv;
        private System.Windows.Forms.Label dmatch;
        private System.Windows.Forms.Label uinv;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label uaeinv;
        private System.Windows.Forms.Label eaeinv;
    }
}