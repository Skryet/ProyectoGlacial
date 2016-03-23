﻿using System;
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

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioAgregar_Load(object sender, EventArgs e)
        {
            btn_AgregarProveedor.Enabled = true;
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_proveedores_productos' Puede moverla o quitarla según sea necesario.
            //this.lista_proveedores_productosTableAdapter.Fill(this.glacial_almacenDataSet.lista_proveedores_productos);            
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Program.idListaProveedorActual = buscarUltimoIdLista();
            Program.idListaProveedorActual++;
            Form frm_AgregarProveedorProducto = new Inventario.Inventario_Proveedores.frm_InventarioAgregarProductosProveedor();
            frm_AgregarProveedorProducto.Show();
            btn_AgregarProveedor.Enabled = false;
            
        }

        private void btn_proveedoresAgregado_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                banderaRealizarPeticionFinal = true;
                Program.agregarProveedoresProducto = false;
                btn_Guardar.Enabled = false;
                this.productosTableAdapter.InsertarProductosConProveedores(Convert.ToInt32(txt_lineaProducto.Text),
                    Program.idListaProveedorActual, txt_nombre.Text, txt_descripcion.Text, Convert.ToInt32
                    (txt_existencia.Text), Convert.ToInt32(txt_cantidadMinima.Text), txt_unidadMedida.Text,
                    Convert.ToDouble(txt_precio1.Text), Convert.ToDouble(txt_precio2.Text),
                    Convert.ToDouble(txt_precio3.Text),img);
                this.lista_proveedores_productosTableAdapter.InsertarListaNuevaDeProveedoresProductos();
                var resultado = MessageBox.Show("Producto Registrado con Éxito, ¿Desea Agregar otro Producto ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    this.Close();
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

        private void txt_precio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void frm_InventarioAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.idListaProveedorActual = 0;
            Program.idProveedor = 0;
            Program.nombreProveedor = "";
            
        }

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDecimal(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
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
    }
}