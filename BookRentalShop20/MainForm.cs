using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this,"정말 종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void InitChileForm(Form form, string strFormTitle)
        {
            
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this; // 여기까지 초기화
            form.Show(); // 실행
            form.WindowState = FormWindowState.Maximized;// 얘가 마지막으로 와야함
        }

        private void 구분코드관리ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DivForm form = new DivForm();
            InitChileForm(form, "구분코드 관리");
            
        }

        private void 사용자관리UToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UserForm form = new UserForm();
            InitChileForm(form, "사용자 관리");
        }

        private void 회원관리MToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Memberform form = new Memberform();
            InitChileForm(form, "회원 관리");
        }

        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            LblUserID.Text = Commons.LOGINUSERID;
        }

        private void 책관리BToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BooksForm form = new BooksForm();
            InitChileForm(form, "책 관리");
        }
    }
}
