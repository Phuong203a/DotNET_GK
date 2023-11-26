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

namespace CHO_THUE_XE
{
    public partial class FormCarInformation : Form
    {
        DataModel dm;
        string imageUrl = null;
        public FormCarInformation()
        {
            InitializeComponent();
            LoadDataModel();
            pbAva.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadDataModel()
        {
            dm = new DataModel();
            LoadCarData();
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

        private void LoadCarData()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowDv(null,null,null);
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["Id"];
                dgv1.Rows[index].Cells[1].Value = row["Name"];
                dgv1.Rows[index].Cells[2].Value = row["Price"];
                dgv1.Rows[index].Cells[3].Value = row["Brand"];
                dgv1.Rows[index].Cells[4].Value = row["Type"];
                dgv1.Rows[index].Cells[5].Value = row["Model"];
            }
        }

        private void InitializeForm()
        {
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            if (!dm.AddNewRowCar(Int32.Parse(txtId.Text), txtName.Text, Int32.Parse(txtPrice.Text), txtBrand.Text, txtType.Text, txtModel.Text, arr))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadCarData();

            txtId.Enabled = true;
            txtBrand.Enabled = true;
            txtType.Enabled = true;
            txtName.Enabled = true;
            txtModel.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;

            txtId.Text = String.Empty;
            txtBrand.Text = String.Empty;
            txtType.Text = String.Empty;
            txtName.Text = String.Empty;
            txtModel.Text = String.Empty;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadCarData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRowDv(Int32.Parse(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Failed");
                    }
                    txtId.Text = String.Empty;
                    txtBrand.Text = String.Empty;
                    txtType.Text = String.Empty;
                    txtName.Text = String.Empty;
                    txtModel.Text = String.Empty;
                    ResetForm();
                    LoadCarData();

                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBrand.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtType.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtModel.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();

            Byte[] data = new Byte[0];
            data = dm.loadImgDv(Int32.Parse( dgv1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(data);
            pbAva.Image = Image.FromStream(ms);
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtBrand.Enabled = true;
            txtType.Enabled = true;
            txtModel.Enabled = true;
            btnUpload.Enabled = true;
            btnSave.Enabled = true;
            txtId.Focus();
            Image img = pbAva.Image;
            byte[] arr;
            ImageConverter convert = new ImageConverter();
            arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
            if (!dm.UpdateRowCar(Int32.Parse(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString()), txtName.Text, Int32.Parse(txtPrice.Text),
                txtBrand.Text, txtType.Text, txtModel.Text, arr))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadCarData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowDv(txtBrand.Text, txtType.Text, txtModel.Text);
            ResetForm();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["Id"];
                dgv1.Rows[index].Cells[1].Value = row["Name"];
                dgv1.Rows[index].Cells[2].Value = row["Brand"];
                dgv1.Rows[index].Cells[3].Value = row["Type"];
                dgv1.Rows[index].Cells[4].Value = row["Model"];
            }
        }
    }
}
