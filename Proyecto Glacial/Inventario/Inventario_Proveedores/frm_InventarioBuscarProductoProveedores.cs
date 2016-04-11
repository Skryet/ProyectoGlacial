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

namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    public partial class frm_InventarioBuscarProductoProveedores : Form
    {
        private generarConexion conexion = new generarConexion();
        private MySqlDataAdapter da;


        //Formulario para agregar más Productos de difernete proveedor
        private frm_InventarioAgregarDatosProveedoProducto frm_InventarioDatosProveedorProducto = new frm_InventarioAgregarDatosProveedoProducto();

        //Formulario de modificar Productos de Proveedores
        private frm_InventarioModificarDatosProveedorProducto frm_ModificarDatosProveedorProducto = new frm_InventarioModificarDatosProveedorProducto();
        public frm_InventarioBuscarProductoProveedores()
        {
            InitializeComponent();
        }

        private void frm_InventarioBuscarProductoProveedores_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 100);

            //Visualizacion de datos e IMAGEN
            MySqlCommand consulta = new MySqlCommand("SELECT imagen FROM productos WHERE id_producto =  " + Program.idProducto, generarConexion.obtenerConexion);
            da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);

            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto,Program.idProducto);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            btn_agregar.Enabled = false;
            frm_InventarioDatosProveedorProducto.ShowDialog();
        }

        private void frm_InventarioBuscarProductoProveedores_Activated(object sender, EventArgs e)
        {
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto, Program.idListaProveedorActual);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea Eliminar este proveedor del producto? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro Eliminado con éxito!");
                this.proveedor_codigoTableAdapter.BorrarProveedorCodigoPorID(Program.idProveedorCodigo);
                this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto, Program.idListaProveedorActual);
            }
        }

        private void vista_listar_proveedores_productoDataGridView_Click(object sender, EventArgs e)
        {
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
            Program.idProveedorCodigo = Convert.ToInt32(vista_listar_proveedores_productoDataGridView.SelectedCells[1].Value.ToString());
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            frm_ModificarDatosProveedorProducto.ShowDialog();
        }

        private void frm_InventarioBuscarProductoProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_agregar.Enabled = true;
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand("SELECT compatibilidadCarros FROM productos WHERE id_producto = " +  Program.idProducto, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    MessageBox.Show(lector.GetString(0).ToString(),"Este carro tiene compatibilidad con: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }
    }
}
