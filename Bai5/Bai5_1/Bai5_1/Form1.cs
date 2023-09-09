using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
    {
        private static List<Khach> ls = new List<Khach>();

        public static List<Khach> Ls { get => ls; set => ls = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbThoiGianGui.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }

        private void txbMaKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txbMaKhach.Text = string.Empty;
            txbTenKhach.Text = string.Empty;
            txbDiachi.Text = string.Empty;
            txbTienGui.Text = string.Empty;
            rbPhatLoc.Checked = false;
            rbThuong.Checked = false;
            cbThoiGianGui.SelectedIndex = -1;
            DTPNgayGui.Value = DateTime.Now;
            Ls.Clear();
            string ma, ten, dc;
            double tien;
            int tgg;
            bool hinhthuc;
            DateTime ngaygui;
            if (kiemtradl())
            {
                ma = txbMaKhach.Text;
                ten = txbTenKhach.Text;
                dc = txbDiachi.Text;
                tien = double.Parse(txbTienGui.Text);
                tgg = int.Parse(cbThoiGianGui.Text);
                ngaygui = DTPNgayGui.Value;
                if (rbThuong.Checked)
                {
                    hinhthuc = false;
                }
                else
                {
                    hinhthuc = true;
                }
                Khach k = new Khach(ma, ten, dc, tien, tgg, hinhthuc, ngaygui);
                Ls.Add(k);
                lsb.Items.Add(k);
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu");
            }
        }

        private void btnAddDs_Click(object sender, EventArgs e)
        {
            string ma, ten, dc;
            double tien;
            int tgg;
            bool hinhthuc;
            DateTime ngaygui;
            if (kiemtradl())
            {
                ma = txbMaKhach.Text;
                ten = txbTenKhach.Text;
                dc = txbDiachi.Text;
                tien = double.Parse(txbTienGui.Text);
                tgg = int.Parse(cbThoiGianGui.Text);
                ngaygui = DTPNgayGui.Value;
                if(rbThuong.Checked) {
                    hinhthuc = false;
                }
                else
                {
                    hinhthuc = true;
                }
                Khach k = new Khach(ma, ten, dc, tien, tgg, hinhthuc, ngaygui);
                Ls.Add(k);
                lsb.Items.Add(k);
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu");
            }
        }

        private bool kiemtradl()
        {
            if (txbMaKhach.Text.Trim().Length != 6 || txbTenKhach.Text.Trim() == "" || txbTienGui.Text == "" || txbDiachi.Text == "" || DTPNgayGui.Value.ToString() == "" || cbThoiGianGui.SelectedIndex == -1 || (rbThuong.Checked == false && rbPhatLoc.Checked == false))
            {
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            this.Show();
        }
    }
}
