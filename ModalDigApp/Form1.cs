﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDigApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form = new Form2(); 
            //form.ShowDialog();// 한번만 뜸
            //form.Show(); // 누를때마다 뜸

            MessageBox.Show("텍스트입니다", "제목", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
        }
    }
}
