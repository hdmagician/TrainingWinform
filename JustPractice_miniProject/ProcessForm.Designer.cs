namespace JustPractice_miniProject
{
    partial class ProcessForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblLife = new System.Windows.Forms.Label();
            this.TxtLife = new System.Windows.Forms.TextBox();
            this.LblExpectDate = new System.Windows.Forms.Label();
            this.LblHighpart = new System.Windows.Forms.Label();
            this.TxtHighpart = new System.Windows.Forms.TextBox();
            this.LblSafe = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblPart = new System.Windows.Forms.Label();
            this.CboPart = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtpExpectDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DtpExpectDate);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnOk);
            this.splitContainer1.Panel2.Controls.Add(this.CboPart);
            this.splitContainer1.Panel2.Controls.Add(this.LblPart);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.LblSafe);
            this.splitContainer1.Panel2.Controls.Add(this.TxtHighpart);
            this.splitContainer1.Panel2.Controls.Add(this.LblExpectDate);
            this.splitContainer1.Panel2.Controls.Add(this.LblHighpart);
            this.splitContainer1.Panel2.Controls.Add(this.TxtLife);
            this.splitContainer1.Panel2.Controls.Add(this.LblLife);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(362, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // LblLife
            // 
            this.LblLife.AutoSize = true;
            this.LblLife.Location = new System.Drawing.Point(45, 50);
            this.LblLife.Name = "LblLife";
            this.LblLife.Size = new System.Drawing.Size(67, 15);
            this.LblLife.TabIndex = 0;
            this.LblLife.Text = "기대수명";
            // 
            // TxtLife
            // 
            this.TxtLife.Location = new System.Drawing.Point(118, 47);
            this.TxtLife.Name = "TxtLife";
            this.TxtLife.Size = new System.Drawing.Size(237, 25);
            this.TxtLife.TabIndex = 0;
            // 
            // LblExpectDate
            // 
            this.LblExpectDate.AutoSize = true;
            this.LblExpectDate.Location = new System.Drawing.Point(15, 81);
            this.LblExpectDate.Name = "LblExpectDate";
            this.LblExpectDate.Size = new System.Drawing.Size(97, 15);
            this.LblExpectDate.TabIndex = 0;
            this.LblExpectDate.Text = "예상파괴시기";
            // 
            // LblHighpart
            // 
            this.LblHighpart.AutoSize = true;
            this.LblHighpart.Location = new System.Drawing.Point(25, 113);
            this.LblHighpart.Name = "LblHighpart";
            this.LblHighpart.Size = new System.Drawing.Size(87, 15);
            this.LblHighpart.TabIndex = 0;
            this.LblHighpart.Text = "고중량 파트";
            // 
            // TxtHighpart
            // 
            this.TxtHighpart.Location = new System.Drawing.Point(118, 110);
            this.TxtHighpart.Name = "TxtHighpart";
            this.TxtHighpart.Size = new System.Drawing.Size(237, 25);
            this.TxtHighpart.TabIndex = 2;
            // 
            // LblSafe
            // 
            this.LblSafe.AutoSize = true;
            this.LblSafe.Location = new System.Drawing.Point(60, 144);
            this.LblSafe.Name = "LblSafe";
            this.LblSafe.Size = new System.Drawing.Size(52, 15);
            this.LblSafe.TabIndex = 0;
            this.LblSafe.Text = "안전도";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 25);
            this.textBox4.TabIndex = 3;
            // 
            // LblPart
            // 
            this.LblPart.AutoSize = true;
            this.LblPart.Location = new System.Drawing.Point(67, 18);
            this.LblPart.Name = "LblPart";
            this.LblPart.Size = new System.Drawing.Size(37, 15);
            this.LblPart.TabIndex = 2;
            this.LblPart.Text = "파트";
            // 
            // CboPart
            // 
            this.CboPart.FormattingEnabled = true;
            this.CboPart.Location = new System.Drawing.Point(118, 15);
            this.CboPart.Name = "CboPart";
            this.CboPart.Size = new System.Drawing.Size(237, 23);
            this.CboPart.TabIndex = 3;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(30, 194);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(136, 46);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(219, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(136, 46);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // DtpExpectDate
            // 
            this.DtpExpectDate.Location = new System.Drawing.Point(119, 79);
            this.DtpExpectDate.Name = "DtpExpectDate";
            this.DtpExpectDate.Size = new System.Drawing.Size(236, 25);
            this.DtpExpectDate.TabIndex = 1;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DtpExpectDate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.ComboBox CboPart;
        private System.Windows.Forms.Label LblPart;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblSafe;
        private System.Windows.Forms.TextBox TxtHighpart;
        private System.Windows.Forms.Label LblExpectDate;
        private System.Windows.Forms.Label LblHighpart;
        private System.Windows.Forms.TextBox TxtLife;
        private System.Windows.Forms.Label LblLife;
    }
}