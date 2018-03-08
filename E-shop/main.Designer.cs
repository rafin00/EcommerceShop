namespace E_shop
{
    partial class main
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
            this.loginb = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cagories = new System.Windows.Forms.Label();
            this.mensbutton = new System.Windows.Forms.Button();
            this.menpanel = new System.Windows.Forms.Panel();
            this.jeans = new System.Windows.Forms.LinkLabel();
            this.tshirt = new System.Windows.Forms.LinkLabel();
            this.watches = new System.Windows.Forms.LinkLabel();
            this.womenpanel = new System.Windows.Forms.Panel();
            this.wjeans = new System.Windows.Forms.LinkLabel();
            this.wtshirts = new System.Windows.Forms.LinkLabel();
            this.wwatches = new System.Windows.Forms.LinkLabel();
            this.women = new System.Windows.Forms.Button();
            this.uidgv = new System.Windows.Forms.DataGridView();
            this.userlink = new System.Windows.Forms.LinkLabel();
            this.shchl = new System.Windows.Forms.LinkLabel();
            this.refreshb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menpanel.SuspendLayout();
            this.womenpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uidgv)).BeginInit();
            this.SuspendLayout();
            // 
            // loginb
            // 
            this.loginb.Location = new System.Drawing.Point(808, 12);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(75, 23);
            this.loginb.TabIndex = 0;
            this.loginb.Text = "Login";
            this.loginb.UseVisualStyleBackColor = true;
            this.loginb.Click += new System.EventHandler(this.login_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cagories
            // 
            this.cagories.AutoSize = true;
            this.cagories.BackColor = System.Drawing.SystemColors.Control;
            this.cagories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cagories.Location = new System.Drawing.Point(2, 25);
            this.cagories.Name = "cagories";
            this.cagories.Size = new System.Drawing.Size(99, 24);
            this.cagories.TabIndex = 0;
            this.cagories.Text = "Catagories";
            this.cagories.Click += new System.EventHandler(this.cagories_Click);
            // 
            // mensbutton
            // 
            this.mensbutton.Location = new System.Drawing.Point(4, 3);
            this.mensbutton.Name = "mensbutton";
            this.mensbutton.Size = new System.Drawing.Size(95, 30);
            this.mensbutton.TabIndex = 1;
            this.mensbutton.Text = "Men         >";
            this.mensbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mensbutton.UseVisualStyleBackColor = true;
            this.mensbutton.MouseLeave += new System.EventHandler(this.mensbutton_MouseLeave);
            this.mensbutton.MouseHover += new System.EventHandler(this.mensbutton_MouseHover);
            // 
            // menpanel
            // 
            this.menpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menpanel.Controls.Add(this.jeans);
            this.menpanel.Controls.Add(this.tshirt);
            this.menpanel.Controls.Add(this.watches);
            this.menpanel.Controls.Add(this.mensbutton);
            this.menpanel.Location = new System.Drawing.Point(135, 12);
            this.menpanel.Name = "menpanel";
            this.menpanel.Size = new System.Drawing.Size(315, 37);
            this.menpanel.TabIndex = 3;
            this.menpanel.MouseEnter += new System.EventHandler(this.menpanel_MouseEnter);
            this.menpanel.MouseLeave += new System.EventHandler(this.menpanel_MouseLeave);
            this.menpanel.MouseHover += new System.EventHandler(this.menpanel_MouseHover);
            // 
            // jeans
            // 
            this.jeans.AutoSize = true;
            this.jeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeans.LinkColor = System.Drawing.Color.Black;
            this.jeans.Location = new System.Drawing.Point(173, 7);
            this.jeans.Name = "jeans";
            this.jeans.Size = new System.Drawing.Size(57, 20);
            this.jeans.TabIndex = 3;
            this.jeans.TabStop = true;
            this.jeans.Text = "Jeans";
            // 
            // tshirt
            // 
            this.tshirt.AutoSize = true;
            this.tshirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tshirt.LinkColor = System.Drawing.Color.Black;
            this.tshirt.Location = new System.Drawing.Point(105, 7);
            this.tshirt.Name = "tshirt";
            this.tshirt.Size = new System.Drawing.Size(69, 20);
            this.tshirt.TabIndex = 0;
            this.tshirt.TabStop = true;
            this.tshirt.Text = "T-shirts";
            this.tshirt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tshirt_MouseClick);
            this.tshirt.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // watches
            // 
            this.watches.AutoSize = true;
            this.watches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watches.LinkColor = System.Drawing.Color.Black;
            this.watches.Location = new System.Drawing.Point(233, 7);
            this.watches.Name = "watches";
            this.watches.Size = new System.Drawing.Size(79, 20);
            this.watches.TabIndex = 2;
            this.watches.TabStop = true;
            this.watches.Text = "Watches";
            this.watches.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.watches_LinkClicked);
            this.watches.MouseEnter += new System.EventHandler(this.watches_MouseEnter);
            this.watches.MouseHover += new System.EventHandler(this.watches_MouseHover);
            // 
            // womenpanel
            // 
            this.womenpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.womenpanel.Controls.Add(this.wjeans);
            this.womenpanel.Controls.Add(this.wtshirts);
            this.womenpanel.Controls.Add(this.wwatches);
            this.womenpanel.Controls.Add(this.women);
            this.womenpanel.Location = new System.Drawing.Point(487, 12);
            this.womenpanel.Name = "womenpanel";
            this.womenpanel.Size = new System.Drawing.Size(315, 37);
            this.womenpanel.TabIndex = 4;
            this.womenpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // wjeans
            // 
            this.wjeans.AutoSize = true;
            this.wjeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wjeans.LinkColor = System.Drawing.Color.Black;
            this.wjeans.Location = new System.Drawing.Point(173, 7);
            this.wjeans.Name = "wjeans";
            this.wjeans.Size = new System.Drawing.Size(57, 20);
            this.wjeans.TabIndex = 3;
            this.wjeans.TabStop = true;
            this.wjeans.Text = "Jeans";
            // 
            // wtshirts
            // 
            this.wtshirts.AutoSize = true;
            this.wtshirts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtshirts.LinkColor = System.Drawing.Color.Black;
            this.wtshirts.Location = new System.Drawing.Point(105, 7);
            this.wtshirts.Name = "wtshirts";
            this.wtshirts.Size = new System.Drawing.Size(69, 20);
            this.wtshirts.TabIndex = 0;
            this.wtshirts.TabStop = true;
            this.wtshirts.Text = "T-shirts";
            // 
            // wwatches
            // 
            this.wwatches.AutoSize = true;
            this.wwatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwatches.LinkColor = System.Drawing.Color.Black;
            this.wwatches.Location = new System.Drawing.Point(233, 7);
            this.wwatches.Name = "wwatches";
            this.wwatches.Size = new System.Drawing.Size(79, 20);
            this.wwatches.TabIndex = 2;
            this.wwatches.TabStop = true;
            this.wwatches.Text = "Watches";
            // 
            // women
            // 
            this.women.Location = new System.Drawing.Point(4, 3);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(95, 30);
            this.women.TabIndex = 1;
            this.women.Text = "Women         >";
            this.women.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.women.UseVisualStyleBackColor = true;
            // 
            // uidgv
            // 
            this.uidgv.AllowUserToAddRows = false;
            this.uidgv.AllowUserToDeleteRows = false;
            this.uidgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uidgv.Location = new System.Drawing.Point(6, 84);
            this.uidgv.Name = "uidgv";
            this.uidgv.ReadOnly = true;
            this.uidgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.uidgv.RowTemplate.Height = 100;
            this.uidgv.Size = new System.Drawing.Size(882, 336);
            this.uidgv.TabIndex = 0;
            this.uidgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uidgv_CellClick);
            this.uidgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userlink
            // 
            this.userlink.AutoSize = true;
            this.userlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlink.Location = new System.Drawing.Point(808, 12);
            this.userlink.Name = "userlink";
            this.userlink.Size = new System.Drawing.Size(80, 20);
            this.userlink.TabIndex = 6;
            this.userlink.TabStop = true;
            this.userlink.Text = "username";
            this.userlink.Visible = false;
            // 
            // shchl
            // 
            this.shchl.AutoSize = true;
            this.shchl.Location = new System.Drawing.Point(809, 39);
            this.shchl.Name = "shchl";
            this.shchl.Size = new System.Drawing.Size(80, 13);
            this.shchl.TabIndex = 4;
            this.shchl.TabStop = true;
            this.shchl.Text = "Shopping Chart";
            this.shchl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.shchl_LinkClicked);
            // 
            // refreshb
            // 
            this.refreshb.Location = new System.Drawing.Point(811, 441);
            this.refreshb.Name = "refreshb";
            this.refreshb.Size = new System.Drawing.Size(75, 23);
            this.refreshb.TabIndex = 7;
            this.refreshb.Text = "Refresh";
            this.refreshb.UseVisualStyleBackColor = true;
            this.refreshb.Click += new System.EventHandler(this.refreshb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(808, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(714, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshb);
            this.Controls.Add(this.shchl);
            this.Controls.Add(this.womenpanel);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.cagories);
            this.Controls.Add(this.menpanel);
            this.Controls.Add(this.uidgv);
            this.Controls.Add(this.userlink);
            this.Name = "main";
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.menpanel.ResumeLayout(false);
            this.menpanel.PerformLayout();
            this.womenpanel.ResumeLayout(false);
            this.womenpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uidgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel menpanel;
        private System.Windows.Forms.Button mensbutton;
        private System.Windows.Forms.Label cagories;
        private System.Windows.Forms.LinkLabel watches;
        private System.Windows.Forms.LinkLabel tshirt;
        private System.Windows.Forms.LinkLabel jeans;
        private System.Windows.Forms.Panel womenpanel;
        private System.Windows.Forms.LinkLabel wjeans;
        private System.Windows.Forms.LinkLabel wtshirts;
        private System.Windows.Forms.LinkLabel wwatches;
        private System.Windows.Forms.Button women;
        private System.Windows.Forms.DataGridView uidgv;
        private System.Windows.Forms.LinkLabel userlink;
        private System.Windows.Forms.LinkLabel shchl;
        private System.Windows.Forms.Button refreshb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}