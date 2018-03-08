namespace E_shop
{
    partial class Nottaken
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
            this.ntdgv = new System.Windows.Forms.DataGridView();
            this.refresh1 = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ntdgv
            // 
            this.ntdgv.AllowUserToAddRows = false;
            this.ntdgv.AllowUserToDeleteRows = false;
            this.ntdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ntdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ntdgv.Location = new System.Drawing.Point(12, 12);
            this.ntdgv.Name = "ntdgv";
            this.ntdgv.RowHeadersVisible = false;
            this.ntdgv.Size = new System.Drawing.Size(293, 223);
            this.ntdgv.TabIndex = 0;
            // 
            // refresh1
            // 
            this.refresh1.Location = new System.Drawing.Point(12, 248);
            this.refresh1.Name = "refresh1";
            this.refresh1.Size = new System.Drawing.Size(75, 23);
            this.refresh1.TabIndex = 1;
            this.refresh1.Text = "Refresh";
            this.refresh1.UseVisualStyleBackColor = true;
            this.refresh1.Click += new System.EventHandler(this.refresh1_Click);
            // 
            // saveb
            // 
            this.saveb.Location = new System.Drawing.Point(230, 248);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(75, 23);
            this.saveb.TabIndex = 2;
            this.saveb.Text = "Save";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // Nottaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 283);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.refresh1);
            this.Controls.Add(this.ntdgv);
            this.Name = "Nottaken";
            this.Text = "Nottaken";
            this.Load += new System.EventHandler(this.Nottaken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ntdgv;
        private System.Windows.Forms.Button refresh1;
        private System.Windows.Forms.Button saveb;
    }
}