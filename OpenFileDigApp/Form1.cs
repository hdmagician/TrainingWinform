using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDigApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = ""; // \:특수문자로 사용되는데 윈도우는 경로에 사용되서 에러뜸
            openFileDialog1.InitialDirectory = "C:\\";  //그래서 2개로. 아니면 @"C:\" << 요래
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt";
            openFileDialog1.ShowDialog();

            foreach (var item in openFileDialog1.FileNames)
            {
                textBox1.Text += item;
                textBox1.Text += Environment.NewLine; //이 환경에서 줄 바꿈 문자열을 가져옴
            }
        }
    }
}
