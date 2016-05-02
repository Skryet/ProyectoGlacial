﻿using MySql.Data.MySqlClient;
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
    public partial class frm_InventarioModificar : Form
    {
        private MySqlDataAdapter da;

        public frm_InventarioModificar()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioModificar_Load(object sender, EventArgs e)
        {


            //Visualizacion de datos e IMAGEN
            MySqlCommand consulta = new MySqlCommand("SELECT imagen FROM productos WHERE id_producto =  " + Program.idProducto, generarConexion.obtenerConexion);
            da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();
            this.productosTableAdapter.FillByBuscarProductoPorID(this.glacial_almacenDataSet.productos, Program.idProducto);

        }

        private void txt_precio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_precio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_precio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void cantidad_minimaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDecimal(object sender, KeyPressEventArgs e, TextBox Te)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            img = ms.ToArray();
            this.productosTableAdapter.ActualizarProductoPorID((txt_lineaProducto.Text).ToString(),
                txt_nombre.Text, txt_descripcion.Text, Convert.ToInt32(txt_existencia.Text),
                Convert.ToInt32(txt_cantidadMinima.Text), txt_unidadMedida.Text,
                Convert.ToDouble(txt_precio1.Text), Convert.ToDouble(txt_precio2.Text),
                Convert.ToDouble(txt_precio3.Text),txt_marcaCarro.Text,txt_anioCarro.Text, txt_modeloCarro.Text
                ,txt_numeroPedimento.Text,Convert.ToDouble(txt_precioEspecial.Text)
                ,txt_compatibilidad.Text,img,Convert.ToDouble(txt_precio.Text),Program.idProducto);
            MessageBox.Show("Registro actualizado con éxito");
            this.Close();
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
            decimal val = Convert.ToDecimal(txt_precio.Text);
            txt_precio.Text = val.ToString("N2");

            txt_precio1.Text = ((Convert.ToDouble(txt_precio.Text) * .30) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precio2.Text = ((Convert.ToDouble(txt_precio.Text) * .50) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precio3.Text = ((Convert.ToDouble(txt_precio.Text) * 1) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precioEspecial.Text = ((Convert.ToDouble(txt_precio.Text) * .10) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
        }
    }
}
