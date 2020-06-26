using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        
        

        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 캔슬버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit(); // 종료하는 방법1. 한번씩 정확하게 해제가 안된다.
            Environment.Exit(0); // 종료하는 방법2. 0이 false값으로 오류없이 종료한다라는 뜻

        }

        /// <summary>
        /// 로그인 처리버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            loginProcess();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터. char없어도 된다.
            {
                Txtpassword.Focus();
            }
        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginProcess();
            }
        }

        private void loginProcess()
        {
            // throw new NotImplementedException(); //구현 안된 에러 처리
            if (String.IsNullOrEmpty(TxtUserID.Text) || String.IsNullOrEmpty(Txtpassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strUserID = string.Empty;

            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();                                      //close는 using 안썼을때 써주는거
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT userID FROM userTbl" +  // 여기에 셀렉트 구문을 넣는거임
                 " WHERE userID = @userID " +
                 "   AND password = @password ";

                SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmUserID.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmpassword = new SqlParameter("@password", SqlDbType.VarChar, 12);
                parmpassword.Value = Txtpassword.Text;
                cmd.Parameters.Add(parmpassword);       // 이렇게 복잡하게 안하고 commandtext에 값 다넣으면 해킹당함

               
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                strUserID = reader["userID"] != null ? reader["userID"].ToString() : "";

                if (strUserID != "")
                {
                    Commons.LOGINUSERID = strUserID; // 자식에서 부모로 데이터를 보내는 방법 중 하나
                    MetroMessageBox.Show(this, "접속성공", "로그인성공");
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "접속실패", "로그인 실패",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MetroMessageBox.Show(this, "접속성공", "로그인");
                Debug.WriteLine("On the Debug");
            }
        }
    }  
}
