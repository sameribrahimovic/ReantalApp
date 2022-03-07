namespace ReantalApp
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.pnlLeft.Controls.Add(this.pnlLeftMenu);
            this.pnlLeft.Controls.Add(this.pnlBottom);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 703);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.Controls.Add(this.btnLogs);
            this.pnlLeftMenu.Controls.Add(this.btnIncome);
            this.pnlLeftMenu.Controls.Add(this.btnBrand);
            this.pnlLeftMenu.Controls.Add(this.btnCar);
            this.pnlLeftMenu.Controls.Add(this.btnClient);
            this.pnlLeftMenu.Controls.Add(this.btnReturn);
            this.pnlLeftMenu.Controls.Add(this.btnRental);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 186);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(200, 484);
            this.pnlLeftMenu.TabIndex = 2;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.Black;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(0, 200);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(200, 40);
            this.btnIncome.TabIndex = 28;
            this.btnIncome.Text = "    INCOME";
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.Transparent;
            this.btnBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.ForeColor = System.Drawing.Color.Black;
            this.btnBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.Image")));
            this.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.Location = new System.Drawing.Point(0, 160);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBrand.Size = new System.Drawing.Size(200, 40);
            this.btnBrand.TabIndex = 27;
            this.btnBrand.Text = "    CAR BRAND";
            this.btnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.Color.Black;
            this.btnCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCar.Image")));
            this.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.Location = new System.Drawing.Point(0, 120);
            this.btnCar.Name = "btnCar";
            this.btnCar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCar.Size = new System.Drawing.Size(200, 40);
            this.btnCar.TabIndex = 24;
            this.btnCar.Text = "    CAR";
            this.btnCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Black;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 80);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(200, 40);
            this.btnClient.TabIndex = 23;
            this.btnClient.Text = "    CLIENT";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(0, 40);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(200, 40);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "    RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.Transparent;
            this.btnRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRental.FlatAppearance.BorderSize = 0;
            this.btnRental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.ForeColor = System.Drawing.Color.Black;
            this.btnRental.Image = ((System.Drawing.Image)(resources.GetObject("btnRental.Image")));
            this.btnRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRental.Location = new System.Drawing.Point(0, 0);
            this.btnRental.Name = "btnRental";
            this.btnRental.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRental.Size = new System.Drawing.Size(200, 40);
            this.btnRental.TabIndex = 21;
            this.btnRental.Text = "    RENTAL";
            this.btnRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnLogout);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 670);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(200, 33);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "    LOGOUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.pictureBox1);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(200, 186);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ReantalApp.Properties.Resources.rent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1252, 703);
            this.mainPanel.TabIndex = 1;
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.Black;
            this.btnLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnLogs.Image")));
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(0, 240);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogs.Size = new System.Drawing.Size(200, 40);
            this.btnLogs.TabIndex = 29;
            this.btnLogs.Text = "    LOGS";
            this.btnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 703);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pnlLeft);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnBrand;
        internal System.Windows.Forms.Button btnCar;
        internal System.Windows.Forms.Button btnClient;
        internal System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.Button btnRental;
        internal System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Button btnIncome;
        public System.Windows.Forms.Button btnLogs;
    }
}