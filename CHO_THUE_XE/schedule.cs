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
                dgv1.Rows[index].Cells[0].Value = row["ID"];
                dgv1.Rows[index].Cells[1].Value = row["MaKH"];
                dgv1.Rows[index].Cells[2].Value = row["Sdt"];
                dgv1.Rows[index].Cells[3].Value = row["IdXe"];
                dgv1.Rows[index].Cells[4].Value = row["NgayThue"];
                dgv1.Rows[index].Cells[5].Value = row["NgayTra"];
                dgv1.Rows[index].Cells[4].Value = row["Status"];
                dgv1.Rows[index].Cells[5].Value = row["GhiChu"];
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
                dgv1.Rows[index].Cells[4].Value = row["Status"];
                dgv1.Rows[index].Cells[5].Value = row["GhiChu"];
            }
            ResetForm();
            LoadSupplierData();
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            textBox4.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker3.Enabled = true;
            textBox1.Enabled = true;
            textBox5.Enabled = true;
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
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            textBox4.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker3.Enabled = true;
            textBox1.Enabled = true;
            textBox5.Enabled = true;

            txtSup.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAdr.Text = String.Empty;
            textBox4.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            dateTimePicker3.Text= String.Empty;
            textBox1.Text = String.Empty;
            textBox5.Text = String.Empty;
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
            if (!dm.AddNewRowSu(txtSup.Text, txtPhone.Text, txtAdr.Text, textBox4.Text, dateTimePicker1.MaxDate, dateTimePicker3.MaxDate, textBox1.Text, textBox5.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadSupplierData();

            txtSup.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            textBox4.Enabled= false;
            dateTimePicker1.Enabled=false;
            dateTimePicker3.Enabled=false;
            textBox1.Enabled=false;
            textBox5.Enabled=false;
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtSup.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            textBox4.Enabled = true;
            dateTimePicker1.Enabled=true;
            dateTimePicker3.Enabled=true;
            textBox1.Enabled=true;
            textBox5.Enabled=true;
            txtSup.Focus();
            if (!dm.UpdateRowSu(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtSup.Text, txtPhone.Text, txtAdr.Text, textBox4.Text, dateTimePicker1.MaxDate, dateTimePicker3.MaxDate, textBox1.Text, textBox5.Text))
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
