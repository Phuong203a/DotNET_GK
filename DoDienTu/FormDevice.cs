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

namespace DoDienTu
{
    public partial class FormDevice : Form
    {
        DataModel dm;
        string imageUrl = null;
        public FormDevice()
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

        private void FormDevice_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void LoadDeviceData()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowDv();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["MaSP"];
                dgv1.Rows[index].Cells[1].Value = row["TenSP"];
                dgv1.Rows[index].Cells[2].Value = row["SoLuongTon"];
                dgv1.Rows[index].Cells[3].Value = row["DonGia"];
                dgv1.Rows[index].Cells[4].Value = row["MoTaSP"];
            }
        }

        private void InitializeForm()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtDevice.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
            txtInfo.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDevice.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
            txtInfo.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;

            txtDevice.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtInfo.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            if (!dm.AddNewRowDv(txtDevice.Text, txtQuantity.Text, txtPrice.Text, txtInfo.Text, arr))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadDeviceData();

            txtDevice.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
            txtInfo.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDeviceData();
            txtDevice.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
            txtInfo.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtDevice.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
            txtInfo.Enabled = false;
            btnUpload.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRowDv(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadDeviceData();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDevice.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantity.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtInfo.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();

            Byte[] data = new Byte[0];
            data = dm.loadImgDv(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
            MemoryStream ms = new MemoryStream(data);
            pbAva.Image = Image.FromStream(ms);
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtDevice.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
            txtInfo.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;
            txtDevice.Focus();
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            if (!dm.UpdateRowDv(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtDevice.Text, txtQuantity.Text, txtPrice.Text, txtInfo.Text, arr))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadDeviceData();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pbAva.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDevice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
