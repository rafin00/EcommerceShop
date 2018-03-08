namespace E_shop
{
    partial class login
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
            this.usernametext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.fplabel = new System.Windows.Forms.LinkLabel();
            this.invuser = new System.Windows.Forms.Label();
            this.invpass = new System.Windows.Forms.Label();
            this.invup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(67, 90);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(184, 20);
            this.passwordtext.TabIndex = 11;
            this.passwordtext.Text = "admin";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(67, 38);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(184, 20);
            this.usernametext.TabIndex = 10;
            this.usernametext.Text = "A-admin";
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(8, 93);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 9;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(6, 38);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 8;
            this.username.Text = "Username";
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(67, 158);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 7;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(176, 158);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 12;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // fplabel
            // 
            this.fplabel.AutoSize = true;
            this.fplabel.Location = new System.Drawing.Point(244, 239);
            this.fplabel.Name = "fplabel";
            this.fplabel.Size = new System.Drawing.Size(92, 13);
            this.fplabel.TabIndex = 13;
            this.fplabel.TabStop = true;
            this.fplabel.Text = "Forgot Password?";
            this.fplabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fplabel_LinkClicked);
            // 
            // invuser
            // 
            this.invuser.AutoSize = true;
            this.invuser.ForeColor = System.Drawing.Color.Red;
            this.invuser.Location = new System.Drawing.Point(257, 41);
            this.invuser.Name = "invuser";
            this.invuser.Size = new System.Drawing.Size(86, 13);
            this.invuser.TabIndex = 14;
            this.invuser.Text = "Enter Username!";
            this.invuser.Visible = false;
            // 
            // invpass
            // 
            this.invpass.AutoSize = true;
            this.invpass.ForeColor = System.Drawing.Color.Red;
            this.invpass.Location = new System.Drawing.Point(257, 93);
            this.invpass.Name = "invpass";
            this.invpass.Size = new System.Drawing.Size(84, 13);
            this.invpass.TabIndex = 15;
            this.invpass.Text = "Enter Password!";
            this.invpass.Visible = false;
            // 
            // invup
            // 
            this.invup.AutoSize = true;
            this.invup.ForeColor = System.Drawing.Color.Red;
            this.invup.Location = new System.Drawing.Point(88, 199);
            this.invup.Name = "invup";
            this.invup.Size = new System.Drawing.Size(144, 13);
            this.invup.TabIndex = 16;
            this.invup.Text = "Wrong Username/Password!";
            this.invup.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.invup);
            this.Controls.Add(this.invpass);
            this.Controls.Add(this.invuser);
            this.Controls.Add(this.fplabel);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.signin);
            this.Name = "login";
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.LinkLabel fplabel;
        private System.Windows.Forms.Label invuser;
        private System.Windows.Forms.Label invpass;
        private System.Windows.Forms.Label invup;
    }
}