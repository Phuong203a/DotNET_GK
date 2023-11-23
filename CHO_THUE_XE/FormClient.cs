﻿using System;
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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CHO_THUE_XE
{
    public partial class FormClient : Form
    {
        DataModel dm;
        public FormClient()
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

        private void FormClient_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtClient.Enabled = false;
            txtType.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            txtCCCD.Enabled = false;
            btnSave.Enabled = false;
        }

        private void LoadClientData()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowCl();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["MaKH"];
                dgv1.Rows[index].Cells[2].Value = row["TenKH"];
                dgv1.Rows[index].Cells[1].Value = row["CCCD"];
                dgv1.Rows[index].Cells[3].Value = row["Loai"];
                dgv1.Rows[index].Cells[4].Value = row["SoDT"];
                dgv1.Rows[index].Cells[5].Value = row["DiaChi"];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtClient.Enabled = true;
            txtType.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;
            txtCCCD.Enabled = true;

            txtClient.Text = String.Empty;
            txtType.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAdr.Text = String.Empty;
            txtCCCD.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dm.AddNewRowCl(txtClient.Text, txtType.Text, txtPhone.Text, txtAdr.Text, txtCCCD.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadClientData();

            txtClient.Enabled = false;
            txtType.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            btnSave.Enabled = false;
            txtCCCD.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadClientData();
            txtClient.Enabled = true;
            txtType.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;
            txtCCCD.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtClient.Enabled = false;
            txtType.Enabled = false;
            txtPhone.Enabled = false;
            txtAdr.Enabled = false;
            btnSave.Enabled = false;
            txtCCCD.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want remove it?", "Really?", MessageBoxButtons.YesNo);
            switch (choose)
            {
                case DialogResult.Yes:
                    if (!dm.RemoveRowCl(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Failed");
                    }

                    ResetForm();
                    LoadClientData();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Cancelled");
                    break;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClient.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtType.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAdr.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCCCD.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            txtClient.Enabled = true;
            txtType.Enabled = true;
            txtPhone.Enabled = true;
            txtAdr.Enabled = true;
            btnSave.Enabled = true;
            txtCCCD.Enabled = true;
            txtClient.Focus();
            if (!dm.UpdateRowCl(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString(), txtClient.Text, txtType.Text, txtPhone.Text, txtAdr.Text, txtCCCD.Text))
            {
                MessageBox.Show("Failed");
            }

            ResetForm();
            LoadClientData();
        }

        private void txtPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Excel File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgv1, saveFileDialog.FileName);
                MessageBox.Show("Export successful!");
            }

        }

        private static void ExportToExcel(DataGridView dgv1, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Write header row
                    for (int i = 1; i <= dgv1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).Value = dgv1.Columns[i - 1].HeaderText;
                    }

                    // Write data
                    for (int i = 0; i < dgv1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv1.Columns.Count; j++)
                        {
                            object cellValue = dgv1.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                        }
                    }

                    workbook.SaveAs(filePath);
                }

                MessageBox.Show("Export successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during export: {ex.Message}", "Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

