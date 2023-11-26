using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHO_THUE_XE
{
    public partial class StyleCar : Form
    {
        int carPrice;
        int materialPrice;
        int functionPrice;
        int totalPrice;

        DataModel dm;
        SqlConnection conn;
        System.Data.SqlClient.SqlConnectionStringBuilder builder;
        public StyleCar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //dm = new totalPric;
        }
    

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 20;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dm = new DataModel();

        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 700;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 400;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            carPrice = 1000;
        }

        private void Bando_CheckedChanged(object sender, EventArgs e)
        {
            functionPrice += 20;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 110;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 180;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 210;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 110;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 120;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            materialPrice = 10;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            Bando.Checked = false;

            MessageBox.Show("Đã xóa");
        }
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable table = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    table.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    table.Rows.Add(listRows.ToArray());
                }
                dgv1.DataSource = table;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "file";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel2013 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi\n" + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOPMORON;Initial Catalog=QLCHTX;Integrated Security=True";
            conn.Open();
            String SqlQuery = "select *from Style";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(SqlQuery, conn);
            dap.Fill(ds);
            dgv1.DataSource = ds.Tables[0];
            dgv1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalPrice = carPrice + materialPrice + functionPrice;
        }
    }

}
