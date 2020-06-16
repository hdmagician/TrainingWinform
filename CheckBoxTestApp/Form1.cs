using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void UpdateLavel()
        {
            string strchk1 = "", strchk2 = "", strchk3 = "", strchk4 = "";
            if (checkBox1.Checked) strchk1 = checkBox1.Text; // 체크가 됬으면 텍스트를 집어넣고
            else strchk1 = "";                               // 안됬으면 그 값을 지운다.

            if (checkBox2.Checked) strchk2 = checkBox2.Text; 
            else strchk2 = "";

            if (checkBox3.Checked) strchk3 = checkBox3.Text; 
            else strchk3 = "";

            if (checkBox4.Checked) strchk4 = checkBox4.Text;
            else strchk4 = "";

            label1.Text = strchk1 + " " + strchk2 + " " + strchk3 + " " + strchk4 + " ";
        }

        // private string strTemp = "";
        //private void UpdateLabel( bool b )
        //{
        //    if (b == true)
        //    {
        //        strTemp += s + " ";
        //        label1.Text = strTemp;
        //    }
        //    else
        //    {
        //        strTemp = label1.Text; // 라벨1에 있는 텍스트를 다 가져옴
        //        int i = strTemp.IndexOf(s.Substring(0, 1)); // 삭제하고자 하는 글자중 첫번째 글자를 찾음
        //        int j = i + s.Length; // 그 글자의 길이를 받고
        //        label1.Text = strTemp.Remove(i, j - i); //글자가 시작하는곳부터 길이만큼 지워버림
        //    }
        //}

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLavel();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLavel();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLavel();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLavel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "좋아하는 과일 :";
            
        } 
    }
}
