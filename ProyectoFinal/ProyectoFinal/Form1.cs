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
            f_ventas v = new f_ventas();
            //v.MdiParent = this;
            v.venta = true;
            v.Show();
        }

        private void btnShowclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            string query = "SELECT * FROM tblCliente "; //Consulta que se enviara al servidor de la base
            DataTable dt= new DataTable();           // creando una nueva tabla
            dt=da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView1.Columns.Clear();
            gridControlClient.DataSource = dt;
            
        }

        private void btnNewclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewClient frmclientenuevo = new frmnewClient();
            frmclientenuevo.ShowDialog();
        }

        private void btnEditclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int codigoSeleccionado = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_cliente"));
                string nit = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nit"));
                string nombre = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nombre"));
                string apellido = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "apellido"));
                string telefono = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "telefono"));
                string codigoMayorista = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "codigoMayorista"));               
                //Actualizamos los valores del registro seleccionado
                DataAccess da = new DataAccess();             
                string sCommand;
                sCommand = "update tblCliente set nit='{0}', nombre='{1}', apellido='{2}', telefono='{3}', codigoMayorista='{4}' ";
                sCommand += "where id_cliente={5}";
                sCommand = string.Format(sCommand, nit, nombre, apellido, telefono, codigoMayorista, codigoSeleccionado);
                try
                {
                    da.executeCommand(sCommand); //Enviamos el comando                    
                    MessageBox.Show("Registro Actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to try update Client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to get values from gridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

        }

        private void btnDelclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Obteniendo el codigo del cliente
                int codigoSeleccionado = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_cliente"));
                //Eliminando del registro:
                DataAccess da = new DataAccess();
                string sCommand;
                sCommand = "DELETE FROM tblCliente where id_cliente={0}";                
                sCommand = string.Format(sCommand, codigoSeleccionado);

                try
                {
                    da.executeCommand(sCommand); //Enviamos el comando                    
                    MessageBox.Show("Registro eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to try Delete Client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error to get the selected Client" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowProviders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string query = "SELECT * FROM tblProveedor"; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView1.Columns.Clear();
            gridControlClient.DataSource = dt;
        }

        private void btnNewProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmNewProvider frmNuevoProveedor = new frmNewProvider();
            //frmNuevoProveedor.ShowDialog();
        }

        private void btneditProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int codigoProveedor= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_proveedor"));
                string nombre= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nombre_proveedor"));
                string nit= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nit"));
                string telfono = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "telefono"));
                string contacto= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "contacto"));
                bool estado = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "activo"));
                //Actualizamos los valores del registro seleccionado
                DataAccess da = new DataAccess();
                string sCommand;
                sCommand = "update tblProveedor set activo={0}, nombre_proveedor='{1}', nit='{2}', telefono='{3}',contacto='{4}' ";
                sCommand += "where id_proveedor={5}";
                sCommand = string.Format(sCommand, Convert.ToByte(estado), nombre, nit, telfono, contacto, codigoProveedor);
                try
                {
                    da.executeCommand(sCommand); //Enviamos el comando                    
                    MessageBox.Show("Registro Actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to try update Provider: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to get values from gridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Obteniendo el codigo del cliente
                int codigoSeleccionado = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_proveedor"));
                //Eliminando del registro:
                DataAccess da = new DataAccess();
                string sCommand;
                sCommand = "DELETE FROM tblProveedor where id_proveedor={0}";
                sCommand = string.Format(sCommand, codigoSeleccionado);

                try
                {
                    da.executeCommand(sCommand); //Enviamos el comando                    
                    MessageBox.Show("Registro eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to try Delete Provider: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error to get the selected Provider" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ventas c = new f_ventas();
            c.venta = false;
            c.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_NotasSalida nota = new f_NotasSalida();
            nota.Show();
        }
    }
}
