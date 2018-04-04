using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProyectoFinal
{
    public partial class f_EditUser : DevExpress.XtraEditors.XtraForm
    {
        DataAccess da = new DataAccess();
        int idEmpleado = 0;
        public f_EditUser()
        {
            InitializeComponent();
        }

        private void f_EditUser_Load(object sender, EventArgs e)
        {
            cmbEditUser.Properties.DataSource = da.fillDataTable("SELECT * FROM tblEmpleado");
            cmbEditUser.Properties.DisplayMember = "nombre" + "apellido";
            cmbEditUser.Properties.ValueMember = "id_Empleado";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idEmpleado = Convert.ToByte(cmbEditUser.Properties.ValueMember);

            MessageBox.Show(idEmpleado.ToString());
        }
    }
}