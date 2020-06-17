using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) // tick안에서 반복문쓰면 난리남
        {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }

        private int index = 0;
    }
}
