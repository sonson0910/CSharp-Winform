using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public int[] a;
        public int n;
        public string StrDay = "Dãy số sẽ được tạo ngẫu nhiên có n số";
        public string StrSum = "Tính tổng dãy số sau khi đã nhập n";
        public string StrSort = "Sắp xếp sau khi đã nhập n";

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                return;
            }
            n = int.Parse(txtInput.Text);
            if (n < 1)
            {
                MessageBox.Show("Bạn cần nhập n > 0!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            a = new int[n];
            Random rnd = new Random();
            string s = "Dãy số:";
            for(int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
                s += " " + a[i].ToString();
            }
            lblDay.Text = s;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(a == null || a.Length == 0)
            {
                MessageBox.Show("Nhập n trước", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string s = "Tổng dãy số: " + a.Sum();
            lblSum.Text = s;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string s = "Sắp xếp:";
            for(int i = 0; i < n; i++)
            {
                int pos = a[i];
                int j = i - 1;
                while(j >= 0 && pos < a[j]) {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = pos;
            }
            foreach(int i in a)
            {
                s += " " + i;
            }
            lblSort.Text = s;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            this.a = null;
            lblDay.Text = StrDay;
            lblSum.Text = StrSum;
            lblSort.Text = StrSort;
        }
    }
}
