using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class f_ventas : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        List<ProductosVenta> lista = new List<ProductosVenta>();
        string query;
        public int sucursal=1;
        public f_ventas()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void f_ventas_Load(object sender, EventArgs e)
        {
            lCliente.Properties.DataSource = da.fillDataTable("SELECT * FROM tblCliente");
            lCliente.Properties.DisplayMember = "nombre";
            lCliente.Properties.ValueMember = "id_cliente";

            //LLENADO DE LOOKUPEDIT DE PRODUCTO CON VISTA listarProductos
            try
            {
                lProductos.Properties.DataSource = da.fillDataTable("SELECT id_producto, nombre_producto from listarProductos");
                lProductos.Properties.DisplayMember = "nombre_producto";
                lProductos.Properties.ValueMember = "id_producto";

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar productos "+ex.Message); 
            }

            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Precio/U");
            dt.Columns.Add("Total");
            gridControl1.DataSource = dt;

            btnCredito.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                MessageBox.Show("Se ha insertado correctamente");

            }
        }
        private bool verificar()
        {
            bool respuesta=true;
            if (txtDocumento.Text == "")
            {
                respuesta = false;
                MessageBox.Show("Debe ingresar un documento");
                txtDocumento.Focus();
            }
            if (lCliente.EditValue == null)
            {
                respuesta = false;
                MessageBox.Show("Debe Seleccionar un cliente");
                lCliente.Focus();
            }
            if (gridView1.DataRowCount < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto");
                respuesta = false;
            }
            return respuesta;
        }
        private void chkCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCredito.Checked == true)
            {
                btnCredito.Enabled = true;    
            }
            else
            {
                btnCredito.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (verificarProducto())
            {
                DataRow r = dt.NewRow();
                r["Cantidad"] = txtCantidad.Text;
                r["Descripción"] = lProductos.Text + " " + lPresentacion.Text;
                r["Precio/U"] = lPresentacion.EditValue;
                r["Total"] = Convert.ToInt16(txtCantidad.Text) * Convert.ToInt16(lPresentacion.EditValue);
                dt.Rows.Add(r);
                gridControl1.RefreshDataSource();
                gridControl1.Refresh();
            }
        }

        private bool verificarProducto()
        {
            bool resultado = true;

            if (lPresentacion.EditValue == null)
            {
                resultado = false;
                MessageBox.Show("Debe seleccionar una presentación");
            }
            if (lProductos.EditValue == null)
            {
                resultado = false;
                MessageBox.Show("Debe Seleccionar un Producto");
                lProductos.Focus();
            }

            if (txtCantidad.Text == "")
            {
                resultado = false;
                MessageBox.Show("Debe ingresar una cantidad de producto");
                txtCantidad.Focus();
            }
            
            return resultado;
        }

        private void lProductos_EditValueChanged(object sender, EventArgs e)
        {
            query = "SELECT tipo_presentacion as Presentación, precio_venta as Precio from tblasignacionprecio as a INNER JOIN tblpresentacion as p on a.id_Presentacion=p.id_Presentacion";
            query += " WHERE exists(SELECT * FROM tblasignacioncantidad WHERE id_sucursal={0} AND id_asignacionprecio=a.id_asignacionprecio) AND id_producto='{1}';";
            query = string.Format(query, sucursal, lProductos.EditValue.ToString());
            lPresentacion.Properties.DataSource = da.fillDataTable(query);
            lPresentacion.Properties.ValueMember = "Precio";
            lPresentacion.Properties.DisplayMember = "Presentación";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
