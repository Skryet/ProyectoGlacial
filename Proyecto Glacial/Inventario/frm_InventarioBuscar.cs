﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario
{
    public partial class frm_InventarioBuscar : Form
    {
       

        //Formulario de lista de Proveedores
        public Inventario.Inventario_Proveedores.frm_InventarioBuscarProductoProveedores frm_BuscarProductoProveedores= new Inventario.Inventario_Proveedores.frm_InventarioBuscarProductoProveedores();
        public frm_InventarioBuscar()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Metodo para hacer la búsqueda
            if (cmb_SelccionarTipo.Text == "Seleccione")
                MessageBox.Show("Seleccione un tipo de búsqueda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                switch (cmb_SelccionarTipo.Text)
                {
                    case "Código":
                            this.productosTableAdapter.FillByBuscarPorCodigo(this.glacial_almacenDataSet.productos,  "%" + (txt_Buscar.Text) + "%");
                            if (productosDataGridView.RowCount == 0)
                                MessageBox.Show("No se encontró un registro con este código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Nombre/Descripción":
                        this.productosTableAdapter.FillByBuscarPorDescripcion(this.glacial_almacenDataSet.productos, "%" + txt_Buscar.Text + "%");
                        if (productosDataGridView.RowCount == 0)
                            MessageBox.Show("No se encontró un registro con esta descripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Línea":
                        this.productosTableAdapter.FillByBuscarProductoLinea(this.glacial_almacenDataSet.productos, "%" + txt_Buscar.Text + "%");
                        if (productosDataGridView.RowCount == 0)
                            MessageBox.Show("No se encontró un registro con esta línea", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            btn_Buscar.Enabled = true;
        }

        private void btn_BuscarTodo_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);
        }

        private void productosDataGridView_Click(object sender, EventArgs e)
        {
            //btn_detalles.Enabled = true;
            if(productosDataGridView.SelectedCells[11].Value.ToString() != "")
            //ListaProveedorActual
            Program.idListaProveedorActual = Convert.ToInt32(productosDataGridView.SelectedCells[14].Value.ToString());

            //IdProducto
            Program.idProducto = Convert.ToInt32(productosDataGridView.SelectedCells[0].Value.ToString());
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            //frm_BuscarProductoProveedores.ShowDialog();
            Form formVisualizar = new frm_InventarioVisualizarProducto();
            formVisualizar.ShowDialog();
        }

        private void productosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.productosDataGridView.Columns[2].DefaultCellStyle.Format = "##00000";
        }

        private void productosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Form formVisualizar = new frm_InventarioVisualizarProducto();
            formVisualizar.ShowDialog();
        }

        private void cmb_SelccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmb_SelccionarTipo.Text == "Seleccione")
                    MessageBox.Show("Seleccione un tipo de búsqueda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    switch (cmb_SelccionarTipo.Text)
                    {
                        case "Código":
                            this.productosTableAdapter.FillByBuscarPorCodigo(this.glacial_almacenDataSet.productos, "%" + (txt_Buscar.Text) + "%");
                            if (productosDataGridView.RowCount == 0)
                                MessageBox.Show("No se encontró un registro con este código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Nombre/Descripción":
                            this.productosTableAdapter.FillByBuscarPorDescripcion(this.glacial_almacenDataSet.productos, "%" + txt_Buscar.Text + "%");
                            if (productosDataGridView.RowCount == 0)
                                MessageBox.Show("No se encontró un registro con esta descripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "Línea":
                            this.productosTableAdapter.FillByBuscarProductoLinea(this.glacial_almacenDataSet.productos, "%" + txt_Buscar.Text + "%");
                            if (productosDataGridView.RowCount == 0)
                                MessageBox.Show("No se encontró un registro con esta línea", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            
        }
    }
}
