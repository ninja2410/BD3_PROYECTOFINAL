using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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
            v.MdiParent = this;
            v.venta = true;
            v.Show();
        }

        

        private void btnNewclient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewClient frmclientenuevo = new frmnewClient();
            frmclientenuevo.ShowDialog();
        }    

     
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ventas c = new f_ventas();
            c.venta = false;
            c.MdiParent = this;
            c.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_NotasEntrada n = new f_NotasEntrada();
            n.MdiParent = this;
            n.Show();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmClientes miformCliente = new frmClientes();
            miformCliente.MdiParent = this;
            miformCliente.Show();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProviders miFormProveedor = new frmProviders();
            miFormProveedor.MdiParent = this;
            miFormProveedor.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_Notas nota = new f_Notas();
            nota.entrada = false;
            nota.MdiParent = this;
            nota.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_EditUser u = new f_EditUser();
            u.MdiParent = this;
            u.Show();
        }
        
        private void btnnewsucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewsucursal a = new frmnewsucursal();
            a.MdiParent = this;
            a.Show();
        }

        private void btnversucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmversucursal a = new frmversucursal();
            a.MdiParent = this;
            a.Show();
        }

        private void btnupdatesucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatesucursal a = new frmupdatesucursal();
            a.MdiParent = this;
            a.Show();
        }

        private void btndelsucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmdelsucursal a = new frmdelsucursal();
            a.MdiParent = this;
            a.Show();
        }

        private void btnnewproducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewproducto a = new frmnewproducto();
            a.MdiParent = this;
            a.Show();
        }

        private void btnverproducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmverproducto a = new frmverproducto();
            a.MdiParent = this;
            a.Show();
        }

        private void btnupdateproducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdateproducto a = new frmupdateproducto();
            a.MdiParent = this;
            a.Show();
        }

        private void btndelproducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmdelproducto a = new frmdelproducto();
            a.MdiParent = this;
            a.Show();
        }

        private void btnnewcate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewcategoria a = new frmnewcategoria();
            a.MdiParent = this;
            a.Show();
        }

        private void btnvercategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmvercategoria a = new frmvercategoria();
            a.MdiParent = this;
            a.Show();
        }

        private void bar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatecategoria a = new frmupdatecategoria();
            a.MdiParent = this;
            a.Show();
        }

        private void btndelcategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmdelcategoria a = new frmdelcategoria();
            a.MdiParent = this;
            a.Show();
        }

        private void btnnewmarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmnewmarca a = new frmnewmarca();
            a.MdiParent = this;
            a.Show();
        }

        private void btnvermarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmvermarca a = new frmvermarca();
            a.MdiParent = this;
            a.Show();
        }

        private void btnupdatemarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatemarca a = new frmupdatemarca();
            a.MdiParent = this;
            a.Show();
        }

        private void btndelmarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmdelmarca a = new frmdelmarca();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_deleteUser delUser = new f_deleteUser();
            delUser.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_Usuarios newuser = new f_Usuarios();
            newuser.MdiParent = this;
            newuser.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ListUsers luser = new f_ListUsers();
            luser.MdiParent = this;
            luser.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnupdatesucursal_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatesucursal a = new frmupdatesucursal();
            a.MdiParent = this;
            a.Show();
        }

        private void btnupdatecate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatecategoria a = new frmupdatecategoria();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            agregarpresentacion a = new agregarpresentacion();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmverpresentacion a = new frmverpresentacion();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmupdatepresentacion a = new frmupdatepresentacion();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmdelpresentacion a = new frmdelpresentacion();
            a.MdiParent = this;
            a.Show();
        }

        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_abonos aC = new f_abonos();
            aC.typeAbono = false;
            aC.MdiParent = this;
            aC.Show();
        }

        private void btnAddAbono_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_abonos aV = new f_abonos();
            aV.MdiParent = this;
            aV.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAsignProducts miAsignacion = new frmAsignProducts();
            miAsignacion.Show();
        }

        private void btnReportSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVentascs miReporte = new frmVentascs();
            miReporte.Show(); 
            
        }

        private void btnTop10Sales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraFormTop10Ventas frmTop10 = new XtraFormTop10Ventas();
            frmTop10.MdiParent = this;
            frmTop10.Show();
        }

        private void btnAgregarPresentacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAsignarPrecio a = new frmAsignarPrecio();
            a.MdiParent = this;
            a.Show();
        }

        private void btnVerPrecios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVerPrecioAsignado a = new frmVerPrecioAsignado();
            a.MdiParent = this;
            a.Show();
        }

        private void btnmodificarAsignacionPrecio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUpdateAsignacion a = new frmUpdateAsignacion();
            a.MdiParent = this;
            a.Show();
        }

        private void btneliminarasignacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDelAsignacionprecio a = new frmDelAsignacionprecio();
            a.MdiParent = this;
            a.Show();
        }

        private void btnNewCaja_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Deshabilitamos el boton para evitar que genere datos erroneos en inicio de caja.
            btnNewCaja.Enabled = false;
            //Tomamos el tiempo del sistema.
            

        }
    }
}
