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
                dgv1.Rows[index].Cells[0].Value = row["MaNCC"];
                dgv1.Rows[index].Cells[1].Value = row["TenNCC"];
                dgv1.Rows[index].Cells[2].Value = row["SoDT"];
                dgv1.Rows[index].Cells[3].Value = row["DiaChi"];
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowSu();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["MaNCC"];
                dgv1.Rows[index].Cells[1].Value = row["TenNCC"];
                dgv1.Rows[index].Cells[2].Value = row["SoDT"];
                dgv1.Rows[index].Cells[3].Value = row["DiaChi"];
            }
            ResetForm();
            LoadSupplierData();
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;
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

        private void txtPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;

            txtSup.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAdr.Text = String.Empty;
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
            if (!dm.AddNewRowSu(txtSup.Text, txtPhone.Text, txtAdr.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadSupplierData();

            txtSup.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;
            txtSup.Focus();
            if (!dm.UpdateRowSu(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtSup.Text, txtPhone.Text, txtAdr.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadSupplierData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtSup.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}
