using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CHO_THUE_XE
{
    public partial class FormLogin : Form
    {
        DataModel dm;
        public FormLogin()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            string hashed = Util.SaltedHash(txtPass.Text);
            //MessageBox.Show(hashed+" "+ txtUser.Text);
            List<Dictionary<string, string>> rows = dm.FetchAllRowUr();
            foreach (Dictionary<string, string> row in rows)
            {
                if(row["TenDangNhap"] == txtUser.Text)
                {
                    if (row["MatKhau"] == hashed)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        if(row["PhanQuyen"] == "admin")
                        {
                            this.Hide();
                            FormHome fh = new FormHome();
                            fh.ShowDialog();                    
                            break;
                        }
                        else
                        {
                            this.Hide();
                            FormPurchase fp = new FormPurchase();
                            fp.ShowDialog();
                           
                            break;
                        }
                    }
                    else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
                }
                else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;

            }
        }

        private void btnForgorPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword fh = new FormForgotPassword();
            fh.ShowDialog();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
