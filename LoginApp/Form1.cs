using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = $" ID : {textBox1.Text}  \r\n PASSWORD : {textBox2.Text}";

            if((textBox1.Text.ToUpper() == "ADMIN") 
                && (textBox2.Text.ToUpper() == "P@SSW0RD")) // 대소문자 상관없이 대문자로 비교를 한다.
            {
                MessageBox.Show("관리자 로그인!!");
            } 
        }
    }
}
