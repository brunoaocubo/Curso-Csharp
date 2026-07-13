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

                command.CommandText = "CREATE TABLE pessoas(id INT IDENTITY(1,1) PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
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

                command.CommandText = "CREATE TABLE pessoas(id INTEGER PRIMARY KEY AUTOINCREMENT, nome NVARCHAR(50), email NVARCHAR(50))";
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

                command.CommandText = "CREATE TABLE pessoas(id INT NOT NULL AUTO_INCREMENT, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
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

                command.CommandText = "INSERT INTO pessoas(nome, email) VALUES(@name, @email)";

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
            
            string database = Path.Combine(directoryPath, "DBSQLite.db");
            string strConnection = $@"Data Source = {database}; Version = 3";

            SQLiteConnection connection = new SQLiteConnection(strConnection);

            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO pessoas(nome, email) VALUES($name, $email)";

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

                command.CommandText = "INSERT INTO pessoas(nome, email) VALUES(@name, @email)";

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
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + inputName.Text + "%'"; 
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
                    command.CommandText = "SELECT * FROM pessoas WHERE nome LIKE '" + inputName.Text + "%'";
                }

                SQLiteDataReader reader = command.ExecuteReader();

                listGrid.Rows.Clear();

                while (reader.Read())
                {
                    listGrid.Rows.Add($"{reader["id"]}", $"{reader["nome"]}", $"{reader["email"]}");
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
                    command.CommandText = "SELECT * FROM pessoas WHERE nome LIKE '" + inputName.Text + "%'";
                }

                MySqlDataReader reader = command.ExecuteReader();

                listGrid.Rows.Clear();

                while (reader.Read())
                {
                    listGrid.Rows.Add($"{reader["id"]}", $"{reader["nome"]}", $"{reader["email"]}");
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
            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                int id = Convert.ToInt32(listGrid.SelectedRows[0].Cells[0].Value);
                command.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram excluidos no SQLite";
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
                int id = Convert.ToInt32(listGrid.SelectedRows[0].Cells[0].Value);
                command.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";
                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram excluidos no MySql";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            /*
            string database = Path.Combine(directoryPath, "DBSQLServer.sdf");
            string strConnection = $@"DataSource = {database}; Password = '1234'";
            SqlCeConnection connection = new SqlCeConnection(strConnection);

            string updateQuery = "UPDATE pessoas SET nome = @nome, email = @email WHERE id = @id";
            int id = (int)listGrid.SelectedRows[0].Cells[0].Value;

            try
            {
                connection.Open();

                SqlCeCommand command = new SqlCeCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@nome", inputName.Text);
                command.Parameters.AddWithValue("@email", inputEmail.Text);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram alterados no SQL Server CE";
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

            string updateQuery = "UPDATE pessoas SET nome = @nome, email = @email WHERE id = @id";
            int id = Convert.ToInt32(listGrid.SelectedRows[0].Cells[0].Value);

            try
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@nome", inputName.Text);
                command.Parameters.AddWithValue("@email", inputEmail.Text);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
                txtResult.Text = "Dados foram alterados no SQL Server CE";
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
            
            #endregion
        }

        private void listGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inputName.Text = listGrid.SelectedRows[0].Cells["name"].Value.ToString();
            inputEmail.Text = listGrid.SelectedRows[0].Cells["email"].Value.ToString();
        }
    }
}