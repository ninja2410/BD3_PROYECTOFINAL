using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataAccess da = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("HOLAA");
        }

        private void btnShowclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Cadena de conexion que solicita el servidor, id, contraseña, base de datos a conectarse
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "s3xo!=am0r";
            builder.Database = "bdsurticasa";
            //iniciamos una nueva conexion
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            conn.Open();
            string query = "SELECT * FROM tblcliente ";
            DataTable dt= new DataTable();
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(query, conn);
            myDataAdapter.Fill(dt);

            gridView1.Columns.Clear();
            gridControlClient.DataSource = dt;

            
        }

        private void btnNewclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewClient frmclientenuevo = new frmnewClient();
            frmclientenuevo.ShowDialog();
        }
    }
}
