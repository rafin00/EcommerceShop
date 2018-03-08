namespace E_shop
{
    partial class StaffPanel
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
            this.spdgv = new System.Windows.Forms.DataGridView();
            this.userl = new System.Windows.Forms.Label();
            this.loadob = new System.Windows.Forms.Button();
            this.refreshb = new System.Windows.Forms.Button();
            this.takenorders = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.ts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // spdgv
            // 
            this.spdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spdgv.Location = new System.Drawing.Point(12, 103);
            this.spdgv.Name = "spdgv";
            this.spdgv.RowHeadersVisible = false;
            this.spdgv.Size = new System.Drawing.Size(375, 230);
            this.spdgv.TabIndex = 0;
            this.spdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apdgv_CellContentClick);
            // 
            // userl
            // 
            this.userl.AutoSize = true;
            this.userl.Location = new System.Drawing.Point(12, 9);
            this.userl.Name = "userl";
            this.userl.Size = new System.Drawing.Size(35, 13);
            this.userl.TabIndex = 2;
            this.userl.Text = "label1";
            // 
            // loadob
            // 
            this.loadob.Location = new System.Drawing.Point(312, 74);
            this.loadob.Name = "loadob";
            this.loadob.Size = new System.Drawing.Size(75, 23);
            this.loadob.TabIndex = 3;
            this.loadob.Text = "Load Orders";
            this.loadob.UseVisualStyleBackColor = true;
            this.loadob.Click += new System.EventHandler(this.saveb_Click);
            // 
            // refreshb
            // 
            this.refreshb.Location = new System.Drawing.Point(219, 74);
            this.refreshb.Name = "refreshb";
            this.refreshb.Size = new System.Drawing.Size(75, 23);
            this.refreshb.TabIndex = 4;
            this.refreshb.Text = "Refresh";
            this.refreshb.UseVisualStyleBackColor = true;
            this.refreshb.Click += new System.EventHandler(this.refreshb_Click);
            // 
            // takenorders
            // 
            this.takenorders.Location = new System.Drawing.Point(128, 74);
            this.takenorders.Name = "takenorders";
            this.takenorders.Size = new System.Drawing.Size(75, 23);
            this.takenorders.TabIndex = 5;
            this.takenorders.Text = "Taken Orders";
            this.takenorders.UseVisualStyleBackColor = true;
            this.takenorders.Click += new System.EventHandler(this.takenorders_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(34, 74);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(75, 23);
            this.history.TabIndex = 6;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // saveb
            // 
            this.saveb.Location = new System.Drawing.Point(312, 30);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(75, 23);
            this.saveb.TabIndex = 7;
            this.saveb.Text = "Save";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click_1);
            // 
            // ts
            // 
            this.ts.Location = new System.Drawing.Point(128, 30);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(75, 23);
            this.ts.TabIndex = 8;
            this.ts.Text = "Save";
            this.ts.UseVisualStyleBackColor = true;
            this.ts.Visible = false;
            this.ts.Click += new System.EventHandler(this.ts_Click);
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 345);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.history);
            this.Controls.Add(this.takenorders);
            this.Controls.Add(this.refreshb);
            this.Controls.Add(this.loadob);
            this.Controls.Add(this.userl);
            this.Controls.Add(this.spdgv);
            this.Name = "StaffPanel";
            this.Text = "StaffPanel";
            this.Load += new System.EventHandler(this.StaffPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spdgv;
        private System.Windows.Forms.Label userl;
        private System.Windows.Forms.Button loadob;
        private System.Windows.Forms.Button refreshb;
        private System.Windows.Forms.Button takenorders;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.Button ts;
    }
}