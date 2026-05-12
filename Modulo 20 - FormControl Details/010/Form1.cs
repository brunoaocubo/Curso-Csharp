using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("Bruno Bracho");
            item1.SubItems.Add("99 99999 9999");
            item1.SubItems.Add("brunobracho@hotmail.com");

            ListViewItem item2 = new ListViewItem(new string[] {"Jonas", "88 88888 8888", "jonas@outlook.com"});

            ListViewItem item3 = new ListViewItem(new string[] { "Sofia", "77 77777 7777", "sofia@live.com" });

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }
    }
}
