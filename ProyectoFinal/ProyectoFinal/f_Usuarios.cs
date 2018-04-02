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
    public partial class f_Usuarios : DevExpress.XtraEditors.XtraForm
    {
        public f_Usuarios()
        {
            InitializeComponent();
        }

        private void txtFirstName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void f_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Esta seguro que desea cancelar esta acción?", "Cancelar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) { this.Close(); } else if (dialog == DialogResult.No) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region validaciones



            #endregion
        }
    }
}