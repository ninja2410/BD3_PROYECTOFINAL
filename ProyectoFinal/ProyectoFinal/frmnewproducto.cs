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
    public partial class frmnewproducto : Form
    {
        public frmnewproducto()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void agregar()
        {
           
            
                #region validaciones

                if (textEdit2.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Debe Llenar Este Campo Para Guardarlo");
                    textEdit2.Focus();

                }

                else if (textEdit1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Debe Llenar Este Campo Para Guardarlo");
                    textEdit1.Focus();

                }
                else if (dateTimePicker1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Debe Llenar Este Campo Para Guardarlo");
                dateTimePicker1.Focus();

                }
                else if (textEdit3.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Debe Llenar Este Campo Para Guardarlo");
                    textEdit3.Focus();

                }
                else
                {
                    #endregion

                    string nombre, codigo,descripcion,codigo_pro;
                string activo;
                string f_caducidad;
                    int marca, categoria;
                    
                    nombre = textEdit1.Text;
                    codigo = textEdit3.Text;
                    descripcion = textEdit2.Text;
                    f_caducidad = dateTimePicker1.Text;
                f_caducidad= dateTimePicker1.Text;
                MessageBox.Show(f_caducidad);
               f_caducidad= f_caducidad.Replace('/', '-');
                MessageBox.Show(f_caducidad);
               
                   categoria =  Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cod Categoria"));
                    marca = Convert.ToInt32(gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "Cod Marca"));
                codigo_pro = textEdit4.Text;
                if (checkEdit1.Checked)
                {
                    activo = "1";
                }
                else
                { activo = "0"; }
                string sCommand;
                    

                    sCommand = "insert into tblproducto(id_producto,nombre_producto,codigo_barras,activo,descripcion,f_caducidad,id_marca,id_categoria) ";
                    sCommand += "values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}')";
                sCommand = string.Format(sCommand, codigo_pro, nombre, codigo, Convert.ToByte(activo), descripcion, f_caducidad, marca,categoria);
                    try
                    {
                        da.executeCommand(sCommand);
                        MessageBox.Show("Se Ingreso El Producto " + nombre + " Con Exito");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar ingresar un nuevo Producto, más detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Esta seguro que desea Ingresar este Producto?", "Cancelar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) { agregar(); } else if (dialog == DialogResult.No) { }
        }
        void cargar_cat()
        {
            string query = "SELECT id_categoria as 'Cod Categoria',nombre_categoria as 'Nombre Categoria' FROM tblcategoria "; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView1.Columns.Clear();
            gridControl1.DataSource = dt;
        }
        void cargar_marcas()
        {
            string query = "SELECT id_marca as 'Cod Marca', nombre_marca as 'Nombre Marca' FROM tblmarca "; //Consulta que se enviara al servidor de la base
            DataTable dt = new DataTable();           // creando una nueva tabla
            dt = da.fillDataTable(query); //Obteniendo los datos para llenar la tabla de clientes registrados
            gridView2.Columns.Clear();
            gridControl2.DataSource = dt;
        }
        private void frmnewproducto_Load(object sender, EventArgs e)
        {
            cargar_cat();
            cargar_marcas();
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureEdit1.Image = Image.FromFile(imagen);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
