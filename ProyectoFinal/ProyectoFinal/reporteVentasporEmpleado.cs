using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ProyectoFinal
{
    public partial class reporteVentasporEmpleado : DevExpress.XtraReports.UI.XtraReport
    {
        public reporteVentasporEmpleado()
        {
            InitializeComponent();
        }

        public void InitData(string idEmpleado)
        {
            sqlDataSource1.Queries[0].Parameters[0].Value = idEmpleado;

        }

    }
}
