namespace E_shop
{
    partial class ShoppingChart
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
            this.scgdv = new System.Windows.Forms.DataGridView();
            this.cashoutb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totaltext = new System.Windows.Forms.TextBox();
            this.scinv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scgdv)).BeginInit();
            this.SuspendLayout();
            // 
            // scgdv
            // 
            this.scgdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scgdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scgdv.Location = new System.Drawing.Point(12, 32);
            this.scgdv.Name = "scgdv";
            this.scgdv.RowHeadersVisible = false;
            this.scgdv.Size = new System.Drawing.Size(316, 236);
            this.scgdv.TabIndex = 0;
            this.scgdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cashoutb
            // 
            this.cashoutb.Location = new System.Drawing.Point(51, 277);
            this.cashoutb.Name = "cashoutb";
            this.cashoutb.Size = new System.Drawing.Size(75, 23);
            this.cashoutb.TabIndex = 1;
            this.cashoutb.Text = "Cast Out";
            this.cashoutb.UseVisualStyleBackColor = true;
            this.cashoutb.Click += new System.EventHandler(this.cashoutb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // totaltext
            // 
            this.totaltext.Location = new System.Drawing.Point(228, 279);
            this.totaltext.Name = "totaltext";
            this.totaltext.ReadOnly = true;
            this.totaltext.Size = new System.Drawing.Size(100, 20);
            this.totaltext.TabIndex = 3;
            this.totaltext.TextChanged += new System.EventHandler(this.totaltext_TextChanged);
            // 
            // scinv
            // 
            this.scinv.AutoSize = true;
            this.scinv.ForeColor = System.Drawing.Color.Red;
            this.scinv.Location = new System.Drawing.Point(102, 9);
            this.scinv.Name = "scinv";
            this.scinv.Size = new System.Drawing.Size(128, 13);
            this.scinv.TabIndex = 4;
            this.scinv.Text = "Shopping Chart is Empty!!";
            this.scinv.Visible = false;
            // 
            // ShoppingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 312);
            this.Controls.Add(this.scinv);
            this.Controls.Add(this.totaltext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashoutb);
            this.Controls.Add(this.scgdv);
            this.Name = "ShoppingChart";
            this.Text = "ShoppingChart";
            this.Load += new System.EventHandler(this.ShoppingChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scgdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scgdv;
        private System.Windows.Forms.Button cashoutb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totaltext;
        private System.Windows.Forms.Label scinv;
    }
}