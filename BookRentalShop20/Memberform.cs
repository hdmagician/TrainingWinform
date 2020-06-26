﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class Memberform : MetroForm
    {
        
        
        string mode = "";
        public Memberform()
        {
            InitializeComponent();
        }


        private void UpdateData()
        {
            // throw new NotImplementedException();
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); // DB열기
                string strQuery = "SELECT Idx, Names, Levels, Addr, Mobile, Email " +
                                  "FROM dbo.membertbl";
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTbl.DataSource = ds;
                GrdMemberTbl.DataMember = "membertbl";
            }
        }

        

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();

            mode = "INSERT"; // 신규는 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtaddr.Text) || string.IsNullOrEmpty(TxtNames.Text)
                || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text))
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
            TxtIdx.Text = TxtNames.Text = Txtaddr.Text = TxtMobile.Text = TxtEmail.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true; // 신규눌렀을때 순번은 신경쓸필요 ㄴ
            TxtIdx.BackColor = Color.Beige; 
            TxtNames.Focus(); // 그래서 포커스를 이름란으로 가게끔
        }

        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Db저장프로세스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.membertbl " +  // 얘네들 파라미터 다 만들어야함
                               "SET Names = @Names " +
                               ", Levels = @Levels " +
                               ", Addr = @Addr " +
                               ", Mobile = @Mobile " +
                               ", Email = @Email" +
 "                             WHERE Idx = @Idx";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.membertbl " +
                               "(Names, Levels, Addr, Mobile, Email) " +
                               "VALUES(@Names, @Levels, @Addr, @Mobile, @Email) ";
                }
                cmd.CommandText = strQuery;

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45); // ssms보면서 하면됨.
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);
                SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                parmLevels.Value = CboLevels.SelectedItem;  //SelectedIndex하니까 에러 남. 
                cmd.Parameters.Add(parmLevels);

                SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                parmAddr.Value = Txtaddr.Text;
                cmd.Parameters.Add(parmAddr);

                SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                parmMobile.Value = Txtaddr.Text;
                cmd.Parameters.Add(parmMobile);
                SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                parmEmail.Value = TxtEmail.Text;
                cmd.Parameters.Add(parmEmail);
                SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                parmIdx.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmIdx);

                cmd.ExecuteNonQuery();
            }
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcess();
            UpdateData();
            ClearTextControls();
        }

        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void Memberform_Load_1(object sender, EventArgs e)
        {
            UpdateData(); // 데이터그리드 DB 데이터 로딩하기
        }

        private void GrdMemberTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.Beige;
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString()); // 콤보박스 사용시 일케
                Txtaddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        private void TxtIdx_Click(object sender, EventArgs e)
        {

        }
    }
}