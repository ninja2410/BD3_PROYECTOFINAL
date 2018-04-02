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
        public f_Notas()
        {
            InitializeComponent();
        }

        private void f_Notas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl2.Text = DateTime.Now.ToString();
        }
    }
}
