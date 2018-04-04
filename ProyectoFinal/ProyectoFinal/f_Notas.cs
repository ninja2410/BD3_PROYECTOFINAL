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
    public partial class f_Notas : Form
    {
        public int sucursal=1;
        public bool entrada=true;
        DataTable dt = new DataTable();
        string tpres;
        public f_Notas()
        {
            InitializeComponent();
        }

        private void f_Notas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string query;
            if (entrada == false)
            {
                lblTitulo.Text = "Notas de Salida";
            }
            else
            {
                lblTitulo.Text = "Notas de Entrada";
            }
            query = "SELECT * FROM productosExistencias WHERE id_sucursal={0}";
            query = string.Format(query, sucursal);
            lProductos.Properties.DataSource = new DataAccess().fillDataTable(query);
            lProductos.Properties.DisplayMember = "Descripcion";
            lProductos.Properties.ValueMember = "Lote";
            dt.Columns.Add("Codigo Lote");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Presentacion");
            dt.Columns.Add("Fecha Caducidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Existencias");
            dt.Columns.Add("Nueva Existencia");
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl2.Text = DateTime.Now.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["Codigo Lote"] = lProductos.EditValue;
            r["Descripción"] = lProductos.Text;
            lProductos.Properties.DisplayMember = "Presentacion";
            r["Presentacion"] = lProductos.Text;
            lProductos.Properties.DisplayMember = "fecha_caducidad";
            r["Fecha Caducidad"]=lProductos.Text;
            r["Cantidad"] = txtCantidad.Text;
            lProductos.Properties.DisplayMember = "Existencias";
            r["Existencias"] = lProductos.Text;
            r["Nueva Existencia"] = Convert.ToInt16(txtCantidad.Text) + Convert.ToInt16(lProductos.Text);
            dt.Rows.Add(r);
            gridControl1.Refresh();
            gridControl1.RefreshDataSource();
        }
    }
}
