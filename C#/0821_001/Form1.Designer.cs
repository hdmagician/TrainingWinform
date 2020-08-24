namespace _0821_001
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.lbRand1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRand2 = new System.Windows.Forms.Label();
            this.lbRand3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInput3 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbBall = new System.Windows.Forms.Label();
            this.lbStrike = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "출력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(153, 38);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(15, 15);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "0";
            // 
            // tbInput1
            // 
            this.tbInput1.Location = new System.Drawing.Point(156, 130);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(69, 25);
            this.tbInput1.TabIndex = 2;
            // 
            // lbRand1
            // 
            this.lbRand1.AutoSize = true;
            this.lbRand1.Location = new System.Drawing.Point(176, 97);
            this.lbRand1.Name = "lbRand1";
            this.lbRand1.Size = new System.Drawing.Size(15, 15);
            this.lbRand1.TabIndex = 3;
            this.lbRand1.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "정답";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "카운트";
            // 
            // lbRand2
            // 
            this.lbRand2.AutoSize = true;
            this.lbRand2.Location = new System.Drawing.Point(284, 97);
            this.lbRand2.Name = "lbRand2";
            this.lbRand2.Size = new System.Drawing.Size(15, 15);
            this.lbRand2.TabIndex = 6;
            this.lbRand2.Text = "?";
            // 
            // lbRand3
            // 
            this.lbRand3.AutoSize = true;
            this.lbRand3.Location = new System.Drawing.Point(392, 97);
            this.lbRand3.Name = "lbRand3";
            this.lbRand3.Size = new System.Drawing.Size(15, 15);
            this.lbRand3.TabIndex = 7;
            this.lbRand3.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "입력";
            // 
            // tbInput3
            // 
            this.tbInput3.Location = new System.Drawing.Point(362, 130);
            this.tbInput3.Name = "tbInput3";
            this.tbInput3.Size = new System.Drawing.Size(69, 25);
            this.tbInput3.TabIndex = 9;
            // 
            // tbInput2
            // 
            this.tbInput2.Location = new System.Drawing.Point(259, 130);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(69, 25);
            this.tbInput2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "스트라이크";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "볼";
            // 
            // lbBall
            // 
            this.lbBall.AutoSize = true;
            this.lbBall.Location = new System.Drawing.Point(191, 297);
            this.lbBall.Name = "lbBall";
            this.lbBall.Size = new System.Drawing.Size(0, 15);
            this.lbBall.TabIndex = 14;
            // 
            // lbStrike
            // 
            this.lbStrike.AutoSize = true;
            this.lbStrike.Location = new System.Drawing.Point(191, 245);
            this.lbStrike.Name = "lbStrike";
            this.lbStrike.Size = new System.Drawing.Size(0, 15);
            this.lbStrike.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "다시시작";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbBall);
            this.Controls.Add(this.lbStrike);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbRand3);
            this.Controls.Add(this.lbRand2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRand1);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Label lbRand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRand2;
        private System.Windows.Forms.Label lbRand3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInput3;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBall;
        private System.Windows.Forms.Label lbStrike;
        private System.Windows.Forms.Button button2;
    }
}

