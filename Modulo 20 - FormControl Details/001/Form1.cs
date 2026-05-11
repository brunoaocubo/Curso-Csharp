using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Carro");
            comboBox1.Items.Add("Moto");
            comboBox1.Items.Add("Barco");
            comboBox1.Items.Add("Avião");
            comboBox1.Items.AddRange(new object[] { "Navio", "Jato", "Submarino" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Items.Count.ToString());
            object item = comboBox1.SelectedItem;
            int index = comboBox1.SelectedIndex;

            MessageBox.Show(item + "-" + index);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
