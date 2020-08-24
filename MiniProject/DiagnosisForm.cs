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
    public partial class DiagnosisForm : MetroForm
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            ChtGear.Series.Clear();
            Series sSin = ChtGear.Series.Add("인벌류트 함수");
            sSin.ChartType = SeriesChartType.PointAndFigure;
            for (double k = -360; k < 360; k += 0.01)
            {
                sSin.Points.AddXY(k, Math.Tan(k)+k*Math.PI/180);
            }
        }
    }
}
