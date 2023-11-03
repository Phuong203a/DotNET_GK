using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoDienTu
{
    public partial class FormForgotPassword : Form
    {
        private static Dictionary<string, string> otp;
        private static String currentEmail ="";
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text.Trim();
            DataModel dataModel = new DataModel();
            bool isExisted = dataModel.checkIfUserExist(email);
            if (!isExisted)
            {
                MessageBox.Show("Email không tồn tại.");
                return;
            }
            bool isExistednv = dataModel.checkIfNvExistInDangNhap(email);
            if (!isExistednv)
            {
                MessageBox.Show("Nhân viên chưa được đăng kí tài khoản.");
                return;
            }

            currentEmail = email;
            //hien thi ten user 

            MessageBox.Show("Tên người đăng nhập là:" +dataModel.getName(email));
           
            sendEmailCode(email);
        }
        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            String code = txtCode.Text.Trim();
            if (otp[currentEmail].Equals(code))
            {
                MessageBox.Show("Mã code hợp lệ");
                txtPassword.Enabled = true;
                txtRepassword.Enabled = true;
                btnChangePassword.Enabled = true;
        }
            else
            {
                MessageBox.Show("Mã code không hợp lệ");
            }
}
        private void sendEmailCode(String email)
        {
            try
            {


                ICredentialsByHost credentials = new NetworkCredential("hung.nt20@gmail.com", "hulkqxcgnczymbgr");
                SmtpClient smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = credentials
                };
                String code = generatedCode();
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hung.nt20@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Đổi mật khẩu";
                mail.Body = "Mã xác thực đổi mật khẩu cho bạn là: " + code;
                smtpClient.Send(mail);
                MessageBox.Show("Đã gửi mã xác nhận về email.");
                otp = new Dictionary<string, string>();
                otp[email] = code;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private String generatedCode()
        {
            Random random = new Random();
            string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                String password = txtPassword.Text;
                String rePassword = txtRepassword.Text;
                if (!password.Equals(rePassword))
                {
                    MessageBox.Show("Mật khẩu không trùng nhau");
                    return;
                }
                String hashPassword = Util.SaltedHash(rePassword);
                DataModel dataModel = new DataModel();
                int maNV = dataModel.getMaNhanVien(currentEmail);
                dataModel.updatePassword(maNV, hashPassword);
                MessageBox.Show("Đổi mật khẩu thành công");
                clearData();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void clearData()
        {
            otp = null;
            currentEmail = "";
            txtEmail.Text = "";
            txtCode.Text = "";
            txtPassword.Text = "";
            txtRepassword.Text = "";

            txtPassword.Enabled = false;
            txtRepassword.Enabled = false;
            btnChangePassword.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fh = new FormLogin();
                fh.ShowDialog();
                
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRepassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
