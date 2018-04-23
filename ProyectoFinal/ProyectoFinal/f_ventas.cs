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
        decimal totalFactura;
        public bool venta=true;
        public int empleado = 1;
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
          
            

            //LLENADO DE LOOKUPEDIT DE PRODUCTO CON VISTA listarProductos
            try
            {
                //falta filtrar por sucursal
                lProductos.Properties.DataSource = da.fillDataTable("SELECT id_producto, nombre_producto from listarProductos");
                lProductos.Properties.DisplayMember = "nombre_producto";
                lProductos.Properties.ValueMember = "id_producto";

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar productos "+ex.Message); 
            }
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Precio/U");
            dt.Columns.Add("Total");

            cargar();
            layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            gridControl1.DataSource = dt;
            
        }
        private void cargar()
        {
            if (!venta)
            {
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lblTitulo.Text = "Compras Surticasa S.A.";
                button1.Text = "Comprar";
                dt.Columns.Add("Fecha Vencimiento");
                lCliente.Properties.DataSource = da.fillDataTable("SELECT * FROM tblProveedor");
                lCliente.Properties.DisplayMember = "nombre_proveedor";
                lCliente.Properties.ValueMember = "id_proveedor";
                lblCP.Text = "Seleccione Proveedor";
                simpleButton1.Text = "Agregar Proveedor";
            }
            else
            {
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lblTitulo.Text = "Ventas Surticasa S.A.";
                button1.Text = "Vender";

                lCliente.Properties.DataSource = da.fillDataTable("SELECT * FROM tblCliente");
                lCliente.Properties.DisplayMember = "nombre";
                lCliente.Properties.ValueMember = "id_cliente";
                lblCP.Text = "Seleccione Cliente";
                simpleButton1.Text = "Agregar Cliente";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                try
                {
                    if (!venta)
                    {
                        da.tansactCompra(dt, txtDocumento.Text, empleado, false, Convert.ToInt16(lCliente.EditValue), sucursal, totalFactura);
                    }
                    else
                    {
                        da.transact(dt, txtDocumento.Text, empleado, true, Convert.ToInt16(lCliente.EditValue),
                            sucursal, totalFactura);
                    }
                    MessageBox.Show("Registrado con Exito");
                    txtCantidad.Text = "";
                    txtDocumento.Text = "";
                    txtPrecio.Text = "";
                    dt.Clear();
                    gridControl1.Refresh();
                    gridControl1.RefreshDataSource();
                    gridView1.RefreshData();
                    totalFactura = 0;
                    lblTotal.Text = totalFactura.ToString();
                    txtDocumento.Focus();
                }
                catch (Exception ex)
                {

                    throw new Exception("ERROR EN LA EJECUCION "+ex.Message);
                }

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
                layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; 
            }
            else
            {
                layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool bandera=true;
            if (verificarProducto())
            {
                DataRow r = dt.NewRow();
                lPresentacion.Properties.ValueMember = "Codigo";

                if (venta)
                {

                    r["Codigo"] = verificarCodigo(Convert.ToInt16(lPresentacion.EditValue));
                    if (r["Codigo"].ToString() == "-1")
                    {
                        txtCantidad.Focus();
                        MessageBox.Show("No hay existencia sifucientes de este producto");
                        bandera = false;
                    }
                    lPresentacion.Properties.ValueMember = "Precio";
                }
                else
                {
                    r["Codigo"] = verificarAsignacion(lProductos.EditValue.ToString(),
                        Convert.ToInt16(lPresentacion.EditValue));
                }
                if (bandera)
                {

                    r["Cantidad"] = txtCantidad.Text;
                    r["Descripción"] = lProductos.Text + " " + lPresentacion.Text;
                    if (venta)
                    {
                        r["Precio/U"] = lPresentacion.EditValue;
                        totalFactura += Convert.ToInt16(txtCantidad.Text) * Convert.ToDecimal(lPresentacion.EditValue);
                        r["Total"] = Convert.ToInt16(txtCantidad.Text) * Convert.ToDecimal(lPresentacion.EditValue);
                    }
                    else
                    {
                        r["Precio/U"] = Convert.ToDecimal(txtPrecio.Text);
                        totalFactura += Convert.ToInt16(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                        r["Total"] = Convert.ToInt16(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                    }
                    lblTotal.Text = "Total: Q " + totalFactura.ToString();
                    if (!venta)
                    {
                        r["Fecha Vencimiento"] = fVencimiento.Value.Date;
                    }



                    dt.Rows.Add(r);
                    gridControl1.RefreshDataSource();
                    gridControl1.Refresh();
                    txtCantidad.Text = "";
                    lProductos.Properties.DisplayMember = "nombre_producto";
                    lProductos.Properties.ValueMember = "id_producto";
                    txtCantidad.Focus();
                }
            }
            
        }

        private int verificarCodigo(int cod)
        {
            int codigo;
            string q;
            DataTable dt = new DataTable();
            q = "SELECT id_asignacion, fecha_caducidad from tblAsignacionCantidad where id_asignacionprecio={0} and id_sucursal={1} AND cantidad>={2}";
            q += " ORDER BY fecha_caducidad ASC";

            q = string.Format(q, cod, sucursal, Convert.ToInt16(txtCantidad.Text));
            dt = da.fillDataTable(q);
            if (dt.Rows.Count == 0)
            {
                codigo = -1;
            }
            else
            {
                codigo = Convert.ToInt16(dt.Rows[0]["id_asignacion"]);
            }
            return codigo;
        }

        private int verificarAsignacion(string codProducto, int codPresentacion)
        {
            int codigo;
            string q;
            DataTable dt = new DataTable();
            q = "SELECT id_asignacionprecio as codigo FROM tblAsignacionPrecio WHERE id_producto='{0}' AND id_presentacion={1}";
            q = string.Format(q, codProducto, codPresentacion);
            dt = da.fillDataTable(q);
            codigo = Convert.ToInt16(dt.Rows[0]["codigo"]);
            return codigo;
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
            if (venta)
            {
                query = "SELECT id_asignacionprecio as Codigo, tipo_presentacion as Presentación, precio_venta as Precio from tblAsignacionPrecio as a INNER JOIN tblPresentacion as p on a.id_Presentacion=p.id_Presentacion";
                query += " WHERE exists(SELECT * FROM tblAsignacionCantidad WHERE id_sucursal={0} AND id_asignacionprecio=a.id_asignacionprecio) AND id_producto='{1}';";
                query = string.Format(query, sucursal, lProductos.EditValue.ToString());
            }
            else
            {
                query = "SELECT a.id_presentacion as Codigo, tipo_presentacion as Presentación from tblAsignacionPrecio as a INNER JOIN tblPresentacion as p on a.id_Presentacion=p.id_Presentacion";
                query += " WHERE id_producto='{0}';";
                query = string.Format(query, lProductos.EditValue.ToString());
            }
            lPresentacion.Properties.DataSource = da.fillDataTable(query);

            if (venta)
            {

                lPresentacion.Properties.ValueMember = "Precio";
            }
            else
            {
                lPresentacion.Properties.ValueMember = "Codigo";
            }
            lPresentacion.Properties.DisplayMember = "Presentación";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void lPresentacion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!venta)
            {
                //proveedor
                frmNewProvider p = new frmNewProvider();
                p.ShowDialog();
                lCliente.Properties.DataSource = da.fillDataTable("SELECT * FROM tblProveedor where activo=1");
                lCliente.Properties.DisplayMember = "nombre_proveedor";
                lCliente.Properties.ValueMember = "id_proveedor";
            }
            else
            {
                //cliente
                frmnewClient c = new frmnewClient();
                c.ShowDialog();
                lCliente.Properties.DataSource = da.fillDataTable("SELECT * FROM tblCliente");
                lCliente.Properties.DisplayMember = "nombre";
                lCliente.Properties.ValueMember = "id_cliente";
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Codigo"].ToString() == cod.ToString())
                {
                    totalFactura -= Convert.ToDecimal(dt.Rows[i]["Total"]);
                    lblTotal.Text="Total: Q " + totalFactura.ToString();
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
            gridView1.RefreshData();
        }
    }
}
