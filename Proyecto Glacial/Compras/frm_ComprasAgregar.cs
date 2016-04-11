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

namespace Proyecto_Glacial.Compras
{
    public partial class frm_ComprasAgregar : Form
    {
        generarConexion Conexion = new generarConexion();
        public int idCompra;
        string unidad_medida;
        public int idProducto2;
        public int cantidad2;
        public double total2;
        public string nombre;
        public string tipoPago;
        public double totalCompra;

       
        public frm_ComprasAgregar()
        {
            

            InitializeComponent();
        }
        public int regresarIdDeCompraActual()
        {
            MySqlCommand consulta = new MySqlCommand("SELECT MAX(`id_compra`) FROM compras", generarConexion.obtenerConexion);
            Conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        idCompra = 1;
                        Conexion.cerrarConexion();
                        return idCompra;
                    }
                    else
                    { 
                        idCompra = lector.GetInt32(0);
                        Conexion.cerrarConexion();
                        return idCompra;
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
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            switch (cmbTipoPago.Text)
            {
                case "Efectivo":
                    tipoPago = "efectivo";
                    break;
                case "Crédito":
                    tipoPago = "credito";
                    break;
                case "Cheque":
                    tipoPago = "cheque";
                    break;
            }
            regresarIdDeCompraActual();
        
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)//Ciclo para agregar la Lista
            {
                idProducto2 = Convert.ToInt32(dataGridView1.Rows[i].Cells["idProducto"].Value);
                cantidad2 = Convert.ToInt32(dataGridView1.Rows[i].Cells["cantidad"].Value);
                unidad_medida = dataGridView1.Rows[i].Cells["unidadMedida"].Value.ToString();
                total2 = Convert.ToDouble(dataGridView1.Rows[i].Cells["total"].Value);
                totalCompra += total2;
                nombre = dataGridView1.Rows[i].Cells["nombreProducto"].Value.ToString();

                this.lista_material_comprasTableAdapter.InsertarNuevaCompra(idCompra + 1, total2, cantidad2, idProducto2, unidad_medida,nombre);
                
               // MessageBox.Show(valor1.ToString());
            }
            this.comprasTableAdapter.InsertarNuevaCompra(DateTime.Now, tipoPago, 1, totalCompra);
            MessageBox.Show("Venta registrada con éxito!", "Exito" ,MessageBoxButtons.OK);
            this.Close();

        }

        private void lista_material_comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lista_material_comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ComprasMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_material_compras' Puede moverla o quitarla según sea necesario.
            //this.lista_material_comprasTableAdapter.Fill(this.glacial_almacenDataSet.lista_material_compras);

        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_finalizar.Enabled = true;
        }
    }
}
