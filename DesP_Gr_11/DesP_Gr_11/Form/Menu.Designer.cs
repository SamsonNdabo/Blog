namespace DesP_Gr_11
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbemployes = new System.Windows.Forms.DataGridView();
            this.pnusers = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tblclient = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmontantcre = new System.Windows.Forms.Label();
            this.txtmontantpai = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.credittb = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbemployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclient)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credittb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(1124, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(31, 35);
            this.panel6.TabIndex = 54;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbemployes);
            this.panel1.Controls.Add(this.pnusers);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tblclient);
            this.panel1.Location = new System.Drawing.Point(36, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 339);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(746, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 74);
            this.panel4.TabIndex = 64;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(742, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Liste Employes";
            // 
            // tbemployes
            // 
            this.tbemployes.AllowUserToAddRows = false;
            this.tbemployes.AllowUserToDeleteRows = false;
            this.tbemployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbemployes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbemployes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbemployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbemployes.Location = new System.Drawing.Point(554, 104);
            this.tbemployes.Name = "tbemployes";
            this.tbemployes.ReadOnly = true;
            this.tbemployes.Size = new System.Drawing.Size(536, 220);
            this.tbemployes.TabIndex = 62;
            // 
            // pnusers
            // 
            this.pnusers.BackColor = System.Drawing.Color.Transparent;
            this.pnusers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnusers.BackgroundImage")));
            this.pnusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnusers.Location = new System.Drawing.Point(197, 3);
            this.pnusers.Name = "pnusers";
            this.pnusers.Size = new System.Drawing.Size(75, 74);
            this.pnusers.TabIndex = 61;
            this.pnusers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnusers_MouseClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "Liste Client";
            // 
            // tblclient
            // 
            this.tblclient.AllowUserToAddRows = false;
            this.tblclient.AllowUserToDeleteRows = false;
            this.tblclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblclient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblclient.Location = new System.Drawing.Point(5, 104);
            this.tblclient.Name = "tblclient";
            this.tblclient.ReadOnly = true;
            this.tblclient.Size = new System.Drawing.Size(536, 220);
            this.tblclient.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.txtmontantcre);
            this.panel2.Controls.Add(this.txtmontantpai);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.credittb);
            this.panel2.Location = new System.Drawing.Point(36, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 261);
            this.panel2.TabIndex = 66;
            // 
            // txtmontantcre
            // 
            this.txtmontantcre.AutoSize = true;
            this.txtmontantcre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontantcre.ForeColor = System.Drawing.Color.Red;
            this.txtmontantcre.Location = new System.Drawing.Point(899, 165);
            this.txtmontantcre.Name = "txtmontantcre";
            this.txtmontantcre.Size = new System.Drawing.Size(24, 20);
            this.txtmontantcre.TabIndex = 71;
            this.txtmontantcre.Text = "Rs";
            // 
            // txtmontantpai
            // 
            this.txtmontantpai.AutoSize = true;
            this.txtmontantpai.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontantpai.ForeColor = System.Drawing.Color.Lime;
            this.txtmontantpai.Location = new System.Drawing.Point(703, 165);
            this.txtmontantpai.Name = "txtmontantpai";
            this.txtmontantpai.Size = new System.Drawing.Size(24, 20);
            this.txtmontantpai.TabIndex = 70;
            this.txtmontantpai.Text = "Rs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(903, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 107);
            this.panel3.TabIndex = 67;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(707, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 107);
            this.panel5.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Comptablite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Details Paiement";
            // 
            // credittb
            // 
            this.credittb.AllowUserToAddRows = false;
            this.credittb.AllowUserToDeleteRows = false;
            this.credittb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.credittb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.credittb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.credittb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.credittb.Location = new System.Drawing.Point(41, 43);
            this.credittb.Name = "credittb";
            this.credittb.ReadOnly = true;
            this.credittb.Size = new System.Drawing.Size(536, 198);
            this.credittb.TabIndex = 66;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1167, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbemployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credittb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tblclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnusers;
        private System.Windows.Forms.DataGridView tbemployes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView credittb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtmontantpai;
        private System.Windows.Forms.Label txtmontantcre;
        private System.Windows.Forms.Panel panel2;
    }
}