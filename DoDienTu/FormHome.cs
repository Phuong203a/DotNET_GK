using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDienTu
{
    public partial class FormHome : Form
    {
        DataModel dm;
        public FormHome()
        {
            InitializeComponent();
            LoadDataModel();
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
            FormDevice fd = new FormDevice();
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
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            chart.Visible = false;
            chart.Series.Add("TongDoanhThu");
            chart.Series.Add("ChiPhi");
            chart.Titles.Add("Thống kê của cửa hàng");
            List<Dictionary<string, string>> rows = dm.FetchRowSt();
            int a = 0;
            int b = 0;
            foreach (Dictionary<string, string> row in rows)
            {
                a = Convert.ToInt32(Convert.ToDecimal(row["TongDoanhThu"]));
                b = Convert.ToInt32(Convert.ToDecimal(row["ChiPhi"]));
            }
            chart.Series["TongDoanhThu"].Points.AddXY("TongDoanhThu", a);
            chart.Series["ChiPhi"].Points.AddXY("ChiPhi", b);
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
        int count = 0;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            count++;
            if(count % 2 ==  0)
            {
                btnLoad.Text = "See statistic";
                chart.Visible = false;
            }
            else
            {
                btnLoad.Text = "Exit statistic";
                chart.Visible = true;
            }      
        }
    }
}
