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
        Form FRM_inventarioAgregarProductosProveedor = new Inventario.Inventario_Proveedores.frm_InventarioAgregarDatosProveedoProducto();

        //Consulta la vista
        //public int 
        //Consulta para buscar el ultimo de la lista
        public int buscarUltimoIdLista()
        { 

            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT MAX(`id_lista_proveedores`) FROM proveedor_codigo", generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {

                MySqlDataReader lector = consulta.ExecuteReader();

                    while(lector.Read())
                    {
                    if(lector.GetValue(0).ToString() == "")
                    {
                        ultimoIdExistente = 1;
                        return ultimoIdExistente;
                    }
                    else
                    {
                        ultimoIdExistente = lector.GetInt32(0);
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;
                    }
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
            btn_agregar.Enabled = false;
           // Program.idListaProveedorActual = buscarUltimoIdLista();
            //Program.idListaProveedorActual++;
            btn_completar.Enabled = true;
            FRM_inventarioAgregarProductosProveedor.ShowDialog();
        }

        private void frm_InventarioAgregarProductosProveedor_Activated_1(object sender, EventArgs e)
        {
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto,Program.idListaProveedorActual);
        }

        private void frm_InventarioAgregarProductosProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto, 0);
            Program.agregarProveedoresProducto = true;
            

        }

        private void btn_completar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_InventarioAgregarProductosProveedor_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 40);
        }
    }
}
