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
    public partial class frmupdateproducto : Form
    {
        DataAccess da = new DataAccess();
        public frmupdateproducto()
        {
            InitializeComponent();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            textEdit2.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombre Del Producto"));
            textEdit3.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo De Barras"));
            textEdit4.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo Producto"));

            int activo = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "activo"));
            if (activo == 1)
            {
                checkEdit1.Checked = true;
            }
            else
            {
                checkEdit1.Checked = false;
            }
            textEdit1.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "descripcion"));
            dateEdit1.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Fecha De Caducidad"));
            lookUpEdit1.EditValue= Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo Marca"));
            lookUpEdit2.EditValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo Categoria"));

        }
        void cargar()
        {
            string query = "SELECT id_producto as 'Codigo Producto',nombre_producto as 'Nombre Del Producto', codigo_barras as 'Codigo De Barras', activo,descripcion, f_caducidad as 'Fecha De Caducidad', id_marca as 'Codigo Marca',(select nombre_marca  from tblmarca where id_marca=tblproducto.id_marca) as 'Nombre Marca' , id_categoria as 'Codigo Categoria',(select nombre_categoria  from tblcategoria where id_categoria=tblproducto.id_categoria) as 'Nombre Categoria'   FROM tblproducto "; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView1.Columns.Clear();
            gridControl1.DataSource = dt;
        }
        void cargar_combo1()
        {
            string query = "select id_marca,nombre_marca from tblmarca"; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            lookUpEdit1.Properties.DataSource = dt;
            lookUpEdit1.Properties.DisplayMember = "nombre_marca";
            lookUpEdit1.Properties.ValueMember = "id_marca";


        }
        void mod()
        {
            string cod_producto, nombre_producto, codigo_barras, descripcion, f_caducidad;
            string cod= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Codigo Producto"));

            cod_producto = textEdit4.Text;
            nombre_producto = textEdit2.Text;
            codigo_barras = textEdit3.Text;
            descripcion = textEdit1.Text;
            f_caducidad = dateEdit1.Text;
            string sCommand;
            sCommand = "UPDATE tblproducto SET id_producto='" + cod_producto + "', nombre_producto='" + nombre_producto + "',codigo_barras='" + codigo_barras + "', descripcion='" + descripcion + "', f_caducidad='" + f_caducidad +"' WHERE id_producto='" + cod + "'";

            try
            {
                da.executeCommand(sCommand);
                MessageBox.Show("Se Modifico el Producto " + nombre_producto + " Con Exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar Modificar el producto, más detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void cargar_combo2()
        {
            string query = "select id_categoria,nombre_categoria from tblcategoria"; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            lookUpEdit2.Properties.DataSource = dt;
            lookUpEdit2.Properties.DisplayMember = "nombre_categoria";
            lookUpEdit2.Properties.ValueMember = "id_categoria";


        }
        private void frmupdateproducto_Load(object sender, EventArgs e)
        {
            cargar();
            cargar_combo1();
            cargar_combo2();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Esta seguro que desea Modificar este Producto?", "Cancelar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) { mod(); } else if (dialog == DialogResult.No) { }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
