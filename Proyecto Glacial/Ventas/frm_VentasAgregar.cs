using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas
{
    public partial class frm_VentasAgregar : Form
    {
        public frm_VentasAgregar()
        {
            InitializeComponent();
        }

        private void frm_VentasAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.vista_venta_lista_productos' Puede moverla o quitarla según sea necesario.
            this.vista_venta_lista_productosTableAdapter.Fill(this.glacial_almacenDataSet.vista_venta_lista_productos);

        }
    }
}
