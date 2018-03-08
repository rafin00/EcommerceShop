namespace E_shop
{
    partial class History1
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
            this.historyd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.historyd)).BeginInit();
            this.SuspendLayout();
            // 
            // historyd
            // 
            this.historyd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyd.Location = new System.Drawing.Point(0, 0);
            this.historyd.Name = "historyd";
            this.historyd.RowHeadersVisible = false;
            this.historyd.Size = new System.Drawing.Size(284, 261);
            this.historyd.TabIndex = 3;
            // 
            // History1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.historyd);
            this.Name = "History1";
            this.Text = "History1";
            this.Load += new System.EventHandler(this.History1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyd;
    }
}