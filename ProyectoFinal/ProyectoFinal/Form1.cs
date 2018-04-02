using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataAccess da = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ventas v = new f_ventas();
            //v.MdiParent = this;
            v.venta = true;
            v.Show();
        }

        

        private void btnNewclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewClient frmclientenuevo = new frmnewClient();
            frmclientenuevo.ShowDialog();
        }    

     

        private void btnNewProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmNewProvider frmNuevoProveedor = new frmNewProvider();
            //frmNuevoProveedor.ShowDialog();
        }
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ventas c = new f_ventas();
            c.venta = false;
            c.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_NotasSalida nota = new f_NotasSalida();
            nota.Show();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmClientes miformCliente = new frmClientes();
            miformCliente.ShowDialog();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProviders miFormProveedor = new frmProviders();
            miFormProveedor.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ListUsers list_user = new f_ListUsers();
            list_user.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_Usuarios fuser = new f_Usuarios();
            fuser.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            barButtonItem6.Enabled = false;
            barButtonItem7.Enabled = false;
        }
    }
}
