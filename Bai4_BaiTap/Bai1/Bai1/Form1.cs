using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public String s = "Nhập a và b để tính tổng các số từ a đến b";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b, sum = 0;
            do
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
            } while (a > b);
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            contentKQ.Text = "Tổng các chữ số từ " + a.ToString() + " đến " + b.ToString() + " = " + sum.ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            contentKQ.Text = "Nhập a và b để tính tổng các số từ a đến b";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
