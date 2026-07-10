using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlServerCe;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Base_de_Dados
{
    public partial class Form1 : Form
    {
        string directoryPath = Path.Combine(Application.StartupPath, "db");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
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
            */
            #endregion

            #region SQL Server Lite
            /*
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database};";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);

                if (!File.Exists(database))
                {
                    SQLiteConnection.CreateFile(database);
                }
            }

            SQLiteConnection connection = new SQLiteConnection(strConnection);

            try
            {
                connection.Open();
                txtResult.Text = "Conectado ao SQLite";
            }
            catch (Exception ex)
            {

                txtResult.Text = "Erro ao conectar SQLite \n" + ex;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion
            
            #region MySQL
            /*
            string strConnection = "server=127.0.0.1;User Id=root;password=8284";
            //string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=4646";

            MySqlConnection connection = new MySqlConnection(strConnection);

            try
            {
                connection.Open();
                txtResult.Text = "Conectado ao MySQL";

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = "CREATE DATABASE IF NOT EXISTS csharp_db";
                command.ExecuteNonQuery();
                txtResult.Text = "Base de Dados criada com sucesso";
                command.Dispose();
            }
            catch (Exception ex)
            {
                txtResult.Text = "Erro ao conectar MySQL \n" + ex;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
            string strConnection = $@"DataSource = {database}; Password = '1234'";

            SqlCeConnection connection = new SqlCeConnection(strConnection);

            try
            {
                connection.Open();

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;

                command.CommandText = "CREATE TABLE pessoas(id INT IDENTITY(1,1) PRIMARY KEY, none NVARCHAR(50), email NVARCHAR(50))";
                command.ExecuteNonQuery();

                txtResult.Text = "Tabela Sql CE criada com sucesso!";
                command.Dispose();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region SQLite
            /*
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database}; Version = 3";

            SQLiteConnection connection = new SQLiteConnection(strConnection);

            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                command.CommandText = "CREATE TABLE pessoas(id INTEGER PRIMARY KEY AUTOINCREMENT, none NVARCHAR(50), email NVARCHAR(50))";
                command.ExecuteNonQuery();

                txtResult.Text = "Tabela SQLite criada com sucesso!";
                command.Dispose();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region MySQL
            /*
            string strConnection = "server=127.0.0.1;User Id=root;database=csharp_db;password=8284";
            MySqlConnection connection = new MySqlConnection(strConnection);

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = "CREATE TABLE pessoas(id INT NOT NULL, none VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                command.ExecuteNonQuery();

                txtResult.Text = "Tabela MySQL criada com sucesso!";
                command.Dispose();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {         
            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
            string strConnection = $@"DataSource = {database}; Password = '1234'";

            SqlCeConnection connection = new SqlCeConnection(strConnection);

            try
            {
                connection.Open();

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO pessoas(none, email) VALUES(@name, @email)";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@name", inputName.Text);
                command.Parameters.AddWithValue("@email", inputEmail.Text);

                command.ExecuteNonQuery();

                txtResult.Text = "Dados inseridos na tabela SQL Server CE";
                command.Dispose();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region SQLite
            /*
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database}; Version = 3";

            SQLiteConnection connection = new SQLiteConnection(strConnection);

            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO pessoas(none, email) VALUES($name, $email)";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("$name", inputName.Text);
                command.Parameters.AddWithValue("$email", inputEmail.Text);

                command.ExecuteNonQuery();

                txtResult.Text = "Dados inseridos na tabela SQLite";
                command.Dispose();

            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region MySQL
            /*
            string strConnection = "server=127.0.0.1;User Id=root;database=csharp_db;password=8284";
            MySqlConnection connection = new MySqlConnection(strConnection);

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO pessoas(none, email) VALUES(@name, @email)";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@name", inputName.Text);
                command.Parameters.AddWithValue("@email", inputEmail.Text);

                command.ExecuteNonQuery();

                txtResult.Text = "Dados inseridos na tabela MySQL";
                command.Dispose();

            }
            catch (Exception ex)
            {

                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            listGrid.Rows.Clear();

            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
            string strConnection = $@"DataSource = {database}; Password = '1234'";

            SqlCeConnection connection = new SqlCeConnection(strConnection);

            try
            {
                string query = "SELECT * FROM pessoas";

                if (!String.IsNullOrEmpty(inputName.Text))
                {
                    query = "SELECT * FROM pessoas WHERE none LIKE '" + inputName.Text + "%'"; 
                }

                DataTable dataTable = new DataTable();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                connection.Open();

                adapter.Fill(dataTable);


                foreach (DataRow row in dataTable.Rows)
                {
                    listGrid.Rows.Add(row.ItemArray);
                }

                txtResult.Text = "Dados foram recuperados do banco de dados SQL Server CE";
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region SQLite
            
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database}; Version = 3";

            SQLiteConnection connection = new SQLiteConnection(strConnection);

            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM pessoas";

                if (!String.IsNullOrEmpty(inputName.Text))
                {
                    command.CommandText = "SELECT * FROM pessoas WHERE none LIKE '" + inputName.Text + "%'";
                }

                SQLiteDataReader reader = command.ExecuteReader();

                listGrid.Rows.Clear();

                while (reader.Read())
                {
                    listGrid.Rows.Add($"{reader["id"]}", $"{reader["none"]}", $"{reader["email"]}");
                }

                reader.Close();
                command.Dispose();

                txtResult.Text = "Dados foram recuperados do banco de dados SQLite";
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            
            #endregion

            #region MySQL
            /*
            string strConnection = "server=127.0.0.1;User Id=root;database=csharp_db;password=8284";
            MySqlConnection connection = new MySqlConnection(strConnection);

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM pessoas";

                if (!String.IsNullOrEmpty(inputName.Text))
                {
                    command.CommandText = "SELECT * FROM pessoas WHERE none LIKE '" + inputName.Text + "%'";
                }

                MySqlDataReader reader = command.ExecuteReader();

                listGrid.Rows.Clear();

                while (reader.Read())
                {
                    listGrid.Rows.Add($"{reader["id"]}", $"{reader["none"]}", $"{reader["email"]}");
                }

                reader.Close();

                command.Dispose();
                txtResult.Text = "Dados foram recuperados do banco de dados MySql";
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            //listGrid.Rows.Clear();

            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
            string strConnection = $@"DataSource = {database}; Password = '1234'";

            SqlCeConnection connection = new SqlCeConnection(strConnection);
            
            try
            {
                connection.Open();

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;
                int id = (int)listGrid.SelectedRows[0].Cells[0].Value;
                command.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram excluidos no SQL Server CE";
                command.Dispose();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            */
            #endregion

            #region SQLite
            
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database}; Version = 3";

            SQLiteConnection connection = new SQLiteConnection(strConnection);
            // 1. Verifica se existe alguma linha ativa no grid
            if (listGrid.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada. Clique em um registro primeiro.");
                return;
            }

            // 2. Pega o valor usando CurrentRow em vez de SelectedRows[0]
            var valorCelula = listGrid.CurrentRow.Cells[0].Value;

            // 3. Verifica se a célula não está vazia (evita o erro de valor nulo)
            if (valorCelula == null || valorCelula == DBNull.Value)
            {
                MessageBox.Show("A linha selecionada está vazia.");
                return;
            }

            // 4. Se passou pelas verificações acima, é 100% seguro converter!
            int id = Convert.ToInt32(valorCelula);
            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                //int id = (int)listGrid.SelectedRows[0].Cells[0].Value;
                //string id = listGrid.SelectedRows[0].Cells[0].Value.ToString();
                Debug.WriteLine(id);
                command.CommandText = "DELETE FROM pessoas WHERE id =" + id;
                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram excluidos no SQLite";
                command.Dispose();

            }
            catch (Exception ex)
            {
                //txtResult.Text = ex.Message;
                 Debug.WriteLine(ex.Message);
                throw;

            }
            finally
            {
                connection.Close();
            }
            
            #endregion
        }
    }
}