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

            MessageBox.Show("A posição de Paula é: " + namesList.IndexOf("Paula").ToString());

            namesList.Insert(2, "Sofia");

            namesList.RemoveAt(0);

            foreach (string item in namesList)
            {
                listResult.Items.Add(item);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            /*
             * Hashset não permite valores duplicados, se ja existe ele não irá adicionar novamente.
             * 
             * Hashset não permite acessar os valores atraves de indices diretamente list[1], precisa utilizar list.ElementAt(1) ou iterar sobre o hashset para obter o item.
            */

            HashSet<string> vehicles = new HashSet<string>() 
            {
                "Carro",
                "Moto",
                "Avião",
                "Navio"
            };

            if (vehicles.Add("Navio"))
            {
                MessageBox.Show("Valor adicionado");
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar o valor");
            }

            MessageBox.Show(vehicles.ElementAt(1));

            MessageBox.Show(vehicles.First());

            MessageBox.Show(vehicles.Last());

            foreach (string item in vehicles)
            {
                listResult.Items.Add(item);
            }
        }
    }
}
