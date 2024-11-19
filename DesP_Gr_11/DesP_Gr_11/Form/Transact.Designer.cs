namespace DesP_Gr_11
{
    partial class Transact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transact));
            this.txtuser = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpai = new System.Windows.Forms.DataGridView();
            this.pnusers = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcredits = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbclient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.credittb = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcredits)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credittb)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtuser.Location = new System.Drawing.Point(803, 20);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(42, 21);
            this.txtuser.TabIndex = 147;
            this.txtuser.Text = "User";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(1124, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(31, 35);
            this.panel6.TabIndex = 148;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbpai);
            this.panel1.Controls.Add(this.pnusers);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbcredits);
            this.panel1.Location = new System.Drawing.Point(36, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 323);
            this.panel1.TabIndex = 149;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(787, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 74);
            this.panel2.TabIndex = 150;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "Liste Paiement";
            // 
            // tbpai
            // 
            this.tbpai.AllowUserToAddRows = false;
            this.tbpai.AllowUserToDeleteRows = false;
            this.tbpai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbpai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbpai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbpai.Location = new System.Drawing.Point(563, 113);
            this.tbpai.Name = "tbpai";
            this.tbpai.ReadOnly = true;
            this.tbpai.Size = new System.Drawing.Size(515, 198);
            this.tbpai.TabIndex = 148;
            // 
            // pnusers
            // 
            this.pnusers.BackColor = System.Drawing.Color.Transparent;
            this.pnusers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnusers.BackgroundImage")));
            this.pnusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnusers.Location = new System.Drawing.Point(229, 12);
            this.pnusers.Name = "pnusers";
            this.pnusers.Size = new System.Drawing.Size(75, 74);
            this.pnusers.TabIndex = 147;
            this.pnusers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnusers_MouseClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 146;
            this.label8.Text = "Liste credits";
            // 
            // tbcredits
            // 
            this.tbcredits.AllowUserToAddRows = false;
            this.tbcredits.AllowUserToDeleteRows = false;
            this.tbcredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbcredits.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbcredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbcredits.Location = new System.Drawing.Point(8, 113);
            this.tbcredits.Name = "tbcredits";
            this.tbcredits.ReadOnly = true;
            this.tbcredits.Size = new System.Drawing.Size(536, 198);
            this.tbcredits.TabIndex = 145;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tbclient);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.credittb);
            this.panel3.Location = new System.Drawing.Point(36, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 274);
            this.panel3.TabIndex = 150;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(355, 35);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(189, 22);
            this.txtsearch.TabIndex = 170;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(875, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 168;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(787, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 61);
            this.panel4.TabIndex = 165;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // tbclient
            // 
            this.tbclient.AllowUserToAddRows = false;
            this.tbclient.AllowUserToDeleteRows = false;
            this.tbclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbclient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbclient.Location = new System.Drawing.Point(557, 65);
            this.tbclient.Name = "tbclient";
            this.tbclient.ReadOnly = true;
            this.tbclient.Size = new System.Drawing.Size(524, 198);
            this.tbclient.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 148;
            this.label2.Text = "Details Credits";
            // 
            // credittb
            // 
            this.credittb.AllowUserToAddRows = false;
            this.credittb.AllowUserToDeleteRows = false;
            this.credittb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.credittb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.credittb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credittb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.credittb.Location = new System.Drawing.Point(12, 64);
            this.credittb.Name = "credittb";
            this.credittb.ReadOnly = true;
            this.credittb.Size = new System.Drawing.Size(536, 198);
            this.credittb.TabIndex = 147;
            // 
            // Transact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1167, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtuser);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Transact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbpai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcredits)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credittb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tbcredits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnusers;
        private System.Windows.Forms.DataGridView tbpai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView credittb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbclient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtsearch;
    }
}