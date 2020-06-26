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

namespace RentalApp
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

        private void 대여관리RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalForm form = new RentalForm();
            InitChileForm(form, "대여관리");
        }
    }
}
