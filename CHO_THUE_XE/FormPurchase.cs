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
    public partial class FormPurchase : Form
    {
        DataModel dm;
        public FormPurchase()
        {
            InitializeComponent();
            LoadDataModel();
        }

        private void LoadDataModel()
        {
            dm = new DataModel();

        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            Device.DataSource = dm.dataFromDB();
            Device.DisplayMember = "TenSP";
            Device.ValueMember = "DonGia";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in Device.SelectedItems)
            {
                //MessageBox.Show("ID = " + ((DataRowView)item)["TenSP"].ToString());
                Cart.Items.Add("ID =" + ((DataRowView)item)["MaSP"].ToString() + ":" + "Tên =" + ((DataRowView)item)["TenSP"].ToString() + " ,  Giá = " + ((DataRowView)item)["DonGia"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int i =0; i < Device.Items.Count; i++)
            {
                if (((DataRowView)Device.Items[i])["TenSP"].ToString().ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    Device.SelectedIndex = i;
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < Cart.Items.Count; i++)
            {
                string[] token = Cart.Items[i].ToString().Split(',');
                string[] nextTk = token[1].Split('=');
                sum += Convert.ToDecimal(nextTk[1]);
                string[] preTk = token[0].Split(':');
                string[] preTk2 = preTk[0].Split('=');
                if (!dm.UpdateQuantity(preTk2[1]))
                {
                    MessageBox.Show("Failed");
                }
            }
            Cart.Items.Clear();
            txtTotal.Text = Convert.ToString(sum);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cart.Items.Clear();
            MessageBox.Show("Cancelled");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }
    }
}
