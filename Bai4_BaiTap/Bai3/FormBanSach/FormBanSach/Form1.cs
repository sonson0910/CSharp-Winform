using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBanSach
{
    public partial class Form1 : Form
    {
        HoaDon h;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstbListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstbListProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = lstbListProduct.SelectedItem.ToString();

            int index = lstbPurchasedGoods.FindString(curItem);
            if (index == -1)
            {
                lstbPurchasedGoods.Items.Add(curItem);
            }
            else
            {
                MessageBox.Show("Hàng đặt mua đã có rồi");
            }
        }

        private void lstbPurchasedGoods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstbPurchasedGoods.SelectedIndex;
            if(MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                lstbPurchasedGoods.Items.RemoveAt(index);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbListProduct.Items.Add("Deep Learning - Cuộc cách mạng học sâu");
            lstbListProduct.Items.Add("Đắc nhân tâm");
            lstbListProduct.Items.Add("Mắt biếc");
            lstbListProduct.Items.Add("Tôi thấy hoa vàng trên cỏ xanh");
            lstbListProduct.Items.Add("Đi tìm ước mơ");
            lstbListProduct.Items.Add("Vladimir Putin - Người đàn ông quyền lực vĩ đại");
        }

        private string PTTT()
        {
            string s = "";
            if(rdbCash.Checked)
            {
                s += rdbCash.Text + " ";
            }
            if (rdbSec.Checked)
            {
                s += rdbSec.Text + " ";
            }
            if (rdbCredit.Checked)
            {
                s += rdbCredit.Text + " ";
            }
            return s;
        }

        private string HTLL()
        {
            string s = "";
            if(cbPhoneNumber.Checked)
            {
                s += cbPhoneNumber.Text + " ";
            }
            if (cbEmail.Checked)
            {
                s += cbEmail.Text + " ";
            }
            if (cbFax.Checked)
            {
                s += cbFax.Text + " ";
            }
            return s;
        }

        private bool Checker()
        {
            if(txbName.Text.Equals("") || txbPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "notification");
                txbName.Focus();
                return false;
            }
            return true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (Checker() == false) return;
            string name = txbName.Text;
            string phoneNumber = txbPhoneNumber.Text;
            
            string product = lstbPurchasedGoods.Text;
            string sb = "";
            foreach(object item in lstbPurchasedGoods.Items)
            {
                sb += item.ToString();
                sb += "\n";
            }

            h = new HoaDon(name, phoneNumber, product);
            string s = h.nameAndPhoneNumber() + "\n" + PTTT() + "\n" + sb + HTLL();
            MessageBox.Show(s, "notification");

        }

        private void lstbPurchasedGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
