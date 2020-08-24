namespace MiniProject
{
    partial class DiagnosisForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnDiagnosis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChtGear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChtGear)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDiagnosis
            // 
            this.BtnDiagnosis.Location = new System.Drawing.Point(537, 60);
            this.BtnDiagnosis.Name = "BtnDiagnosis";
            this.BtnDiagnosis.Size = new System.Drawing.Size(101, 26);
            this.BtnDiagnosis.TabIndex = 5;
            this.BtnDiagnosis.Text = "Diagnosis";
            this.BtnDiagnosis.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Browser";
            // 
            // ChtGear
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtGear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtGear.Legends.Add(legend1);
            this.ChtGear.Location = new System.Drawing.Point(23, 125);
            this.ChtGear.Name = "ChtGear";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtGear.Series.Add(series1);
            this.ChtGear.Size = new System.Drawing.Size(382, 363);
            this.ChtGear.TabIndex = 6;
            this.ChtGear.Text = "chart1";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.ChtGear);
            this.Controls.Add(this.BtnDiagnosis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChtGear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDiagnosis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtGear;
    }
}