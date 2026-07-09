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
            string directoryPath = Path.Combine(Application.StartupPath, "db");

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
            string directoryPath = Path.Combine(Application.StartupPath, "db");

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

                command.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, none NVARCHAR(50), email NVARCHAR(50))";
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
            string directoryPath = Path.Combine(Application.StartupPath, "db");

            #region SQLite
            
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
    }
}
