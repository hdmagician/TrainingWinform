using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonTestApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            LbButtonStyle.Text = FlatStyle.Flat.ToString(); //Flat = 0 그래서 혼자 못씀. Text는 get,set필요
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            LbButtonStyle.Text = FlatStyle.Popup.ToString();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            LbButtonStyle.Text = FlatStyle.Standard.ToString();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            LbButtonStyle.Text = FlatStyle.System.ToString();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LbButtonStyle.Text = "결과표시";
        }
    }
}
