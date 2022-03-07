namespace ReantalApp
{
    partial class frmIncome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncome));
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncome.ColumnHeadersHeight = 30;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.DataGridViewTextBoxColumn1,
            this.Column8,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncome.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncome.EnableHeadersVisualStyles = false;
            this.dgvIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.dgvIncome.Location = new System.Drawing.Point(0, 35);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersVisible = false;
            this.dgvIncome.RowTemplate.Height = 24;
            this.dgvIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncome.Size = new System.Drawing.Size(1289, 585);
            this.dgvIncome.TabIndex = 29;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "TRANS NO";
            this.Column9.Name = "Column9";
            this.Column9.Width = 84;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn1.HeaderText = "CLIENT NAME";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "TOTAL";
            this.Column8.Name = "Column8";
            this.Column8.Width = 62;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "DATE";
            this.Column10.Name = "Column10";
            this.Column10.Width = 56;
            // 
            // dt2
            // 
            this.dt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(953, 6);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(126, 23);
            this.dt2.TabIndex = 27;
            // 
            // dt1
            // 
            this.dt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(821, 6);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(126, 23);
            this.dt1.TabIndex = 26;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.btnGenerate);
            this.Panel2.Controls.Add(this.btnClose);
            this.Panel2.Controls.Add(this.dt2);
            this.Panel2.Controls.Add(this.dt1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Font = new System.Drawing.Font("Calibri", 9.7F);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1289, 35);
            this.Panel2.TabIndex = 27;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label3.Location = new System.Drawing.Point(4, 11);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 15);
            this.Label3.TabIndex = 83;
            this.Label3.Text = "INCOME";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 9.7F);
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(1084, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 35);
            this.btnGenerate.TabIndex = 82;
            this.btnGenerate.Text = " GENERATE DATA";
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.7F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1213, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " CLOSE";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel3.Controls.Add(this.lblCount);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel3.Location = new System.Drawing.Point(0, 620);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1289, 35);
            this.Panel3.TabIndex = 28;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 9.72F, System.Drawing.FontStyle.Italic);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCount.Location = new System.Drawing.Point(6, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(110, 15);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "(0) RECORD COUNT";
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 655);
            this.ControlBox = false;
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmIncome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvIncome;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        internal System.Windows.Forms.DateTimePicker dt2;
        internal System.Windows.Forms.DateTimePicker dt1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label lblCount;
    }
}