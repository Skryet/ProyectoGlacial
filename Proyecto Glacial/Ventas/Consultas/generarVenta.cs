﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas.Consultas
{
    class generarVenta
    {
        private generarConexion conexion = new generarConexion();

        public bool crearVenta(ref int idVenta, int idClienteVenta, int idEmpresaVenta)
        {
            int seEjecuto = 0;

            MySqlCommand consulta = new MySqlCommand("INSERT INTO ventas (id_cliente, id_empresa) VALUES ('" + idClienteVenta.ToString() + "', '" + idEmpresaVenta.ToString() + "');", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }

            consulta = new MySqlCommand("SELECT MAX(id_venta) AS id FROM ventas;", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                idVenta = lector.GetInt32(0);
            }
            conexion.cerrarConexion();            

        }

        public bool borrarVenta(int idVenta)
        {
            int seEjecuto = 0;            
            MySqlCommand consulta = new MySqlCommand("DELETE FROM ventas WHERE id_venta = " + idVenta.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }            
        }

        public bool borrarMaterialVenta(int idVenta)
        {
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("DELETE FROM lista_material_ventas WHERE id_venta = " + idVenta.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }
        }

        public void agregarProduto(Objetos.materialVenta material)
        {
            MySqlCommand consulta = new MySqlCommand("INSERT INTO lista_material_ventas (id_venta, id_producto, cantidad, unidad_medida, precio_unidad, total) VALUES ('" + material.idlVenta.ToString() + "','" + material.idProducto.ToString() + "','" + material.Cantidad.ToString() + "','" + material.unidadMedida.ToString() + "','" + material.precioUnidad.ToString() + "','" + material.Total.ToString() + "');", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            consulta.ExecuteNonQuery();
        }
    }
}