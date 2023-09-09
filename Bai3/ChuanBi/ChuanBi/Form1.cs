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

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Food> listItem;

        private void button1_Click_1(object sender, EventArgs e)
        {
            listItem = new List<Food>() { 
                new Food() { Name = "Titan", Price = 1000000 },
                new Food() { Name = "Nhôm", Price = 100000 },
                new Food() { Name = "Đồng", Price = 10000 },
                new Food() { Name = "Sắt", Price = 1000 },
            };
            
            foreach(Food food in listItem)
            {
                comboBox1.Items.Add(food.Name);
                comboBox2.Items.Add(food.Price);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            this.Hide();
            listBox.ShowDialog();
            this.Show();
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

}
