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
    public partial class frmVntporEmpleado : DevExpress.XtraEditors.XtraForm
    {
        DataAccess da = new DataAccess();
        public frmVntporEmpleado()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Obtenemos el empleado o cliente para generar reporte

            if (radioBtnEmpleado.Checked == true)
            {
                string empleado = gridLookUpEdit1.EditValue.ToString();

                //Enviamos al query del reporte
                reporteVentasporEmpleado miReporte = new reporteVentasporEmpleado();
                miReporte.InitData(empleado);
                documentViewer1.DocumentSource = miReporte;
                miReporte.CreateDocument();
            }
            else if (radioButtonCliente.Checked == true)
            {
                string cliente = gridLookUpEdit1.EditValue.ToString();
                reporteVentasporCliente miReporte = new reporteVentasporCliente();
                miReporte.InitData(cliente);
                documentViewer1.DocumentSource = miReporte;
                miReporte.CreateDocument();
            }
            else
            {
                MessageBox.Show("TRY AGAIN! ","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        void initData(int value)
        {
            //Limpiando el data grid view;

            gridLookUpEdit1.Properties.View.Columns.Clear();
            if (value == 1)
            {
                //EMPLEADOS
                gridLookUpEdit1.Properties.DataSource = da.fillDataTable("SELECT tblVenta.id_empleado, tblEmpleado.nombre from tblVenta INNER JOIN tblEmpleado ON tblVenta.id_empleado = tblEmpleado.id_empleado GROUP BY nombre");                
                gridLookUpEdit1.Properties.DisplayMember = "nombre";
                gridLookUpEdit1.Properties.ValueMember = "id_empleado";                
            }

            else if (value == 2)
            {//CLIENTES
                gridLookUpEdit1.Properties.DataSource = da.fillDataTable("SELECT tblVenta.id_cliente, tblCliente.nit, CONCAT(tblCliente.nombre,' ',tblCliente.apellido) as Nombre from tblVenta INNER JOIN tblCliente ON tblVenta.id_cliente = tblCliente.id_cliente GROUP BY id_cliente");
                gridLookUpEdit1.Refresh();
                gridLookUpEdit1.Properties.DisplayMember = "Nombre";
                gridLookUpEdit1.Properties.ValueMember = "id_cliente";
                
            }
            else
            {
                //no hacer nada si no hay ningun valor definido
            }

        }
        private void frmVntporEmpleado_Load(object sender, EventArgs e)
        {

            //Llenando el grid con los valores para Clientes o para Empleados
            //PARA EMPLEADOS POR DEFAULT
            radioBtnEmpleado.Checked = true;
            initData(1);            
        }

        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCliente.Checked == true)
            {
                initData(2);
            }
        }

        private void radioBtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnEmpleado.Checked==true)
            {
                initData(1);
            }
        }
    }
}