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
            "Loren", "Carla", "Jessi", "Alfredo", "João", "Lucas", "Anabel", "Cassia", "Douglas", "Gabriel", "Gabriela", "Bruna", "Bernardo", "Leandro", "Carmen", "Jaiana", "Alicia"
        };

        List<int> list_numbers = new List<int>()
        {
            12,1,2,3,9,8,7,5,4,10,6,11
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
            //listResult.DataSource = res_numbers.ToArray();

            //Opção 2
            
            foreach (int num in res_numbers)
            {
                listResult.Items.Add(num);
            }
            
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

        private void btnOrderby_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            /*
            var res_numbers = from num in list_numbers
                              orderby num descending
                              select num;
           

            var res_names = from name in list_names
                            orderby name 
                            select name;

             */

            var res_products = from prod in list_products
                               orderby prod.Value
                               where prod.Value >= 50
                               select prod;

            foreach (var item in res_products)
            {
                listResult.Items.Add($"{item.Key} | R$ {item.Value}");
            }
            
        }

        private void btnGroupby_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            var res_states = from state in list_states
                             group state by state.Value;
                             
            foreach (var group in res_states)
            {
                listResult.Items.Add(group.Key);

                foreach (var state in group)
                {
                    listResult.Items.Add("    " + state.Key);
                }
            }
        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();

            var res = from name in list_names select name;
            var res1 = (from name in list_names where name.StartsWith("L") select name).Count();

            listResult.Items.Add(res.Count() + " nomes na lista.");
            listResult.Items.Add("Nomes começando com a letra L: " + res1);

            double average1 = list_numbers.Average();
            listResult.Items.Add("Média dos valores na lista de números: " + average1);

            var res3 = from num in list_numbers where num < 10 select num;
            double average2 = res3.Average();
            listResult.Items.Add("Média dos números menores que 10: " + average2);

            int sum1 = list_numbers.Sum();
            listResult.Items.Add("Soma dos valores na lista de números: " + sum1);

            var res4 = from num in list_numbers where num < 10 select num;
            double sum2 = res4.Sum();
            listResult.Items.Add("Soma dos números menores que 10: " + sum2);

            listResult.Items.Add($"Valor mínimo da lista de números: {list_numbers.Min()}");
            listResult.Items.Add($"Valor máximo da lista de números: {list_numbers.Max()}");
            //long count = list_numbers.LongCount(); //Pode ser utilizado em uma consulta LINQ

            //Pode ser utilizado em uma consulta LINQ
            string greaterName = list_names.Aggregate((greater, nextName) =>
            {
                if (greater.Length > nextName.Length)
                {
                    return greater;

                }
                else
                {
                    return nextName;
                }
            });

            listResult.Items.Add($"O maior nome da lista: {greaterName}");

        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            //int firstElement = list_numbers.First();
            int firstElement = list_numbers.FirstOrDefault();
            listResult.Items.Add(firstElement);

            //int lastElement = list_numbers.Last();
            int lastElement = list_numbers.LastOrDefault();
            listResult.Items.Add(lastElement);

            //int elementAt = list_numbers.ElementAt(3);
            int elementAt = list_numbers.ElementAtOrDefault(3);
            listResult.Items.Add(elementAt);

            var query = from n in list_numbers where n > 1000 select n;
            int num = query.FirstOrDefault(); //Primeiro ou valor padrão dos valores filtrados.
            listResult.Items.Add(num);
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            #region Lambda SELECT
            /*
            var linq = from name in list_names select name;
            var linqLambda = list_names.Select(name => name);
            listResult.Items.AddRange(linqLambda.ToArray());
            */
            #endregion

            #region Lambda WHERE
            /*
            var linq2 = from name in list_names where name.StartsWith("L") select name;
            var linq2Lambda = list_names.Where(name => name.StartsWith("L"));
            listResult.Items.AddRange(linq2Lambda.ToArray());
            */
            #endregion

            #region Lambda ORDER BY
            /*
            var linq3 = from name in list_names orderby name select name;
            var linq3Lambda = list_names.OrderBy(name => name);
            var linq3LambdaDescending = list_names.OrderByDescending(name => name);
            listResult.Items.AddRange(linq3LambdaDescending.ToArray());
            */
            #endregion

            #region Lambda GROUP BY
            
            var linq4 = from state in list_states group state by state.Value;
            var linq4Lambda = list_states.GroupBy(state => state.Value);
            foreach (var group in linq4Lambda)
            {
                listResult.Items.Add(group.Key);
                foreach (var state in group)
                {
                    listResult.Items.Add("     " + state.Key);
                }
            }
            
            #endregion
        }
    }
}
