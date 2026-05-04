using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        private delegate void UpdateControl(Control control, string proprieties, object value);

        Thread thread;

        public Form1()
        {
            InitializeComponent();
            thread = new Thread(new ThreadStart(CountTask));
            thread.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread.Start();
            }
        }

        private void CountTask()
        {
            /*  RAZÃO
            *   Devido a natureza do Controle ser uma interface gráfica, não é possível atualizar diretamente o label, pois irá travar a aplicação.
            *   É necessário criar um método invoke com delegate para executar a instrução em uma thread separada da principal.
            */

            SetProprietieValue(txtResult, "Color", txtResult.ForeColor = Color.Red); // O método invoke criado pode ser utilizado para qualquer controle gráfico.
            
            while (true)
            {
                //txtResult.Text = DateTime.Now.Second.ToString();
                //SetProprietieValue(txtResult, "Text", DateTime.Now.Second.ToString());
                txtResult.Invoke(new Action(() => txtResult.Text = DateTime.Now.Second.ToString())); //Utilizando o próprio invoke da propriedade gráfica e criando o delegate anônimo junto com o método anônimo para realizar a mesma situação.
            }



        }

        private void SetProprietieValue(Control control, string proprieties, object value)
        {
            if (control.InvokeRequired)
            {
                UpdateControl updateControl = new UpdateControl(SetProprietieValue);
                control.Invoke(updateControl, new object[] { control, proprieties, value });
            }
            else
            {
                Type type = control.GetType();
                PropertyInfo[] props = type.GetProperties();

                foreach (PropertyInfo item in props)
                {
                    if(item.Name.ToUpper() == proprieties.ToUpper())
                    {
                        item.SetValue(control, value, null);
                    }
                }
            }
        }
    }
}
