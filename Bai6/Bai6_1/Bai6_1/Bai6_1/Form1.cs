using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_1
{
    public partial class Form1 : Form
    {
        List<Product> list = new List<Product>();
        
        string proCode, proName;
        int proNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvProduct.SelectedItems.Count > 0)
            {
                int i = lstvProduct.SelectedItems[0].Index;
                if (i >= 0)
                {
                    txbProCode.Text = lstvProduct.Items[i].Text;
                    txbProName.Text = lstvProduct.Items[i].SubItems[1].Text;
                    txbNum.Text = lstvProduct.Items[i].SubItems[2].Text;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(Check() != true)
            {
                MessageBox.Show("Sai du lieu", "notification");
            }
            else
            {
                ListViewItem lstvIt = new ListViewItem();

                proCode = txbProCode.Text;
                proName = txbProName.Text;
                proNum = int.Parse(txbNum.Text);

                lstvIt.Text = proCode;
                lstvIt.SubItems.Add(proName);
                lstvIt.SubItems.Add(proNum.ToString());

                Product pro = new Product(proCode, proName, proNum);
                list.Add(pro);
                lstvProduct.Items.Add(lstvIt);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon sua khong?", "tb", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = lstvProduct.SelectedItems[0].Index;
                if (i >= 0)
                {
                    // txbProCode.Text = lstvProduct.Items[i].Text;
                    lstvProduct.Items[i].SubItems[1].Text = txbProName.Text;
                    lstvProduct.Items[i].SubItems[2].Text = txbNum.Text;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lstvProduct.SelectedItems.Count > 0)
            {
                int i = lstvProduct.SelectedItems[0].Index;
                if(MessageBox.Show("Ban co muon xoas khong?", "tb", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lstvProduct.Items.RemoveAt(i);
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(ListViewItem item in lstvProduct.Items)
            {
                sum += int.Parse(item.SubItems[2].Text);
            }
            MessageBox.Show("Sum Product = " + sum.ToString(), "notification");
        }

        private bool Check()
        {
            if(txbProCode.Text.Trim() == "" || txbProName.Text.Trim() == "" || txbNum.Text.Trim() == "")
            {
                return false;
            }
            foreach(ListViewItem x in lstvProduct.Items)
            {
                if(String.Compare(x.Text, txbProCode.Text, true) == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
