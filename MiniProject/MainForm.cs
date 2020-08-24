using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
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

        private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            // form.MdiParent = this; 이게있으면 왜 오류나는지 모르겠음
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void BtnLearning_Click(object sender, EventArgs e)
        {
            LearningForm form = new LearningForm();
            InitChildForm(form, "Learning");
        }

        private void BtnDiagnosis_Click(object sender, EventArgs e)
        {
            DiagnosisForm form = new DiagnosisForm();
            InitChildForm(form, "Diagnosis");
        }
    }
}
