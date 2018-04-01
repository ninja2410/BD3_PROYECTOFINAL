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
    public partial class frmNewProvider : Form
    {
       
        public frmNewProvider()
        {
            InitializeComponent();
        }

        private void txtNameProvider_Enter(object sender, EventArgs e)
        {
            if(txtNameProvider.Text== "Escriba el nombre del proveedor")
            {
                txtNameProvider.Text = "";
                txtNameProvider.ForeColor = Color.Black;
            }
        }

        private void txtNameProvider_Leave(object sender, EventArgs e)
        {
            if (txtNameProvider.Text == "")
            {
                txtNameProvider.Text = "Escriba el nombre del proveedor";
                txtNameProvider.ForeColor = Color.Gray;
            }

        }

        private void txtPhoneProvider_Enter(object sender, EventArgs e)
        {
            if(txtPhoneProvider.Text== "Telefono del Proveedor")
            {
                txtPhoneProvider.Text="";
                txtPhoneProvider.ForeColor = Color.Black;
            }
        }

        private void txtPhoneProvider_Leave(object sender, EventArgs e)
        {
            if (txtPhoneProvider.Text == "")
            {
                txtPhoneProvider.Text="Telefono del Proveedor";
                txtPhoneProvider.ForeColor = Color.Gray;
            }
        }

        private void txtNitProvider_Enter(object sender, EventArgs e)
        {
            if(txtNitProvider.Text== "NIT del Proveedor")
            {
                txtNitProvider.Text = "";
                txtNitProvider.ForeColor = Color.Black;
            }
        }

        private void txtNitProvider_Leave(object sender, EventArgs e)
        {
            if (txtNitProvider.Text == "")
            {
                txtNitProvider.Text = "NIT del Proveedor";
                txtNitProvider.ForeColor = Color.Gray;
            }
        }

        private void txtContactProvider_Enter(object sender, EventArgs e)
        {
            if(txtContactProvider.Text== "E-mail del Proveedor")
            {
                txtContactProvider.Text = "";
                txtContactProvider.ForeColor = Color.Black;
            }
        }

        private void txtContactProvider_Leave(object sender, EventArgs e)
        {
            if (txtContactProvider.Text == "")
            {
                txtContactProvider.Text = "E-mail del Proveedor";
                txtContactProvider.ForeColor = Color.Gray;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameProvider_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Esciba el nombre del proveedor a ingresar", txtNameProvider);
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string nit = txtNitProvider.Text;
            string nombre = txtNameProvider.Text;
            string telefono = txtPhoneProvider.Text;
            string contacto = txtContactProvider.Text;
            bool state =  chkProvider.Checked;

            string sCommand = "insert into tblProveedor(nit,nombre_proveedor,telefono,contacto,activo) ";
            sCommand += "values('{0}','{1}','{2}','{3}',{4})";
            sCommand = string.Format(sCommand, nit, nombre,telefono,contacto, Convert.ToByte( state ));
            try
            {
                da.executeCommand(sCommand);
                MessageBox.Show("Proveedor almacenado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to try add a new Provider: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
