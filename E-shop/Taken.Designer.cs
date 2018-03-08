namespace E_shop
{
    partial class Taken
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
            this.tdgv = new System.Windows.Forms.DataGridView();
            this.refreshb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tdgv
            // 
            this.tdgv.AllowUserToAddRows = false;
            this.tdgv.AllowUserToDeleteRows = false;
            this.tdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdgv.Location = new System.Drawing.Point(12, 62);
            this.tdgv.Name = "tdgv";
            this.tdgv.RowHeadersVisible = false;
            this.tdgv.Size = new System.Drawing.Size(299, 239);
            this.tdgv.TabIndex = 0;
            this.tdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refreshb
            // 
            this.refreshb.Location = new System.Drawing.Point(236, 12);
            this.refreshb.Name = "refreshb";
            this.refreshb.Size = new System.Drawing.Size(75, 23);
            this.refreshb.TabIndex = 1;
            this.refreshb.Text = "Refresh";
            this.refreshb.UseVisualStyleBackColor = true;
            this.refreshb.Click += new System.EventHandler(this.refreshb_Click);
            // 
            // saveb
            // 
            this.saveb.Location = new System.Drawing.Point(12, 12);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(75, 23);
            this.saveb.TabIndex = 2;
            this.saveb.Text = "Save";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // Taken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 313);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.refreshb);
            this.Controls.Add(this.tdgv);
            this.Name = "Taken";
            this.Text = "Taken";
            this.Load += new System.EventHandler(this.Taken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tdgv;
        private System.Windows.Forms.Button refreshb;
        private System.Windows.Forms.Button saveb;
    }
}