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

     

        private void btnNewProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmNewProvider frmNuevoProveedor = new frmNewProvider();
            //frmNuevoProveedor.ShowDialog();
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
            f_Notas nota = new f_Notas();
            nota.entrada = true;
            nota.MdiParent = this;
            nota.Show();
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
            newuser.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_ListUsers luser = new f_ListUsers();
            luser.ShowDialog();
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
    }
}
