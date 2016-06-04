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
using System.IO;

namespace Proyecto_Glacial.Inventario
{
    public partial class frm_InventarioAgregar : Form
    {
        public int codigoActualLinea = 0;
        generarConexion Conexion = new generarConexion();
        public int buscarUltimoIdLista()
        {

            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT MAX(`id_lista_proveedores`) FROM proveedor_codigo", generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {

                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
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
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            return 0;
        }

        bool banderaRealizarPeticionFinal = false;

        //Despintar texto
        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }

        //Validar Campos
        private bool validarCampos()
        {
            bool vacio = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == "")
                {
                    ctrl.BackColor = Color.Red;
                    vacio = true;
                }
            }
            return vacio;

        }
        private void habilitarTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
            }
        }
        public frm_InventarioAgregar()
        {
            InitializeComponent();
        }       

        private void frm_InventarioAgregar_Load(object sender, EventArgs e)
        {
            buscarLineas();
            this.Location = new Point(300, 30);
            btn_AgregarProveedor.Enabled = true;
            regresarTodos();          
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Program.idListaProveedorActual = buscarUltimoIdLista();
            Program.idListaProveedorActual++;
            Form frm_AgregarProveedorProducto = new Inventario.Inventario_Proveedores.frm_InventarioAgregarProductosProveedor();
            frm_AgregarProveedorProducto.ShowDialog();
            btn_AgregarProveedor.Enabled = false;            
        }

        private int buscarUltimoCodigo()
        {            
            int ultimoIdExistente = 0;
            MySqlCommand consulta = new MySqlCommand("SELECT MAX(linea_producto_codigo)FROM productos WHERE nombre = " + "'" + txt_nombre.Text + "'", generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        ultimoIdExistente = 1;
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;
                    }
                    else
                    {
                        ultimoIdExistente = lector.GetInt32(0);
                        Conexion.cerrarConexion();
                        return ultimoIdExistente + 1;
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

        private void buscarLineas()
        {
            cmb_modelo.Text = "";
            MySqlCommand consulta = new MySqlCommand("SELECT DISTINCT nombre FROM productos", generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    txt_nombre.Items.Add(lector.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            Conexion.abrirConexion();
            consulta = new MySqlCommand("SELECT DISTINCT marcaCarro FROM productos", generarConexion.obtenerConexion);
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    cmb_marca.Items.Add(lector.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexion.cerrarConexion();
        }    

        private void btn_proveedoresAgregado_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            if (!validarCampos())
            {
                MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    img = ms.ToArray();
                    banderaRealizarPeticionFinal = true;
                    Program.agregarProveedoresProducto = false;
                    btn_Guardar.Enabled = false;                
                this.productosTableAdapter.InsertarProductosConProveedores((txt_lineaProducto.Text).ToString() + codigoActualLinea.ToString("#000#"),
                        Program.idListaProveedorActual, txt_nombre.Text, txt_descripcion.Text, Convert.ToInt32
                        (txt_existencia.Text), Convert.ToInt32(txt_cantidadMinima.Text), txt_unidadMedida.Text,
                        Convert.ToDouble(txt_precio1.Text), Convert.ToDouble(txt_precio2.Text),
                        Convert.ToDouble(txt_precio3.Text),img,cmb_marca.Text, 
                        txt_año.Text, cmb_modelo.Text ,(txt_numeroPedimento.Text),
                        Convert.ToDouble(txt_precioEspecial.Text),txt_compatibilidad.Text,
                        Convert.ToDouble(txt_precio.Text),codigoActualLinea,txt_detallesProveedor.Text);
                    this.lista_proveedores_productosTableAdapter.InsertarListaNuevaDeProveedoresProductos();
                    var resultado = MessageBox.Show("Producto Registrado con Éxito, ¿Desea Agregar otro Producto ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                        Form frmAgregar = new Inventario.frm_InventarioAgregar();
                        frmAgregar.ShowDialog();
                    }
                }
            else
                MessageBox.Show("Faltan campos por llenar!", "Advertencia");

        }

        private void frm_InventarioAgregar_Activated(object sender, EventArgs e)
        {
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto,Program.idListaProveedorActual);
        }

        private void frm_InventarioAgregar_MouseEnter(object sender, EventArgs e)
        {
            if(!banderaRealizarPeticionFinal && Program.agregarProveedoresProducto)
            {
                btn_Guardar.Enabled = true;
                this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto, Program.idListaProveedorActual);
                banderaRealizarPeticionFinal = true;
                habilitarTexto();
                btn_AgregarProveedor.Enabled = false;
            }
        }

        private void frm_InventarioAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.idListaProveedorActual = 0;
            Program.idProveedor = 0;
            Program.nombreProveedor = "";
            Program.agregarProveedoresProducto = false;
            banderaRealizarPeticionFinal = true;

        }

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDecimal(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_precio.Text != "")
                {
                    decimal val = Convert.ToDecimal(txt_precio.Text);
                    txt_precio.Text = val.ToString("N2");

                    txt_precio1.Text = ((Convert.ToDouble(txt_precio.Text) * .30) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                    txt_precio2.Text = ((Convert.ToDouble(txt_precio.Text) * .50) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                    txt_precio3.Text = ((Convert.ToDouble(txt_precio.Text) * 1) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                    txt_precioEspecial.Text = ((Convert.ToDouble(txt_precio.Text) * .10) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                }
            }
        }

        private void regresarTodos()
        {
            cmb_modelo.Text = "";
            MySqlCommand consulta = new MySqlCommand("SELECT DISTINCT modeloCarro FROM productos", generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    cmb_modelo.Items.Add(lector.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            Conexion.abrirConexion();
            consulta = new MySqlCommand("SELECT DISTINCT marcaCarro FROM productos", generarConexion.obtenerConexion);
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    cmb_marca.Items.Add(lector.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexion.cerrarConexion();
        }


        private void btn_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose image(*.jpg; *png; *.gif)|*.jpg; *.png; *.gif)";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            if(txt_precio.Text != "")
            { 
            decimal val = Convert.ToDecimal(txt_precio.Text);
                txt_precio.Text = val.ToString("N2");

                txt_precio1.Text = ((Convert.ToDouble(txt_precio.Text) * .30) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precio2.Text = ((Convert.ToDouble(txt_precio.Text) * .50) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precio3.Text = ((Convert.ToDouble(txt_precio.Text) * 1) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precioEspecial.Text = ((Convert.ToDouble(txt_precio.Text) * .10) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            }

        }       
    }

}
