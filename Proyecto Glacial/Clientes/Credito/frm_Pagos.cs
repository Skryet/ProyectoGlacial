using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Clientes.Credito
{
    public partial class frm_Pagos : Form
    {
        private frm_AutocompletadoClientes autocompletar;

        public frm_Pagos()
        {
            InitializeComponent();
        }

        private void txt_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoClientes") != false)
                    {
                        abierto.Close();
                    }
                }                
                if (cbx_TipoBusqueda.SelectedItem.ToString() == "Nombre/Razón Social")
                {                            
                    Point localizacion = txt_Cliente.Location;
                    Form activeform = Form.ActiveForm;
                    autocompletar = new frm_AutocompletadoClientes(txt_Cliente.Text, "nombre", localizacion, ref lbl_CodigoCliente, ref lbl_NombreRazonSocial, ref lbl_SaldoDeuda, ref lbl_FechaExpiracion);
                    autocompletar.Show(this);
                    activeform.BringToFront();
                }
                else if (cbx_TipoBusqueda.SelectedItem.ToString() == "No. de Cliente")
                {
                    Point localizacion = txt_Cliente.Location;
                    Form activeform = Form.ActiveForm;
                    autocompletar = new frm_AutocompletadoClientes(txt_Cliente.Text, "codigo", localizacion, ref lbl_CodigoCliente, ref lbl_NombreRazonSocial, ref lbl_SaldoDeuda, ref lbl_FechaExpiracion);
                    autocompletar.Show(this);
                    activeform.BringToFront();
                }
            }
            if (txt_Cliente.Text == "")
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoClientes") != false)
                    {
                        abierto.Close();
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoClientes") != false)
                    {
                        abierto.Close();
                    }
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarReferencia(object sender, EventArgs e)
        {
            if (rbt_TarjetaCredito.Checked)
                txt_Referencia.Enabled = true;
            else if (rbt_TarjetaDebito.Checked)
                txt_Referencia.Enabled = true;
            else if (rbt_Cheque.Checked)
                txt_Referencia.Enabled = true;
            else
                txt_Referencia.Enabled = false;
        }
    }
}
