using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0821_001
{
    public partial class Form1 : Form
    {
        int[] intArray;
        int score;
        public Form1()
        {
            InitializeComponent();
        }
        private void Init()
        {
            Random aRandom = new Random();
            int[] intArray = new int[3] { 100, 100, 100 };

            for (int Count = 0; Count < intArray.Length; ++Count)
            {
                int iTemp = aRandom.Next(0, 10);
                //MessageBox.Show("생성 : " + iTemp.ToString());

                int Count2;
                for (Count2 = 0; Count2 < intArray.Length; ++Count2)
                {
                    if (iTemp == intArray[Count2])
                    {
                       // MessageBox.Show("겹침 : " + iTemp.ToString());
                        break;
                    }
                }
                if (Count2 < intArray.Length)
                {
                    --Count;
                    continue;
                }
                intArray[Count] = iTemp;
            }

            lbRand1.Text = intArray[0].ToString();
            lbRand2.Text = intArray[1].ToString();
            lbRand3.Text = intArray[2].ToString();
            score = 0;
            lbCount.Text = score.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] inputArray = new int[intArray.Length];
            int strikeCount = 0;
            int ballCount = 0;

            inputArray[0] = Convert.ToInt32(tbInput1.Text);
            inputArray[1] = Convert.ToInt32(tbInput1.Text);
            inputArray[2] = Convert.ToInt32(tbInput1.Text);

            for (int Count1 = 0; Count1 < intArray.Length; Count1++)
            {
                for (int Count2 = 0; Count2 < intArray.Length; Count2++)
                {
                    if (inputArray[Count1] == intArray[Count2])
                    {
                        if (Count1 == Count2) // 위치비교
                        {
                            //MessageBox.Show("스트라이크");
                            ++strikeCount;
                        }
                        else
                        {
                            //MessageBox.Show("볼");
                            ++ballCount;
                        }
                        break;
                    }
                }
            }
            lbStrike.Text = strikeCount.ToString();
            lbBall.Text = ballCount.ToString();
            ++score;
            lbCount.Text = score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            lbStrike.Text = "0";
            lbBall.Text = "0";
            tbInput1.Clear();
            tbInput2.Clear();
            tbInput3.Clear();
        }
    }
}
