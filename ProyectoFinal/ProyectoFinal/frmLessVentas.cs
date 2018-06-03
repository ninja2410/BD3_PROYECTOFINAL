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
    public partial class frmLessVentas : DevExpress.XtraEditors.XtraForm
    {
        DataAccess da = new DataAccess();
        public frmLessVentas()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Obtenemos la sucursal a generar
            string sucursal = gridLookUpEdit1.EditValue.ToString();

            //Enviamos al query del reporte
            reporteMenosVendidos miReporte = new reporteMenosVendidos();
            miReporte.InitData(sucursal);
            documentViewer1.DocumentSource = miReporte;
            miReporte.CreateDocument();

        }

        private void frmLessVentas_Load(object sender, EventArgs e)
        {
            gridLookUpEdit1.Properties.DataSource = da.fillDataTable("SELECT nombre_sucursal from tblSucursal");
            gridLookUpEdit1.Properties.DisplayMember = "nombre_sucursal";
            gridLookUpEdit1.Properties.ValueMember = "nombre_sucursal";

        }
    }
}