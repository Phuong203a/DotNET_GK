using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static iTextSharp.text.pdf.PRTokeniser;
using System.IO;

namespace CHO_THUE_XE
{
    public partial class FormCarRent : Form
    {
        DataModel dm;
        public FormCarRent()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();
            LoadCarRent();
        }

        public void ResetForm()
        {
            dgv1.Rows.Clear();
            dm = new DataModel();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }
        private void InitializeForm()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtId.Enabled = false;
            txtPhone.Enabled = false;
            txtCusId.Enabled = false;
        }
        private void LoadCarRent()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowCarRent();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["Id"];
                dgv1.Rows[index].Cells[1].Value = row["MaKH"];
                dgv1.Rows[index].Cells[2].Value = row["MaNV"];
                dgv1.Rows[index].Cells[3].Value = row["Sdt"];
                dgv1.Rows[index].Cells[4].Value = row["CarId"];
                dgv1.Rows[index].Cells[5].Value = row["GhiChu"];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            ResetForm();
            LoadCarRent();

            txtId.Enabled = true;
            txtCusId.Enabled = true;
            txtEmpId.Enabled = true;
            txtCarId.Enabled = true;
            txtPhone.Enabled = true;
            txtNote.Enabled = true;

            txtId.Text = String.Empty;
            txtCusId.Text = String.Empty;
            txtEmpId.Text = String.Empty;
            txtCarId.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtNote.Text = String.Empty;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadCarRent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtPhone.Enabled = false;
            txtCusId.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRowCarRent(Int32.Parse( dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadCarRent();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCarId.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCusId.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCusId.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCusId.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPhone.Enabled = true;
            txtCusId.Enabled = true;
            txtId.Focus();
            //if (!dm.UpdateRowSu(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtSup.Text, txtPhone.Text, txtAdr.Text))
            //{
            //    MessageBox.Show("Failed");
            //}

            ResetForm();
            LoadCarRent();
        }

        private void txtPrint_Click(object sender, EventArgs e)
        {
            dgv1.AllowUserToAddRows = false;
            if (dgv1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgv1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgv1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgv1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
            dgv1.AllowUserToAddRows = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
