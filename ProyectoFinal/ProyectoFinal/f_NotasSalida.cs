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
    public partial class f_NotasSalida : f_Plantilla
    {
        public int sucursal, empleado;
        public bool entrada;
        public f_NotasSalida()
        {
            InitializeComponent();
        }

        private void f_Notas_Load(object sender, EventArgs e)
        {
            if (entrada == true)
            {
                lblTitulo.Text = "Notas de Salida";
            }
            else
            {
                lblTitulo.Text = "Notas de Entrada";
            }
            
        }

    }
}
