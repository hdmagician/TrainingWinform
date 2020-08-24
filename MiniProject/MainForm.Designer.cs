namespace MiniProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLearning = new MetroFramework.Controls.MetroButton();
            this.BtnDiagnosis = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnLearning
            // 
            this.BtnLearning.Location = new System.Drawing.Point(12, 68);
            this.BtnLearning.Name = "BtnLearning";
            this.BtnLearning.Size = new System.Drawing.Size(391, 412);
            this.BtnLearning.TabIndex = 0;
            this.BtnLearning.Text = "Learning";
            this.BtnLearning.UseSelectable = true;
            this.BtnLearning.Click += new System.EventHandler(this.BtnLearning_Click);
            // 
            // BtnDiagnosis
            // 
            this.BtnDiagnosis.Location = new System.Drawing.Point(474, 68);
            this.BtnDiagnosis.Name = "BtnDiagnosis";
            this.BtnDiagnosis.Size = new System.Drawing.Size(369, 412);
            this.BtnDiagnosis.TabIndex = 0;
            this.BtnDiagnosis.Text = "Diagnosis";
            this.BtnDiagnosis.UseSelectable = true;
            this.BtnDiagnosis.Click += new System.EventHandler(this.BtnDiagnosis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 492);
            this.Controls.Add(this.BtnDiagnosis);
            this.Controls.Add(this.BtnLearning);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnLearning;
        private MetroFramework.Controls.MetroButton BtnDiagnosis;
    }
}

