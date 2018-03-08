namespace E_shop
{
    partial class Stafflist
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
            this.components = new System.ComponentModel.Container();
            this.staffdgv = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new E_shop.Database1DataSet();
            this.deliverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliverTableAdapter = new E_shop.Database1DataSetTableAdapters.DeliverTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffdgv
            // 
            this.staffdgv.AllowUserToAddRows = false;
            this.staffdgv.AllowUserToDeleteRows = false;
            this.staffdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffdgv.Location = new System.Drawing.Point(12, 69);
            this.staffdgv.Name = "staffdgv";
            this.staffdgv.ReadOnly = true;
            this.staffdgv.RowHeadersVisible = false;
            this.staffdgv.Size = new System.Drawing.Size(421, 221);
            this.staffdgv.TabIndex = 0;
            this.staffdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliverBindingSource
            // 
            this.deliverBindingSource.DataMember = "Deliver";
            this.deliverBindingSource.DataSource = this.database1DataSet;
            // 
            // deliverTableAdapter
            // 
            this.deliverTableAdapter.ClearBeforeFill = true;
            // 
            // Stafflist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 302);
            this.Controls.Add(this.staffdgv);
            this.Name = "Stafflist";
            this.Text = "Stafflist";
            this.Load += new System.EventHandler(this.Stafflist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView staffdgv;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource deliverBindingSource;
        private Database1DataSetTableAdapters.DeliverTableAdapter deliverTableAdapter;
    }
}