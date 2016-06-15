using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial.Clientes.Credito.Consultas
{
    class autocompletado_clientes
    {
        private DataGridView ListaClientes;
        private generarConexion conexion = new generarConexion();

        public autocompletado_clientes(ref DataGridView clientes)
        {
            ListaClientes = clientes;
        }

        public void AgregarClientesNombre(string nombre)
        {
            string comando = "SELECT id_cliente, nombre"
                + " FROM clientes WHERE nombre LIKE '%" + nombre + "%' AND tiene_credito = 1;";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())                
                    ListaClientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1));                
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }

        public void AgregarClientesCodigo(string codigo)
        {
            string comando = "SELECT id_cliente, nombre"
                + " FROM clientes WHERE nombre LIKE '%" + codigo + "%' AND tiene_credito = 1;";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                    ListaClientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1));
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }
    }
}
