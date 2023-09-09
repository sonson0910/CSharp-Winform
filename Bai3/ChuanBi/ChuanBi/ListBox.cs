using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanBi
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        List<String> ls;

        private void button1_Click(object sender, EventArgs e)
        {
            ls = new List<string>() { "Puppy", "Kitten", "Elly", "Lucid", "Ema", "Suvonov" };
            for(int i = 0; i <= 5; i++)
            {
                listBox1.Name = ls[i];
                listBox1.Items.Add(ls[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectAnimal = "";
            foreach(string animal in listBox1.SelectedItems)
            {
                selectAnimal += animal.ToString() + ",";
            }
            MessageBox.Show("Động vật đã chọn: " + selectAnimal.TrimEnd(',', ' '));
        }
    }
}
