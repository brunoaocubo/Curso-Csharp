using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            #region CONTAINS / ToString
            /*
            string text = "Este texto é do tipo string";

            if (text.Contains("tipo"))
            {
                textResult.Text = "Contém.";
            }
            else
            {
                textResult.Text = "Não Contém.";
            }
            
            int num = 9000;

            //Tentativa de conversão de int para string.
            textResult.Text = num.ToString(); 
            */
            #endregion

            #region TOUPPER/TOLOWER
            /*
            string name = "Bruno Montenegro";

            //textResult.Text = name.ToUpper();
            textResult.Text = name.ToLower();
            */
            #endregion

            #region INDEXOF / LASTINDEXOF
            /*
            string name = "Bruno Montenegro";
            
            //Procura a primeira ocorrência
            textResult.Text = "indice: " + name.IndexOf("r");

            //Procura a primeira ocorrência a partir de um ponto de inicio diferente, 4.
            textResult.Text = "indice: " + name.IndexOf("r", 4);

            //Procura a primeira ocorrência a partir de um ponto de inicio diferente, 4, e que percorra apenas mais algumas casas, 5.
            textResult.Text = "indice: " + name.IndexOf("r", 4, 5);*/

            //LAST
            /*
            //Procura a última ocorrência...
            //textResult.Text = "indice: " + name.LastIndexOf("o");

            textResult.Text = "indice: " + name.LastIndexOf("Montenegro");
            */
            #endregion

            #region INSERT / REPLACE
            /*
            string name = "Bruno Montenegro";
            //string finalName = name.Insert(6, "Paulo "); //Insere uma nova string em uma posição determinada.
            string finalName = name.Replace("Bru", "Bre"); //Substitui string ou char, por outra string ou char.
            textResult.Text = finalName;
            */
            #endregion

            #region LENGTH / SUBSTRING
            /*
            string name = "Bruno Afonso";
            /*int size = name.Length;
            //textResult.Text = $"O nome {name} possui um tamanho de: {size}";

            textResult.Text = "";
            for (int i = 0; i < name.Length; i++)
            {
                // Percorre todo o string e em cada char adiciona no texto e pula uma linha. Nome na vertical.
                textResult.Text += $"{name[i]}\n"; 
            }


            // Busca uma parte do nome a partir de um indice com ,ou, sem limite de caracteres.
            string partialName = name.Substring(6, 5);
            //textResult.Text = partialName;

            // Busca a partir do espaço vazio da string para frente com, ou, sem limite de caracteres.
            string emptyName = name.Substring(name.IndexOf(" "), 3);
            textResult.Text = emptyName;
            */
            #endregion

            #region SPLIT
            /*
            //string names = "Bruno_+_Paulo_+_Hugo__Octavio_Sofia          Igor";
            string names = "Bruno_Paulo_Hugo_Octavio_Sofia  Igor";
            
            textResult.Text = "";

            // Separador de char/caractere.
            char[] separatorChar = { ' ', '_' };
            // Separador de string personalizado.
            string[] separatorString = { "_+_", "__" };

            //StringSplitOptions deve ser usado ao utilizar separadores string para definir se irá remover espaços vazios .RemoveEmptyEntries, ou, manter com .None.
            string[] result = names.Split(separatorString, StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in result)
            {
                textResult.Text += $"{name}\n";
            }
            */
            #endregion
        }
    }
}
