using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        List<string> list_names = new List<string>()
        {
            "Loren", "Carla", "Jessi", "Alfredo", "João", "Lucas", "Anabel", "Cassia"
        };

        List<int> list_numbers = new List<int>()
        {
            1,2,3,4,5,6,7,9,10,11,12
        };

        Dictionary<string, double> list_products = new Dictionary<string, double>()
        {
            {"Carregador USB", 59.99 }, {"Adaptador WiFi", 47.99}, {"Mouse Logitech M208", 87.59}, {"Microfone Acer L10", 158.99}, {"Fone Bluetooh Anker P20", 159.99}
        };

        Dictionary<string, string> list_states = new Dictionary<string, string>()
        {
            {"Rio de Janeiro", "Brasil"}, {"Atlanta", "EUA"}, {"Buenos Aires", "Argentina"}, {"Sidney", "Austrália"}, {"Bahia", "Brasil"}, {"Brisbane", "Austrália"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //Metodo Comum e custoso
            /*
            foreach (string name in list_names)
            {
                if (name.StartsWith(inputTxt.Text))
                {
                    listResult.Items.Add(name);
                }
            }*/

            #region LINQ - List_Names
            
            IEnumerable<string> res_names = from name in list_names
                                      where name.StartsWith(inputTxt.Text)
                                      select name;
            
            //Opção 1
            listResult.Items.AddRange(res_names.ToArray());
            

            //Opção2: O mesmo foreach é utilizado, mas dessa vez é com a coleção ja com os valores encontrados.
            /*
            foreach (string name in res_names)
            {
                if (name.StartsWith(inputTxt.Text))
                {
                    listResult.Items.Add(name);
                }
            }
            */
            #endregion

            #region LINQ - List_Numbers
            IEnumerable<int> res_numbers = from num in list_numbers where num % 2 == 0 select num;

            //Opção 1
            listResult.DataSource = res_numbers.ToArray();

            //Opção 2
            /*
            foreach (int num in res_numbers)
            {
                listResult.Items.Add(num);
            }
            */
            #endregion
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            
            string input = inputTxt.Text.ToLower(); //Transformando a string de entrada em minusculo para facilitar a busca.

            // Transformando o dado da lista em minusculo para facilitar a busca.
            var res3 = from name in list_names
                       where name.ToLower().Contains(input) 
                       select name;

            foreach (var item in res3)
            {
                listResult.Items.Add(item);
            }
        }
    }
}
