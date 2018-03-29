using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class DataAccess //clase publica dentro del proyecto pero oculta en otros como bisness
    {
        #region attributes
        private MySqlConnection cnConnection { get; set; }
        private string ConnectionString = string.Empty;//inicializado cadena vacia
        string x = "",query="";
        #endregion


        #region buillder
        public DataAccess()
        {
            //ConnectionString = "Data Source=DESKTOP-6A9DRNR\\SQLEXPRESS;Initial Catalog=ARQUITECTURA;Integrated Security=True";
            //ConnectionString = "Server = arquitecturameso.ddns.net; Database = dbCompra2017; User Id = sa; Password = database;";
            //ConnectionString = "Server=sql3.freesqldatabase.com;Database=sql3227915; Uid=sql3227915;Pwd=jLzyXnFhG1;";
            //ConnectionString = "Server=ns02.000webhost.com;Database=id3406690_bdproyecto3;Uid=id3406690_ninja24;Pwd=4oj118gv;";
            ConnectionString = "Server=127.0.0.1;Database=dbsurticasa;Uid=root;Pwd=database;";

            cnConnection = new MySqlConnection(ConnectionString);
            
        }
        #endregion

        #region method
        public void openConnection()
        {
            try
            {
                if(cnConnection.State!=ConnectionState.Open)
                {
                    cnConnection.Open();//si esta cerrada la conexion, abrir la conexion
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error opening connection, error detail: " + ex.Message+"\n");
            }
        }

        public void closeConnection()
        {
            try
            {
                if (cnConnection.State != ConnectionState.Closed)
                {
                    cnConnection.Close();//si esta abierta la conexion, cerrar la conexion la conexion
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error opening connection, error detail: " + ex.Message + "\n");
            }
        }

        public DataTable fillDataTable(string sQuery) //va a retornar una tabla de datos, consulta
        {
            DataTable dt = new DataTable();
            try
            {
                
                MySqlDataAdapter da = new MySqlDataAdapter(sQuery, cnConnection);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Select detail error: "+ex.Message+"\n");
            }
            return dt;
        }
        #endregion


        public int executeCommand(string sCommand)//funcion para ejecutar un comando sql
        {
            MySqlCommand cm = new MySqlCommand(sCommand, cnConnection);
            //en el sql comand hay que abrir y cerrar conexion
            try
            {
                cm.Connection.Open();
                return cm.ExecuteNonQuery();//aqui se retorna un int con la cantidad de rows afectadas
               
            }
            catch(Exception ex)
            {
                throw new Exception("Error for execute command:" + ex.Message);
            }
            finally//siempre se ejecuta independiente de todo
            {
                cm.Connection.Close();
            }
        }

        public void transact(List<int> codigos, List<int> cantidades, string documento, string noEnvio, int codEmpleado, int codTipoVenta, decimal total)
        {
            x = "EXECUTE insert_detalle {0}, {1}";
            cnConnection.Open();

            // Start a local transaction.
            MySqlTransaction sqlTran = cnConnection.BeginTransaction();

            // Enlist a command in the current transaction.
            MySqlCommand command = cnConnection.CreateCommand();
            command.Transaction = sqlTran;

            try
            {
                query = "EXECUTE dbo.insert_factura '{0}', '{1}', '{2}', {3}, {4}, {5}";
                query = string.Format(query, documento, DateTime.Today.Date.ToString("yyyy-MM-dd"), noEnvio, codEmpleado, codTipoVenta, total);
                // Execute two separate commands.
                command.CommandText = query;
                command.ExecuteNonQuery();
                for (int i = 0; i < codigos.Count; i++)
                {

                    x = "";
                    x = "EXECUTE insert_detalle {0}, {1}";
                    x = string.Format(x, cantidades[i], codigos[i]);
                    command.CommandText = x;
                    command.ExecuteNonQuery();
                }


                // Commit the transaction.
                sqlTran.Commit();

            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    // Throws an InvalidOperationException if the connection 
                    // is closed or the transaction has already been rolled 
                    // back on the server.
                    MessageBox.Show("Error " + exRollback + "Info Adicional" + ex.Message);
                }
                throw new Exception("ERROR EN LA TRANSACCION " + ex.Message);
            }


        }

    }
}
