namespace RentalApp
{
    partial class RentalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdRentalTbl = new MetroFramework.Controls.MetroGrid();
            this.LblIdx = new System.Windows.Forms.Label();
            this.TxtIdx = new System.Windows.Forms.TextBox();
            this.LblMemberIdx = new System.Windows.Forms.Label();
            this.CboMemberIdx = new System.Windows.Forms.ComboBox();
            this.LblBookIdx = new System.Windows.Forms.Label();
            this.CboBookIdx = new System.Windows.Forms.ComboBox();
            this.LblRentalDate = new System.Windows.Forms.Label();
            this.LblReturnDate = new System.Windows.Forms.Label();
            this.DtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdRentalTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.DtpReturnDate);
            this.splitContainer1.Panel2.Controls.Add(this.DtpRentDate);
            this.splitContainer1.Panel2.Controls.Add(this.CboBookIdx);
            this.splitContainer1.Panel2.Controls.Add(this.CboMemberIdx);
            this.splitContainer1.Panel2.Controls.Add(this.LblReturnDate);
            this.splitContainer1.Panel2.Controls.Add(this.LblRentalDate);
            this.splitContainer1.Panel2.Controls.Add(this.LblBookIdx);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdx);
            this.splitContainer1.Panel2.Controls.Add(this.LblMemberIdx);
            this.splitContainer1.Panel2.Controls.Add(this.LblIdx);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdRentalTbl
            // 
            this.GrdRentalTbl.AllowUserToAddRows = false;
            this.GrdRentalTbl.AllowUserToDeleteRows = false;
            this.GrdRentalTbl.AllowUserToResizeRows = false;
            this.GrdRentalTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdRentalTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdRentalTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GrdRentalTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdRentalTbl.DefaultCellStyle = dataGridViewCellStyle14;
            this.GrdRentalTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRentalTbl.EnableHeadersVisualStyles = false;
            this.GrdRentalTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdRentalTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdRentalTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdRentalTbl.Name = "GrdRentalTbl";
            this.GrdRentalTbl.ReadOnly = true;
            this.GrdRentalTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRentalTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GrdRentalTbl.RowHeadersWidth = 51;
            this.GrdRentalTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdRentalTbl.RowTemplate.Height = 27;
            this.GrdRentalTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRentalTbl.Size = new System.Drawing.Size(363, 370);
            this.GrdRentalTbl.TabIndex = 0;
            this.GrdRentalTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // LblIdx
            // 
            this.LblIdx.AutoSize = true;
            this.LblIdx.Location = new System.Drawing.Point(57, 48);
            this.LblIdx.Name = "LblIdx";
            this.LblIdx.Size = new System.Drawing.Size(67, 15);
            this.LblIdx.TabIndex = 0;
            this.LblIdx.Text = "대여번호";
            // 
            // TxtIdx
            // 
            this.TxtIdx.Location = new System.Drawing.Point(125, 45);
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.Size = new System.Drawing.Size(212, 25);
            this.TxtIdx.TabIndex = 0;
            // 
            // LblMemberIdx
            // 
            this.LblMemberIdx.AutoSize = true;
            this.LblMemberIdx.Location = new System.Drawing.Point(57, 88);
            this.LblMemberIdx.Name = "LblMemberIdx";
            this.LblMemberIdx.Size = new System.Drawing.Size(67, 15);
            this.LblMemberIdx.TabIndex = 0;
            this.LblMemberIdx.Text = "회원번호";
            // 
            // CboMemberIdx
            // 
            this.CboMemberIdx.FormattingEnabled = true;
            this.CboMemberIdx.Location = new System.Drawing.Point(125, 85);
            this.CboMemberIdx.Name = "CboMemberIdx";
            this.CboMemberIdx.Size = new System.Drawing.Size(212, 23);
            this.CboMemberIdx.TabIndex = 1;
            // 
            // LblBookIdx
            // 
            this.LblBookIdx.AutoSize = true;
            this.LblBookIdx.Location = new System.Drawing.Point(57, 126);
            this.LblBookIdx.Name = "LblBookIdx";
            this.LblBookIdx.Size = new System.Drawing.Size(52, 15);
            this.LblBookIdx.TabIndex = 0;
            this.LblBookIdx.Text = "책번호";
            // 
            // CboBookIdx
            // 
            this.CboBookIdx.FormattingEnabled = true;
            this.CboBookIdx.Location = new System.Drawing.Point(125, 123);
            this.CboBookIdx.Name = "CboBookIdx";
            this.CboBookIdx.Size = new System.Drawing.Size(212, 23);
            this.CboBookIdx.TabIndex = 2;
            // 
            // LblRentalDate
            // 
            this.LblRentalDate.AutoSize = true;
            this.LblRentalDate.Location = new System.Drawing.Point(57, 168);
            this.LblRentalDate.Name = "LblRentalDate";
            this.LblRentalDate.Size = new System.Drawing.Size(52, 15);
            this.LblRentalDate.TabIndex = 0;
            this.LblRentalDate.Text = "대여일";
            // 
            // LblReturnDate
            // 
            this.LblReturnDate.AutoSize = true;
            this.LblReturnDate.Location = new System.Drawing.Point(57, 208);
            this.LblReturnDate.Name = "LblReturnDate";
            this.LblReturnDate.Size = new System.Drawing.Size(52, 15);
            this.LblReturnDate.TabIndex = 0;
            this.LblReturnDate.Text = "반납일";
            // 
            // DtpRentDate
            // 
            this.DtpRentDate.Location = new System.Drawing.Point(125, 161);
            this.DtpRentDate.Name = "DtpRentDate";
            this.DtpRentDate.Size = new System.Drawing.Size(212, 25);
            this.DtpRentDate.TabIndex = 3;
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Location = new System.Drawing.Point(125, 201);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(212, 25);
            this.DtpReturnDate.TabIndex = 4;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(48, 262);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(88, 38);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "신 규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(157, 262);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 38);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "저 장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(264, 262);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 38);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "취 소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRentalTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdRentalTbl;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.DateTimePicker DtpRentDate;
        private System.Windows.Forms.ComboBox CboBookIdx;
        private System.Windows.Forms.ComboBox CboMemberIdx;
        private System.Windows.Forms.Label LblReturnDate;
        private System.Windows.Forms.Label LblRentalDate;
        private System.Windows.Forms.Label LblBookIdx;
        private System.Windows.Forms.TextBox TxtIdx;
        private System.Windows.Forms.Label LblMemberIdx;
        private System.Windows.Forms.Label LblIdx;
    }
}