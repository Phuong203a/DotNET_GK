using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
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
        int Role = 0;
        int fuelId = 1;
        DataModel dm;

        public StyleCar()
        {
            InitializeComponent();
            LoadDataModel();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //dm = new totalPric;
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
        private void LoadCarRent()
        {
            List<Dictionary<string, string>> rows = dm.FetchAllRowCarRent();
            foreach (Dictionary<string, string> row in rows)
            {
                string chucnang = "Bản đồ";
                String nhienLieu = "Điện";
                if(int.Parse( row["NhienLieu"]) == 1)
                {
                    nhienLieu = "Xăng";
                }
                int index = dgv1.Rows.Add();
                dgv1.Rows[index].Cells[0].Value = row["Id"];
                dgv1.Rows[index].Cells[1].Value = row["CarId"];
                dgv1.Rows[index].Cells[2].Value = row["MaKH"];
                dgv1.Rows[index].Cells[3].Value = chucnang;
                dgv1.Rows[index].Cells[4].Value = nhienLieu;
                dgv1.Rows[index].Cells[5].Value = row["Total"];
            }
        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dm = new DataModel();

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (!dm.RemoveRowCarRent(Int32.Parse(dgv1.Rows[dgv1.CurrentCell.RowIndex].Cells[0].Value.ToString())))
            {
                MessageBox.Show("Failed");
            }

            txtId.Text = String.Empty;
            txtIdCar.Text = String.Empty;
            txtIdKH.Text = String.Empty;
            txtTotal.Text = String.Empty;
            ResetForm();
            LoadCarRent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            if (!dm.AddNewCarRent(Int32.Parse(txtId.Text), Int32.Parse(txtIdKH.Text),Int32.Parse(txtIdCar.Text), Int32.Parse(txtTotal.Text),
               Role, fuelId))
            {
                MessageBox.Show("Failed");
            }

            txtId.Text = String.Empty;
            txtIdCar.Text = String.Empty;
            txtIdKH.Text = String.Empty;
            txtTotal.Text = String.Empty;
            ResetForm();
            LoadCarRent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Load
            txtId.Text = String.Empty;
            txtIdCar.Text = String.Empty;
            txtIdKH.Text = String.Empty;
            txtTotal.Text = String.Empty;
            ResetForm();
            LoadCarRent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int priceCar = dm.getPriceCar(int.Parse(txtIdCar.Text));
            int priceFueld = 100;
            int priceRole = 200;
            if (priceCar < 0)
            {
                MessageBox.Show("Không có Id car");
                return;
            }
            if (fuelId == 1)
            {
                priceFueld = 200;
            }
            if (Role == 8)
            {
                priceRole = 20000;
            }
            if(Role <= 3)
            {
                priceRole= 500;
            }
            if (Role <= 7)
            {
                priceRole = 1200;
            }
            txtTotal.Text = (priceCar+ priceFueld+ priceRole )+ "";
        }

        private void radioDien_CheckedChanged(object sender, EventArgs e)
        {
            fuelId = 2;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fuelId = 1;
        }

        private void txtChucNang_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Role = 1;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Role = 2;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Role =3;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Role = 4;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Role = 5;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Role = 6;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Role = 7;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Role = 8;
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        private void StyleCar_Load(object sender, EventArgs e)
        {

        }
    }

}
