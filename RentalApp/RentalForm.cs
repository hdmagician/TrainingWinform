using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RentalApp
{
    public partial class RentalForm : MetroForm
    {
        string mode = "";
        public RentalForm()
        {
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            UpdateCboBookIdx();
            UpdateCboMemberIdx();
            date();
        }

        

        private void UpdateCboMemberIdx()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " SELECT Idx, Names FROM membertbl ORDER BY Names ASC ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboMemberIdx.DataSource = new BindingSource(temps, null);
                CboMemberIdx.DisplayMember = "Value";
                CboMemberIdx.ValueMember = "Key";
                CboMemberIdx.SelectedIndex = -1;
            }
        }

        private void UpdateCboBookIdx()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names FROM bookstbl ORDER BY Names ASC ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboBookIdx.DataSource = new BindingSource(temps, null);
                CboBookIdx.DisplayMember = "Value";
                CboBookIdx.ValueMember = "Key";
                CboBookIdx.SelectedIndex = -1;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.Red;

                CboMemberIdx.SelectedIndex = CboMemberIdx.FindString(data.Cells[1].Value.ToString());
                CboBookIdx.SelectedIndex = CboBookIdx.FindString(data.Cells[2].Value.ToString());

                date();
                DtpRentDate.Value = DateTime.Parse(data.Cells[3].Value.ToString());
                if (data.Cells[4].Value.ToString() == "")
                {
                    DtpReturnDate.CustomFormat = " ";
                    DtpReturnDate.Format = DateTimePickerFormat.Custom;
                    date();
                }
                else
                {
                    DtpReturnDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());
                    date();
                }


                mode = "UPDATE"; // 수정은 UPDATE
            }
        }

        private void date()
        {
            DtpRentDate.CustomFormat = "yyyy-MM-dd";
            DtpRentDate.Format = DateTimePickerFormat.Custom;
            DtpReturnDate.CustomFormat = "yyyy-MM-dd";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void UpdateData()
        {

            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                string strQuery = "SELECT r.Idx, m.Names, b.Names, r.rentalDate, r.returnDate " +
                                  " FROM dbo.rentaltbl as r " +
                                  " INNER JOIN dbo.membertbl as m " +
                                  " ON r.memberIdx = m.Idx " +
                                  " INNER JOIN dbo.bookstbl as b " +
                                  " ON r.bookIdx = b.Idx ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl");

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = "rentaltbl";

            }


        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControl();
            mode = "INSERT";
        }

        private void ClearTextControl()
        {
            TxtIdx.Text = "";
            CboMemberIdx.SelectedIndex = -1;
            CboBookIdx.SelectedIndex = -1;

            DtpRentDate.CustomFormat = " ";
            DtpRentDate.Format = DateTimePickerFormat.Custom;
            DtpReturnDate.CustomFormat = " ";
            DtpReturnDate.Format = DateTimePickerFormat.Custom;

            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            CboMemberIdx.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboMemberIdx.SelectedIndex == -1 || CboBookIdx.SelectedIndex == -1) // 나머지 컨드롤도 검사해야함
            {
                MetroMessageBox.Show(this, "빈값을 지정할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            SaveProcess();
            UpdateData();
            ClearTextControl();
        }

        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = " UPDATE dbo.rentaltbl " +
                               " SET   memberIdx = @memberIdx, " +
                               "       bookIdx = @bookIdx, " +
                               "       rentalDate = @rentalDate, " +
                               "       returnDate = @returnDate " +
                               " WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = " INSERT INTO dbo.rentaltbl (memberIdx, bookIdx, rentalDate, returnDate) " +
                               " VALUES(@memberIdx, @bookIdx, @rentalDate, @returnDate) ";
                }
                cmd.CommandText = strQuery;

                // CboRNames 설정 
                SqlParameter paramRNames = new SqlParameter("@memberIdx", System.Data.SqlDbType.Int);
                paramRNames.Value = CboMemberIdx.SelectedValue;
                cmd.Parameters.Add(paramRNames);
                // CboBNames 설정 
                SqlParameter paramBNames = new SqlParameter("@bookIdx", System.Data.SqlDbType.Int);
                paramBNames.Value = CboBookIdx.SelectedValue;
                cmd.Parameters.Add(paramBNames);
                // DtpRentalDate 설정 
                SqlParameter paramrentalDate = new SqlParameter("@rentalDate", System.Data.SqlDbType.Date);
                paramrentalDate.Value = DtpRentDate.Value;
                cmd.Parameters.Add(paramrentalDate);
                // DtpReturnDate 설정 
                SqlParameter paramreturnDate = new SqlParameter("@returnDate", System.Data.SqlDbType.Date);
                paramreturnDate.Value = DtpReturnDate.Value;
                cmd.Parameters.Add(paramreturnDate);
                // TxtIdx 설정 
                if (mode == "UPDATE")
                {
                    SqlParameter paramIdx = new SqlParameter("@Idx", System.Data.SqlDbType.Int);
                    paramIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(paramIdx);
                }

                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearTextControl();
        }

        private void DtpRentDate_ValueChanged(object sender, EventArgs e)
        {
            date();
        }
        private void DtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            date();
        }


    }




}

