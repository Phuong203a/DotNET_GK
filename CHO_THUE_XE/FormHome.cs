using iTextSharp.text.pdf.qrcode;
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
    public partial class FormHome : Form
    {
        DataModel dm;
        bool isSoLuong = false;
        int count = 0;

        public FormHome()
        {
            InitializeComponent();
            LoadDataModel();
            lblTotalCar.Visible = false;
            chart.Visible = false;
            btnThongKe.Visible= false;
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff ft = new FormStaff();
            ft.ShowDialog();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCarInformation fd = new FormCarInformation();
            fd.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClient fc = new FormClient();
            fc.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCarRent fs = new FormCarRent();
            fs.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            loadThongKe();
        }
        private void loadThongKe()
        {
           
            while (chart.Series.Count > 0) 
            {
                foreach (var series in chart.Series)
                {
                    series.Points.Clear();
                }

                chart.Series.RemoveAt(0);
            
            }
            while (chart.Titles.Count > 0) { chart.Titles.RemoveAt(0); }
            if (isSoLuong)
            {
             

                chart.Titles.Add("Số lượng xe theo mẫu");
                List<Dictionary<string, string>> rows = dm.FetchRowSt();
                int countCar = 0;
                foreach (Dictionary<string, string> row in rows)
                {
                    chart.Series.Add(row["type"]);
                    chart.Series[row["type"]].Points.AddXY("So luong", Int32.Parse(row["count"]));
                    countCar += Int32.Parse(row["count"]);

                }
                lblTotalCar.Text = "Tổng số lượng xe trong kho: " + countCar;
            }
            else
            {

                chart.Titles.Add("Doanh thu");
                List<Dictionary<string, string>> rows = dm.FetchDoanhThu();
                int sum = 0;
                foreach (Dictionary<string, string> row in rows)
                {
                    chart.Series.Add(row["type"]);
                    chart.Series[row["type"]].Points.AddXY("So luong", Int32.Parse(row["sum"]));
                    sum += Int32.Parse(row["sum"]);

                }
                lblTotalCar.Text = "Tổng số doanh thu: " + sum;
            }
        }

        private void enableChart()
        {
            count++;
            if (count % 2 == 0)
            {
                btnLoad.Text = "See statistic";
                chart.Visible = false;
                lblTotalCar.Visible = false;
            }
            else
            {
                btnLoad.Text = "Exit statistic";
                chart.Visible = true;
                lblTotalCar.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fh = new FormLogin();
            fh.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fh = new FormLogin();
            fh.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnThongKe.Text = (isSoLuong ? "Xem doanh thu" : "Xem so luong");
            btnThongKe.Visible = true;
            enableChart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            schedule ft = new schedule();
            ft.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCarRent ft = new FormCarRent();
            ft.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StyleCar ft = new StyleCar();
            ft.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            isSoLuong = !isSoLuong;
            btnThongKe.Text = (isSoLuong ? "Xem doanh thu" : "Xem so luong");
            loadThongKe();
        }
    }
}
