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
    public partial class frm_InventarioModificar : Form
    {
        private MySqlDataAdapter da;
        int precio1;
        int precio2;
        int precio3;
        generarConexion Conexion = new generarConexion();
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
                        ultimoIdExistente =lector.GetInt32(0); lector.GetInt32(0);
                        precio1 = lector.GetInt32(1);
                        precio2 = lector.GetInt32(2);
                        precio3 = lector.GetInt32(3);
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

            string cadena2 = buscarPrecios().ToString("N2");
            txt_precio.Text = cadena2;

            cadena2 = precio1.ToString("N2");
            txt_precio1.Text = cadena2;

            cadena2 = precio2.ToString("N2");
            txt_precio2.Text = cadena2;

            cadena2 = precio3.ToString("N2");
            txt_precio3.Text = cadena2;

            VisualisarCodigoProveedor();
        }

  

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
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
            ModificarCodigosProveedor();
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

        private void txt_precio_Leave_1(object sender, EventArgs e)
        {
            decimal val = Convert.ToDecimal(txt_precio.Text);
            txt_precio.Text = val.ToString("N2");

            txt_precio1.Text = ((Convert.ToDouble(txt_precio.Text) * .30) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precio2.Text = ((Convert.ToDouble(txt_precio.Text) * .50) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precio3.Text = ((Convert.ToDouble(txt_precio.Text) * 1) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
            txt_precioEspecial.Text = ((Convert.ToDouble(txt_precio.Text) * .10) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                decimal val = Convert.ToDecimal(txt_precio.Text);
                txt_precio.Text = val.ToString("N2");

                txt_precio1.Text = ((Convert.ToDouble(txt_precio.Text) * .30) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precio2.Text = ((Convert.ToDouble(txt_precio.Text) * .50) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precio3.Text = ((Convert.ToDouble(txt_precio.Text) * 1) + Convert.ToDouble(txt_precio.Text)).ToString("N2");
                txt_precioEspecial.Text = ((Convert.ToDouble(txt_precio.Text) * .10) + Convert.ToDouble(txt_precio.Text)).ToString("N2");

            }
        }

        public void VisualisarCodigoProveedor()
        {
            string comando = "SELECT nombre_proveedor, codigo"
                + " FROM proveedor_codigo WHERE id_producto = '" + Program.idProducto.ToString() + "';";
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

        public void ModificarCodigosProveedor()
        {            
            string consulta = "";
            for (int i = 0; i < dgv_CodigoProveedor.RowCount; i++)
            {
                consulta += "UPDATE proveedor_codigo SET nombre_proveedor ='" + 
                    dgv_CodigoProveedor.Rows[i].Cells[0].Value.ToString() + "', codigo ='" +
                    dgv_CodigoProveedor.Rows[i].Cells[1].Value.ToString() + 
                    "' WHERE id_producto = '" +Program.idProducto.ToString()+ "'; ";
            }
            MySqlCommand agregar = new MySqlCommand(consulta, generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                agregar.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
        }
    }
}
