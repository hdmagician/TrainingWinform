using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void InitChileForm(Form form, string strFormTitle)
        {

            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            //form.MdiParent = this; // 여기까지 초기화
            form.Show(); // 실행
            form.WindowState = FormWindowState.Maximized;
        }

        private void 책관리BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivForm form = new DivForm();
            InitChileForm(form, "책 관리");
        }
    }
}
