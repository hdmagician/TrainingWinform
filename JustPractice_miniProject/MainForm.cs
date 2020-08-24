using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace JustPractice_miniProject
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitChileForm(Form form, string strFormTitle)
        {

            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            //form.MdiParent = this; // 여기까지 초기화
            form.Show(); // 실행
            form.WindowState = FormWindowState.Maximized;// 얘가 마지막으로 와야함
        }

        private void MnuProcess_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "진행상황 말씀이시군용~! 알겠어요!!", "확인",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProcessForm form = new ProcessForm();
            InitChileForm(form, "MnuProcess");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             MetroMessageBox.Show(this, "어서오세요 주인님!!" , "환영",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
