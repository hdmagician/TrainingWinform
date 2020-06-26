using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DivForm : MetroForm
    {
        public DivForm()
        {
            InitializeComponent();
        }

        string mode = "";

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); // DB열기
                string strQuery = "SELECT r.idx AS '대여번호', m.Names AS '대여회원', " +
                                  "t.Names AS '장르', " +
		                          "b.Names AS '대여책제목', b.ISBN, " +
                                  "r.rentalDate AS '대여일' " +
                                  " FROM rentaltbl AS r " +
                                  "INNER JOIN membertbl AS m " +
                                  "    ON r.memberIdx = m.Idx " +
                                  "INNER JOIN bookstbl AS b " +
                                  "    ON r.bookIdx = b.Idx " +
                                  "INNER JOIN divtbl AS t " +
                                  "     ON b.division = t.division; ";
                // SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "rentaltbl";
            }
        }

        private void GrdDivTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtAuthor.Text = data.Cells[1].Value.ToString();
                TxtGenre.Text = data.Cells[2].Value.ToString();
                TxtNames.Text = data.Cells[3].Value.ToString();
                TxtISBN.Text = data.Cells[4].Value.ToString();
                //CboDate.SelectedIndex = CboDate.FindString(data.Cells[5].Value.ToString());
               // CboDate.DataSource = DateTime.Parse(data.Cells[5].Value.ToString());
                TxtDivision.ReadOnly = true;
                TxtDivision.BackColor = Color.Beige;

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();

            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveProcess();
            UpdateData();

            ClearTextControls();
        }

        

        private void ClearTextControls()
        {
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.ReadOnly = false;
            TxtDivision.BackColor = Color.White;
            TxtDivision.Focus();
        }
        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void TxtNames_Click(object sender, EventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    BtnSave_Click(sender, new EventArgs());
            //}
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCboMember();
        }

        private void UpdateCboMember()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT Names " +
                                  "FROM dbo.membertbl";
                CboMember.DataSource = cmd;
                CboMember.DisplayMember = "Names";
            }
        }
    }
    }



    
