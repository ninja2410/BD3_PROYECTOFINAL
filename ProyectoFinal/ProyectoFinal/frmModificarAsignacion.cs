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
    public partial class frmModificarAsignacion : Form
    {
        public frmModificarAsignacion()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        void cargar()
        {
            string query = "SELECT nombre_categoria as 'Nombre Categoria' FROM tblCategoria "; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView1.Columns.Clear();
            gridControl1.DataSource = dt;
        }
        private void frmModificarAsignacion_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
