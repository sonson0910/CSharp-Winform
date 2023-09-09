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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi mục tìm kiếm không?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string s = txbMkh.Text;
            s = s.Trim();
            string msg = "";
            
            foreach (Khach k in Form1.Ls)
            {
                if (k.Ma.Equals(s))
                {
                    msg += "Mã khách: " + s + "\nSố tiền: " + k.tinhtien().ToString();
                }
                else
                {
                    msg = "Khách hàng có mã " + s + " hiện chưa có trong danh sách.";
                }
            }
            content.Text = msg;
        }
    }
}
