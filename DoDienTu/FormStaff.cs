using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;

namespace DoDienTu
{
    public partial class FormStaff : Form
    {
        DataModel dm;
        string imageUrl = null;
        public FormStaff()
        {
            InitializeComponent();
            LoadDataModel();
            pbAva.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        public void ResetForm()
        {
            dgv1.Rows.Clear();
            dm = new DataModel();
        }

        private void LoadStaffData()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRow();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["MaNV"];
                dgv1.Rows[index].Cells[1].Value = row["MaLoai"];
                dgv1.Rows[index].Cells[2].Value = row["TenNV"];
                dgv1.Rows[index].Cells[3].Value = row["NgayVaoLam"];
                dgv1.Rows[index].Cells[4].Value = row["SoDT"];
                dgv1.Rows[index].Cells[5].Value = row["CaLam"];
                dgv1.Rows[index].Cells[6].Value = row["ChiNhanhCongTac"];
                dgv1.Rows[index].Cells[7].Value = row["NgaySinh"];
                dgv1.Rows[index].Cells[8].Value = row["QueQuan"];
                dgv1.Rows[index].Cells[9].Value = row["Email"];
                dgv1.Rows[index].Cells[10].Value = row["TinhTrangNV"];
            }
        }

        private void InitializeForm()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtType.Enabled = false;
            txtStaff.Enabled = false;
            txtShift.Enabled = false;
            dtpFd.Enabled = false;
            dtpDob.Enabled = false;
            txtHt.Enabled = false;
            txtBranch.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtStatus.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtType.Enabled = true;
            txtStaff.Enabled = true;
            txtShift.Enabled = true;
            dtpFd.Enabled = true;
            dtpDob.Enabled = true;
            txtHt.Enabled = true;
            txtBranch.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtStatus.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static class test
        {
            public static int value; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                bool isExist = dm.checkIfUserExist(email);
                if (isExist)
                {
                    MessageBox.Show("Email đã tồn tại");
                    return;

                }
                if (!dm.AddNewRow(txtType.Text, txtStaff.Text, txtShift.Text, dtpFd.Value.ToString(), dtpDob.Value.ToString(), txtHt.Text, txtBranch.Text, txtPhone.Text, txtEmail.Text, txtStatus.Text, arr))
                {
                    MessageBox.Show("Failed");
                }
            }
            else
                MessageBox.Show("Email " + email + " là không hợp lệ");

            ResetForm();
            LoadStaffData();

            txtType.Enabled = false;
            txtStaff.Enabled = false;
            txtShift.Enabled = false;
            dtpFd.Enabled = false;
            dtpDob.Enabled = false;
            txtHt.Enabled = false;
            txtBranch.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtStatus.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void txtType_Click(object sender, EventArgs e)
        {
            txtType.DisplayMember = "Text";
            txtType.ValueMember = "Value";

            var items = new[] {
            new { Text = "100000", Value = "100000" },
            new { Text = "100001", Value = "100001" },
            new { Text = "100002", Value = "100002" },
            new { Text = "100003", Value = "100003" },
            };
            txtType.DataSource = items;
        }

        private void txtShift_Click(object sender, EventArgs e)
        {
            txtShift.DisplayMember = "Text";
            txtShift.ValueMember = "Value";

            var items = new[] {
            new { Text = "Ca 1", Value = "c1" },
            new { Text = "Ca 2", Value = "c2" },
            new { Text = "Ca 3", Value = "c3" },
            new { Text = "Ca 4", Value = "c4" },
            };
            txtShift.DataSource = items;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadStaffData();
            txtType.Enabled = true;
            txtStaff.Enabled = true;
            txtShift.Enabled = true;
            dtpFd.Enabled = true;
            dtpDob.Enabled = true;
            txtHt.Enabled = true;
            txtBranch.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtStatus.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtType.Enabled = false;
            txtStaff.Enabled = false;
            txtShift.Enabled = false;
            dtpFd.Enabled = false;
            dtpDob.Enabled = false;
            txtHt.Enabled = false;
            txtBranch.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtStatus.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRow(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadStaffData();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtType.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStaff.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFd.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtShift.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBranch.Text = dgv1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtpDob.Text = dgv1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtHt.Text = dgv1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEmail.Text = dgv1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtStatus.Text = dgv1.Rows[e.RowIndex].Cells[10].Value.ToString();

            Byte[] data = new Byte[0];
            data = dm.loadImg(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (data != null)
            {
                MemoryStream ms = new MemoryStream(data);
                pbAva.Image = Image.FromStream(ms);

            }
        ;
           
            
           
            txtType.Enabled = false;
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtStaff.Enabled = true;
            txtShift.Enabled = true;
            dtpFd.Enabled = true;
            dtpDob.Enabled = true;
            txtHt.Enabled = true;
            txtBranch.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtStatus.Enabled = true;
            btnSave.Enabled = true;
            btnUpload.Enabled = true;
            txtStaff.Focus();
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            string datePd = dtpFd.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string dob = dtpDob.Value.ToString("yyyy-MM-dd HH:mm:ss");
            if (match.Success)
            {
                bool isExist = dm.checkIfUserExist(email);
                if (isExist && !txtEmail.Text.Equals(email))
                {
                    MessageBox.Show("Email đã tồn tại");
                    return;

                }
                if (!dm.UpdateRow(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                    txtType.Text, txtStaff.Text, txtShift.Text, datePd, dob,
                    txtHt.Text, txtBranch.Text, txtPhone.Text, txtEmail.Text, txtStatus.Text, arr))
                {
                    MessageBox.Show("Failed");
                }
            }
            else
                MessageBox.Show("Email " + email + " là không hợp lệ");

            ResetForm();
            LoadStaffData();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pbAva.Image = Image.FromFile(ofd.FileName);
                }
            }
        }


        private void FormStaff_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
