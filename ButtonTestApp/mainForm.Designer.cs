namespace ButtonTestApp
{
    partial class mainForm
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
            this.btnFlat = new System.Windows.Forms.Button();
            this.btnPopup = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.LbButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlat
            // 
            this.btnFlat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.Font = new System.Drawing.Font("궁서", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFlat.Location = new System.Drawing.Point(73, 55);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(286, 133);
            this.btnFlat.TabIndex = 4;
            this.btnFlat.Text = "Flat";
            this.btnFlat.UseVisualStyleBackColor = false;
            this.btnFlat.Click += new System.EventHandler(this.btnFlat_Click);
            // 
            // btnPopup
            // 
            this.btnPopup.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopup.Font = new System.Drawing.Font("궁서", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPopup.Location = new System.Drawing.Point(424, 55);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(286, 133);
            this.btnPopup.TabIndex = 0;
            this.btnPopup.Text = "Popup";
            this.btnPopup.UseVisualStyleBackColor = false;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStandard.Font = new System.Drawing.Font("궁서", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStandard.Location = new System.Drawing.Point(73, 249);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(286, 133);
            this.btnStandard.TabIndex = 0;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = false;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSystem.Font = new System.Drawing.Font("궁서", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSystem.Location = new System.Drawing.Point(424, 249);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(286, 133);
            this.btnSystem.TabIndex = 0;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // LbButtonStyle
            // 
            this.LbButtonStyle.AutoSize = true;
            this.LbButtonStyle.Location = new System.Drawing.Point(13, 423);
            this.LbButtonStyle.Name = "LbButtonStyle";
            this.LbButtonStyle.Size = new System.Drawing.Size(45, 15);
            this.LbButtonStyle.TabIndex = 1;
            this.LbButtonStyle.Text = "label1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbButtonStyle);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.btnFlat);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Label LbButtonStyle;
    }
}

