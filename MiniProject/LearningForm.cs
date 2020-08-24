using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniProject
{
    public partial class LearningForm : MetroForm

    {
        public LearningForm()
        {
            InitializeComponent();
        }

        private void Learning_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form LearningForm in this.MdiChildren)
                {
                    LearningForm.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void LearningForm_Load(object sender, EventArgs e)
        {
            //ChtData.Series.Clear();
            //Series sSin = ChtData.Series.Add("sin");
            //sSin.ChartType = SeriesChartType.Line; // 그래프 모양을 선그래프로 바꿈
            //for (double k = 0; k < 2 * Math.PI ; k += 0.1)
            //{
            //    sSin.Points.AddXY(k, Math.Sin(k));
            //}
        }

        private void CboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblModeName.Text = CboMode.Text.ToString();
            if (CboMode.Text == "MAX DATA")
            {
                ChtData.Series.Clear();
                Series dataname = ChtData.Series.Add("Max");
                dataname.ChartType = SeriesChartType.Point;
                for (double d = 0; d < 30; d++)
                {
                    dataname.Points.AddXY(d, Math.Max(d, d * 3));
                }
            }
            else if (CboMode.Text == "MIN DATA")
            {
                ChtData.Series.Clear();
                Series dataname = ChtData.Series.Add("Min");
                dataname.ChartType = SeriesChartType.Point;
                for (double d = 0; d < 30; d++)
                {
                    dataname.Points.AddXY(d, Math.Min(d, d * 3));
                }
            }
            else if (CboMode.Text == "ROOT MEAN SQUARE DATA(제곱 평균 제곱근)")
            {
                ChtData.Series.Clear();
                Series dataname = ChtData.Series.Add("RMS");
                dataname.ChartType = SeriesChartType.Point;
                for (double d = 0; d < 30; d++)
                {
                    dataname.Points.AddXY(d, Math.Sqrt(Math.Abs(Math.Pow(d,d))));
                }
            }
            else if (CboMode.Text == "SKEWNESS DATA(비대칭도)")
            {
                ChtData.Series.Clear();
                Series dataname = ChtData.Series.Add("Skewness");
                dataname.ChartType = SeriesChartType.Point;
                for (double d = 0; d < 30; d++)
                {
                    dataname.Points.AddXY(d, Math.Acos(d));
                }
            }
            else if (CboMode.Text == "KURTOSIS DATA(첨도)")
            {

            }
        }

        private void GridShowData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
