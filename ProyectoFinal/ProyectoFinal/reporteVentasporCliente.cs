using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ProyectoFinal
{
    public partial class reporteVentasporCliente : DevExpress.XtraReports.UI.XtraReport
    {
        public reporteVentasporCliente()
        {
            InitializeComponent();
        }

        public void InitData(string idCliente)
        {
            sqlDataSource1.Queries[0].Parameters[0].Value = idCliente;

        }


    }
}
