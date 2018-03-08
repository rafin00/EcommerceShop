namespace E_shop
{
    partial class Staffmain
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
            this.history = new System.Windows.Forms.Button();
            this.taken = new System.Windows.Forms.Button();
            this.ordersb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(12, 60);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(75, 23);
            this.history.TabIndex = 0;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // taken
            // 
            this.taken.Location = new System.Drawing.Point(109, 60);
            this.taken.Name = "taken";
            this.taken.Size = new System.Drawing.Size(75, 23);
            this.taken.TabIndex = 1;
            this.taken.Text = "Taken";
            this.taken.UseVisualStyleBackColor = true;
            this.taken.Click += new System.EventHandler(this.taken_Click);
            // 
            // ordersb
            // 
            this.ordersb.Location = new System.Drawing.Point(197, 60);
            this.ordersb.Name = "ordersb";
            this.ordersb.Size = new System.Drawing.Size(75, 23);
            this.ordersb.TabIndex = 2;
            this.ordersb.Text = "Orders";
            this.ordersb.UseVisualStyleBackColor = true;
            this.ordersb.Click += new System.EventHandler(this.ordersb_Click);
            // 
            // Staffmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ordersb);
            this.Controls.Add(this.taken);
            this.Controls.Add(this.history);
            this.Name = "Staffmain";
            this.Text = "Staffmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button taken;
        private System.Windows.Forms.Button ordersb;
    }
}