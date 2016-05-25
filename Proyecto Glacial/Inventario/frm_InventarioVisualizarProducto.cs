using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario
{
    public partial class frm_InventarioVisualizarProducto : Form
    {
        public frm_InventarioVisualizarProducto()
        {
            InitializeComponent();
        }

        int precio, precio1, precio2, precio3;
        generarConexion Conexion = new generarConexion();

        private void existenciaTextBox_Leave(object sender, EventArgs e)
        {

        }

        public int buscarPrecios()
        {


            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT precio,precio1,precio2,precio3 from productos where id_producto ="
                + "'" + Program.idProducto + "'", generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {

                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        ultimoIdExistente = 0;
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;

                    }
                    else
                    {
                        precio = lector.GetInt32(0);
                        precio1 = lector.GetInt32(1);
                        precio2 = lector.GetInt32(2);
                        precio3 = lector.GetInt32(3);
                        ultimoIdExistente = lector.GetInt32(1);
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            return 0;
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioVisualizarProducto_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(400, 50);
            MySqlDataAdapter da;
            //Visualizacion de datos e IMAGEN
            MySqlCommand consulta = new MySqlCommand("SELECT imagen FROM productos WHERE id_producto =  " + Program.idProducto, generarConexion.obtenerConexion);
            da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.FillByBuscarProductoPorID(this.glacial_almacenDataSet.productos,Program.idProducto);

            buscarPrecios();
            string cadena2 = precio1.ToString("N2");
            txt_precio1.Text = cadena2;


            cadena2 = precio2.ToString("N2");
            txt_precio2.Text = cadena2;

            cadena2 = precio3.ToString("N2");
            txt_precio3.Text = cadena2;

            
            



            int consecutivo = Convert.ToInt32(txt_lineaCodigo.Text);
            string cadena = consecutivo.ToString("D4");
            txt_linea.Text =  txt_lineaNombre.Text + cadena ;

        }
    }
}
