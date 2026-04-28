using System;
using System.Collections;
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

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {10, "Octavia" },
                {8, "Sophia" },
                {9, "Paola Bracho" }
            };

            students.Add(5, "Ramuel");

            if (students.ContainsKey(8))
            {
                MessageBox.Show("Contem");
            }
            else
            {
                MessageBox.Show("Não contém");
            }


            if(students.ContainsValue("Paola Bracho"))
            {
                MessageBox.Show("Contém a Paola");
            }
            else
            {
                MessageBox.Show("Não contém a Paola");
            }

            KeyValuePair<int, string> first = students.First();
            MessageBox.Show($"Primeiro aluno: {first.Key}, {first.Value}");

            //KeyValuePair<int, string> last = students.Last();
            MessageBox.Show($"Último aluno: {students.Last().Key}, {students.Last().Value}");

            //students.Clear();
            students.Remove(10);

            foreach (KeyValuePair<int, string> key in students)
            {
                listResult.Items.Add(key.Key + "=" + key.Value);
            }
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            //Funciona como um objeto, uma lista ordenada a-Z, 0-9.
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                {65, "Catharine Moças" },
                {90, "Dombas" },
                {55, "Poca-Poca" }
            };

            sortedList.Add(84, "Santanas");
            //sortedList.Reverse();
            //sortedList.Remove(90);
            //sortedList.RemoveAt(0);
            //sortedList.Count;
            //sortedList.ContainsKey(50);
            //sortedList.ContainsValue("Santanas");

            foreach (var key in sortedList)
            {
                listResult.Items.Add(key);
            }


           // sortedList.GroupBy()

        }
    }
}
