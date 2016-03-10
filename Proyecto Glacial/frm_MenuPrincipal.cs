using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form FormularioClientes = new frm_ClientesMenu();
            FormularioClientes.Show();

        }
    }
}
