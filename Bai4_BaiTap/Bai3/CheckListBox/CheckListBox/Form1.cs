using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*
            for (int i = 0; i < ckLstBox.Items.Count; i++)
            {
                ckLstBox.SetItemChecked(i, false);
            }
            */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ckLstBox.Items.Add("Jack and Rose");
            ckLstBox.Items.Add("Romeo and Julliet");
            ckLstBox.Items.Add("Jack and Rose");
            ckLstBox.Items.Add("Romeo and Julliet");
            ckLstBox.Items.Add("Jack and Rose");
            ckLstBox.Items.Add("Romeo and Julliet");
        }
    }
}
