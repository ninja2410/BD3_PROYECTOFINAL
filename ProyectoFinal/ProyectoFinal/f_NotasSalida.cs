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
    public partial class f_NotasSalida : f_Plantilla
    {
        public int sucursal=1, empleado;
        public bool entrada;
        DataTable dt = new DataTable();
        public f_NotasSalida()
        {
            InitializeComponent();
        }

        private void f_Notas_Load(object sender, EventArgs e)
        {
            string query;
            if (entrada == true)
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

            //dt.Columns.Add("Codigo Lote");
            //dt.Columns.Add("Cantidad");
            //dt.Columns.Add("Descripción");
            //dt.Columns.Add("Existencias");
            //dt.Columns.Add("Total");
        }

    }
}
