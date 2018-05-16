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
    public partial class frmAsignarPermisos : Form
    {
        public frmAsignarPermisos()
        {
            InitializeComponent();
        }

        private void frmAsignarPermisos_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string query = "SELECT id_empleado, usuario, nombre FROM tblEmpleado";
            lookUpEdit1.Properties.DataSource = da.fillDataTable(query);
            lookUpEdit1.Properties.ValueMember = "id_empleado";
            lookUpEdit1.Properties.DisplayMember = "nombre";
            
        }
    }
}
