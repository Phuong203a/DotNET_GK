using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHO_THUE_XE
{
    public partial class schedule : Form
    {
        DataModel dm;
        public schedule()
        {
            InitializeComponent();
            LoadDataModel();
            LoadSupplierData();
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


        private void LoadSupplierData()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowSu();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["ID"];
                dgv1.Rows[index].Cells[1].Value = row["MaKH"];
                dgv1.Rows[index].Cells[2].Value = row["Sdt"];
                dgv1.Rows[index].Cells[3].Value = row["IdXe"];
                dgv1.Rows[index].Cells[4].Value = row["NgayThue"];
                dgv1.Rows[index].Cells[5].Value = row["NgayTra"];
                dgv1.Rows[index].Cells[6].Value = row["Status"];
                dgv1.Rows[index].Cells[7].Value = row["GhiChu"];
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadSupplierData();
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtCustId.Enabled = true;
            txtIdCar.Enabled = true;
            dateNgayThue.Enabled = true;
            dateNgayTra.Enabled = true;
            txtGhiChu.Enabled = true;
            txtStatus.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!dm.AddNewRowSu(Int32.Parse(txtSup.Text), Int32.Parse(txtCustId.Text), txtPhone.Text, Int32.Parse(txtIdCar.Text), dateNgayThue.Value, dateNgayTra.Value, txtStatus.Text, txtGhiChu.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadSupplierData();

            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtCustId.Enabled = true;
            txtIdCar.Enabled = true;
            dateNgayThue.Enabled = true;
            dateNgayTra.Enabled = true;
            txtGhiChu.Enabled = true;
            txtStatus.Enabled = true;

            txtSup.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtCustId.Text = String.Empty;
            txtIdCar.Text = String.Empty;
            dateNgayThue.Text = String.Empty;
            dateNgayTra.Text= String.Empty;
            txtGhiChu.Text = String.Empty;
            txtStatus.Text = String.Empty;
        }

        private void txtSup_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRowSu(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadSupplierData();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            ResetForm();
            LoadSupplierData();

            txtSup.Enabled = false;
            txtPhone.Enabled = false;
            txtCustId.Enabled = false;
            txtIdCar.Enabled= false;
            dateNgayThue.Enabled=false;
            dateNgayTra.Enabled=false;
            txtGhiChu.Enabled=false;
            txtStatus.Enabled=false;
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtCustId.Enabled = true;
            txtIdCar.Enabled = true;
            dateNgayThue.Enabled=true;
            dateNgayTra.Enabled=true;
            txtGhiChu.Enabled=true;
            txtStatus.Enabled=true;
            txtSup.Focus();
            if (!dm.UpdateRowSu(Int32.Parse( dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString())
                , txtSup.Text, txtPhone.Text,
                txtCustId.Text, txtIdCar.Text,
                dateNgayThue.Value, dateNgayTra.Value, 
                txtGhiChu.Text, txtStatus.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadSupplierData();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdr_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
