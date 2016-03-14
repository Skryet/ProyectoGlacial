using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    public partial class frm_InventarioAgregarProductosProveedor : Form
    {
        generarConexion Conexion = new generarConexion();
        bool estadoConexion = false;

        bool banderaRealizarPeticionFinal = false;
        Form FRM_inventarioAgregarProductosProveedor = new Inventario.Inventario_Proveedores.frm_InventarioAgregarDatosProveedoProducto();
     
        //Consulta la vista
        //public int 
        //Consulta para buscar el ultimo de la lista
        public int buscarUltimoIdLista()
        {
            int ultimoIdExistente = 0;
            MySqlCommand consulta = new MySqlCommand("SELECT MAX(id_lista_proveedor_producto) FROM lista_proveedores_productos", generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while(lector.Read())
                { 
                    ultimoIdExistente = lector.GetInt32(0);
                    return ultimoIdExistente;
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            return 0;
        }


        public frm_InventarioAgregarProductosProveedor()
        {
            InitializeComponent();
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Program.idListaProveedorActual = buscarUltimoIdLista();
            Program.idListaProveedorActual++;
            MessageBox.Show(Program.idListaProveedorActual.ToString());
            FRM_inventarioAgregarProductosProveedor.Show();
        }

        private void proveedor_codigoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void frm_InventarioAgregarProductosProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.listar_proveedores_producto' Puede moverla o quitarla según sea necesario.
           // this.listar_proveedores_productoTableAdapter.Fill(this.glacial_almacenDataSet.listar_proveedores_producto);


        }

        private void lista_proveedores_productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void frm_InventarioAgregarProductosProveedor_Activated(object sender, EventArgs e)
        {

        }

        private void frm_InventarioAgregarProductosProveedor_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.vista_listar_proveedores_producto' Puede moverla o quitarla según sea necesario.
            //this.vista_listar_proveedores_productoTableAdapter.Fill(this.glacial_almacenDataSet.vista_listar_proveedores_producto);

        }

        private void frm_InventarioAgregarProductosProveedor_Activated_1(object sender, EventArgs e)
        {
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto,Program.idListaProveedorActual);
        }

        private void frm_InventarioAgregarProductosProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.agregarProveedoresProducto = true;
        }
    }
}
