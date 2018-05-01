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
    public partial class frmVentas : Form
    {
        DataAccess da = new DataAccess();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            int idSucursal = Convert.ToInt16(lookUpEdit1.EditValue);
            DateTime fechaDesde = Convert.ToDateTime( dateEdit1.EditValue);
            DateTime fechaHasta = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            string query = "CALL SP_VENTASSUCURSAL({0},'{1}','{2}')";
            query = string.Format(query,idSucursal, fechaDesde.ToString("yyyy-MM-dd"), fechaHasta.ToString("yyyy-MM-dd"));
            DataTable dt = new DataTable();
            dt = da.fillDataTable(query);
            gridControl1.DataSource = dt;
            
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            string query = "select id_sucursal, nombre_sucursal as Nombre from tblSucursal"; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            lookUpEdit1.Properties.DataSource = dt;
            lookUpEdit1.Properties.DisplayMember = "Nombre";
            lookUpEdit1.Properties.ValueMember = "id_sucursal";

        }
    }
}
