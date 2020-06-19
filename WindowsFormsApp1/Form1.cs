using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += 새파일NToolStripMenuItem.Text + Environment.NewLine;
        //    ToolStripComboBox1.Text = 새파일NToolStripMenuItem.Text;
        //    // 실제 새파일 로직 집어넣어야 함
        //}

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 열기OToolStripMenuItem.Text + Environment.NewLine;
            // 실제 열기 로직 집어넣어야함
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 저장SToolStripMenuItem.Text + Environment.NewLine;
            MessageBox.Show("저장했습니다.");
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    ToolStripComboBox1.Text = 새파일NToolStripMenuItem.Text;
        //}
    }
}

// if(e.Button == MouseButtons.Right){contextMenuStrip1.Show(e.Location)}
