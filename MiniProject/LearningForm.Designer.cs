namespace MiniProject
{
    partial class LearningForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnInput = new System.Windows.Forms.Button();
            this.LblMode = new System.Windows.Forms.Label();
            this.CboMode = new MetroFramework.Controls.MetroComboBox();
            this.LblModeName = new System.Windows.Forms.Label();
            this.GridShowData = new MetroFramework.Controls.MetroGrid();
            this.ChtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GridShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browser";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 25);
            this.textBox1.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(537, 60);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(101, 26);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnInput
            // 
            this.BtnInput.BackColor = System.Drawing.Color.DarkRed;
            this.BtnInput.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnInput.Location = new System.Drawing.Point(16, 118);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(111, 37);
            this.BtnInput.TabIndex = 3;
            this.BtnInput.Text = "Input";
            this.BtnInput.UseVisualStyleBackColor = false;
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblMode.Location = new System.Drawing.Point(243, 126);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(56, 20);
            this.LblMode.TabIndex = 4;
            this.LblMode.Text = "Mode";
            // 
            // CboMode
            // 
            this.CboMode.FormattingEnabled = true;
            this.CboMode.ItemHeight = 24;
            this.CboMode.Items.AddRange(new object[] {
            "MAX DATA",
            "MIN DATA",
            "ROOT MEAN SQUARE DATA(제곱 평균 제곱근)",
            "SKEWNESS DATA(비대칭도)",
            "KURTOSIS DATA(첨도)",
            "WAVELET TRANSFORM DATA(웨이블릿 변환)"});
            this.CboMode.Location = new System.Drawing.Point(305, 118);
            this.CboMode.Name = "CboMode";
            this.CboMode.Size = new System.Drawing.Size(330, 30);
            this.CboMode.TabIndex = 6;
            this.CboMode.UseSelectable = true;
            this.CboMode.SelectedIndexChanged += new System.EventHandler(this.CboMode_SelectedIndexChanged);
            // 
            // LblModeName
            // 
            this.LblModeName.AutoSize = true;
            this.LblModeName.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblModeName.Location = new System.Drawing.Point(36, 171);
            this.LblModeName.Name = "LblModeName";
            this.LblModeName.Size = new System.Drawing.Size(167, 28);
            this.LblModeName.TabIndex = 8;
            this.LblModeName.Text = "데이터 이름";
            // 
            // GridShowData
            // 
            this.GridShowData.AllowUserToResizeRows = false;
            this.GridShowData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridShowData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridShowData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridShowData.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridShowData.EnableHeadersVisualStyles = false;
            this.GridShowData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridShowData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridShowData.Location = new System.Drawing.Point(16, 212);
            this.GridShowData.Name = "GridShowData";
            this.GridShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridShowData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridShowData.RowHeadersWidth = 51;
            this.GridShowData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridShowData.RowTemplate.Height = 27;
            this.GridShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridShowData.Size = new System.Drawing.Size(305, 365);
            this.GridShowData.TabIndex = 9;
            this.GridShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridShowData_CellContentClick);
            // 
            // ChtData
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtData.Legends.Add(legend1);
            this.ChtData.Location = new System.Drawing.Point(305, 212);
            this.ChtData.Name = "ChtData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtData.Series.Add(series1);
            this.ChtData.Size = new System.Drawing.Size(322, 365);
            this.ChtData.TabIndex = 10;
            this.ChtData.Text = "chart1";
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.ChtData);
            this.Controls.Add(this.GridShowData);
            this.Controls.Add(this.LblModeName);
            this.Controls.Add(this.CboMode);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "LearningForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Learning_FormClosing);
            this.Load += new System.EventHandler(this.LearningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Label LblMode;
        private MetroFramework.Controls.MetroComboBox CboMode;
        private System.Windows.Forms.Label LblModeName;
        private MetroFramework.Controls.MetroGrid GridShowData;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtData;
    }
}