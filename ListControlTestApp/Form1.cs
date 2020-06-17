using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListControlTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") // 글자가 있다면
            {
                listBox1.Items.Add(textBox1.Text); // 그 글자를 리스트 박스에 추가한다.
                comboBox1.Items.Add(textBox1.Text);// 콤보박스에 추가
            }
            textBox1.Text = ""; // 추가하고나서 빈칸만들기
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1) // 아무것도 선택안하면 -1. 첫번째 값이 0
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // 콤보박스도 동일
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
