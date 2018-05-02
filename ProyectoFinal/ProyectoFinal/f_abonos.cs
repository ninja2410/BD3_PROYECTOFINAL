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
    public partial class f_abonos : DevExpress.XtraEditors.XtraForm
    {
        public bool typeAbono = true;
        int idCredit;
        DataAccess da = new DataAccess();
        // Abono de venta = true;
        // Abono de compra = false;

        public f_abonos()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //textEdit2.Properties.Mask.EditMask = "N2";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            idCredit = Convert.ToInt32(txtIdCredit.Text);
            int idDeudor;
            int typeCuenta;
            string sQuery;
            try
            {
                sQuery = "SELECT * FROM tblCreditos where id_creditos = " + idCredit + " ;";
                DataTable dt = da.fillDataTable(sQuery);
                if (dt.Rows.Count > 0)
                {
                    idDeudor = Convert.ToInt32(dt.Rows[0]["deudor"]);
                    typeCuenta = Convert.ToInt16(dt.Rows[0]["tipo_cuenta"]);
                    if (!typeAbono && (typeCuenta == 0) )
                    {
                        sQuery = "SELECT * FROM tblProveedor where id_proveedor = " + idDeudor + " ;";
                        DataTable dtDeudor = da.fillDataTable(sQuery);
                        if (dtDeudor.Rows.Count > 0)
                        {
                            lblDeudorTitle.Text = "DATOS DEL PROVEEDOR";
                            lblInfoDeudor.Text = "Proveedor: " + Convert.ToString(dtDeudor.Rows[0]["nombre_proveedor"]) + "\n";
                            lblInfoDeudor.Text += "NIT: " + Convert.ToString(dtDeudor.Rows[0]["nit"]) + "\n";
                            lblInfoDeudor.Text += "Telefono: " + Convert.ToString(dtDeudor.Rows[0]["telefono"]) + "\n";
                            lblInfoDeudor.Text += "Contacto: " + Convert.ToString(dtDeudor.Rows[0]["contacto"]) + "\n";
                            btnPago.Enabled = true;
                            textEdit2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El codigo de CREDITO DE COMPRA no existe, porfavor verifique.");
                            txtIdCredit.Focus();
                        }
                    }
                    else if(typeAbono && (typeCuenta == 1))
                    {
                        sQuery = "SELECT * FROM tblCliente where id_cliente= " + idDeudor + " ;";
                        DataTable dtDeudor = da.fillDataTable(sQuery);
                        if (dtDeudor.Rows.Count > 0)
                        {
                            lblDeudorTitle.Text = "DATOS DEL CLIENTE";
                            lblInfoDeudor.Text = "Nombre: " + Convert.ToString(dtDeudor.Rows[0]["nombre"]) + " "+ Convert.ToString(dtDeudor.Rows[0]["apellido"]) + "\n";
                            lblInfoDeudor.Text += "NIT: " + Convert.ToString(dtDeudor.Rows[0]["nit"]) + "\n";
                            lblInfoDeudor.Text += "Telefono: " + Convert.ToString(dtDeudor.Rows[0]["telefono"]) + "\n";
                            btnPago.Enabled = true;
                            textEdit2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El codigo de CREDITO DE VENTA no existe, porfavor verifique.");
                            txtIdCredit.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El codigo de CREDITO no existe o no corresponde al tipo de pago.");
                        txtIdCredit.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El codigo de CREDITO no existe, porfavor verifique.");
                    txtIdCredit.Focus();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión. Más detalles: " + ex.Message);
            }
        }

        private void txtIdCredit_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void f_abonos_Load(object sender, EventArgs e)
        {
            textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit2.Properties.Mask.EditMask = "N2";
            txtIdCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtIdCredit.Properties.Mask.EditMask = "D";
            btnPago.Enabled = false;
            textEdit2.Enabled = false;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                string insertAbono, updateCredit;
                string dateTime = DateTime.Now.ToString();
                string createddate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");

                insertAbono = "INSERT INTO tblAbonos(id_creditos, monto, fecha_pago) VALUES ({0},{1},'{2}');";
                insertAbono = string.Format(insertAbono,idCredit,Convert.ToDecimal(textEdit2.Text),createddate);
                da.executeCommand(insertAbono);

                updateCredit = "UPDATE tblCreditos SET  monto = (monto - {0}) where id_creditos = {1};";
                updateCredit = string.Format(updateCredit, Convert.ToDecimal(textEdit2.Text), idCredit);
                da.executeCommand(updateCredit);

                MessageBox.Show("Se ha registrado el abono con exito.");

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión. Más detalles: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cancelar?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}