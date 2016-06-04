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
    class Validaciones
    {
        public void limpiarCampos(Form validar)
        {
            foreach (Control ctrl in validar.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        public bool validarCampos(Form validar)
        {
            bool vacio = false;
            foreach (Control ctrl in validar.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == "")
                {
                    ctrl.BackColor = Color.Red;
                    vacio = true;
                }
            }
            return vacio;
        }

        public void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }
    }
}
