namespace E_shop
{
    partial class Trans
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
            this.trdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // trdgv
            // 
            this.trdgv.AllowUserToAddRows = false;
            this.trdgv.AllowUserToDeleteRows = false;
            this.trdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trdgv.Location = new System.Drawing.Point(12, 94);
            this.trdgv.Name = "trdgv";
            this.trdgv.ReadOnly = true;
            this.trdgv.RowHeadersVisible = false;
            this.trdgv.Size = new System.Drawing.Size(278, 169);
            this.trdgv.TabIndex = 0;
            // 
            // Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 275);
            this.Controls.Add(this.trdgv);
            this.Name = "Trans";
            this.Text = "Trans";
            this.Load += new System.EventHandler(this.Trans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trdgv;
    }
}