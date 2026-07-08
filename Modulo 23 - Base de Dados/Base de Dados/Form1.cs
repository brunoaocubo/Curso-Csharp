using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Base_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string database = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConnection = $@"DataSource = {database}; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(database))
            {
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection connection = new SqlCeConnection(strConnection);
            try
            {
                connection.Open();
                txtResult.Text = "Conectado SQL Server CE";
            }
            catch (Exception ex)
            {

                txtResult.Text = "Erro ao conectar SQL Server CE \n" + ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
