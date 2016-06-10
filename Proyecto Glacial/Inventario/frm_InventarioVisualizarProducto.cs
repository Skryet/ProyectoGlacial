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

        public void buscarPrecios()
        {            
            MySqlCommand consulta = new MySqlCommand("SELECT precio, precio1, precio2, precio3 from productos where id_producto ="
                + "'" + Program.idProducto + "'", generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    precio = lector.GetInt32(0);
                    precio1 = lector.GetInt32(1);
                    precio2 = lector.GetInt32(2);
                    precio3 = lector.GetInt32(3);                                    
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();            
        }

        public void VisualisarCodigoProveedor()        
        {
            string comando = "SELECT nombre_proveedor, codigo"
                + " FROM proveedor_codigo WHERE id_producto = '"+Program.idProducto.ToString()+"';";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    dgv_CodigoProveedor.Rows.Add(lector.GetString(0), lector.GetString(1));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
        }    
      
        private void frm_InventarioVisualizarProducto_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.FillByBuscarProductoPorID(this.glacial_almacenDataSet.productos, Program.idProducto);
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
           
            buscarPrecios();
            string cadena2 = precio1.ToString("N2");
            txt_precio1.Text = cadena2;


            cadena2 = precio2.ToString("N2");
            txt_precio2.Text = cadena2;

            cadena2 = precio3.ToString("N2");
            txt_precio3.Text = cadena2;

            //Cargar codigos de proveedor
            VisualisarCodigoProveedor();

            int consecutivo = Convert.ToInt32(txt_lineaCodigo.Text);
            string cadena = consecutivo.ToString("D4");
            txt_linea.Text =  txt_lineaNombre.Text;

        }
    }
}
