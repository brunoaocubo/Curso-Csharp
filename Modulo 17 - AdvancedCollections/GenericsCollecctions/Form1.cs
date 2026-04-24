using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericsCollecctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            //Array
            string[] namesArr = new string[3];
            namesArr[0] = "Octavia";
            namesArr[1] = "Paula";
            namesArr[2] = "Pedro";

            List<string> namesList = new List<string>()
            {
                "Gustavo",
                "Samantha"
            };
            namesList.AddRange(namesArr);

            /*
            if (namesList.Remove("Pedro"))
            {
                MessageBox.Show("Pedro removido");
            }
            else
            {
                MessageBox.Show("Não foi possível remover");
            }*/
            
            namesList.Sort();

            MessageBox.Show(namesList.IndexOf("Paula").ToString());

            namesList.Insert(2, "Sofia");

            namesList.RemoveAt(0);

            foreach (string item in namesList)
            {
                listResult.Items.Add(item);
            }

        }
    }
}
