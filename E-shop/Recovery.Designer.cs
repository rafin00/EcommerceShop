namespace E_shop
{
    partial class Recovery
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
            this.emailtext = new System.Windows.Forms.TextBox();
            this.einv = new System.Windows.Forms.Label();
            this.srecovery = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter email";
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(110, 22);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(141, 20);
            this.emailtext.TabIndex = 1;
            this.emailtext.TextChanged += new System.EventHandler(this.emailtext_TextChanged);
            // 
            // einv
            // 
            this.einv.AutoSize = true;
            this.einv.ForeColor = System.Drawing.Color.Red;
            this.einv.Location = new System.Drawing.Point(257, 25);
            this.einv.Name = "einv";
            this.einv.Size = new System.Drawing.Size(69, 13);
            this.einv.TabIndex = 2;
            this.einv.Text = "Invalid Email!";
            this.einv.Visible = false;
            // 
            // srecovery
            // 
            this.srecovery.Location = new System.Drawing.Point(110, 66);
            this.srecovery.Name = "srecovery";
            this.srecovery.Size = new System.Drawing.Size(97, 23);
            this.srecovery.TabIndex = 3;
            this.srecovery.Text = "Send Recovery";
            this.srecovery.UseVisualStyleBackColor = true;
            this.srecovery.Click += new System.EventHandler(this.srecovery_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(229, 66);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 128);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.srecovery);
            this.Controls.Add(this.einv);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.label1);
            this.Name = "Recovery";
            this.Text = "Recovery";
            this.Load += new System.EventHandler(this.Recovery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label einv;
        private System.Windows.Forms.Button srecovery;
        private System.Windows.Forms.Button cancel;
    }
}