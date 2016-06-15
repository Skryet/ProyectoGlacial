namespace Proyecto_Glacial.Clientes.Credito
{
    partial class frm_Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_SeleccioneCliente = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.cbx_TipoBusqueda = new System.Windows.Forms.ComboBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_SaldoDeuda = new System.Windows.Forms.Label();
            this.lbl_FechaExpiracion = new System.Windows.Forms.Label();
            this.lbl_Expiracion = new System.Windows.Forms.Label();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.txt_Pago = new System.Windows.Forms.TextBox();
            this.lbl_FormaPago = new System.Windows.Forms.Label();
            this.rbt_Cheque = new System.Windows.Forms.RadioButton();
            this.rbt_TarjetaDebito = new System.Windows.Forms.RadioButton();
            this.rbt_TarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rbt_Efectivo = new System.Windows.Forms.RadioButton();
            this.lbl_Referencia = new System.Windows.Forms.Label();
            this.txt_Referencia = new System.Windows.Forms.TextBox();
            this.btn_RealizarPago = new System.Windows.Forms.Button();
            this.lbl_CodigoCliente = new System.Windows.Forms.Label();
            this.lbl_NoCliente = new System.Windows.Forms.Label();
            this.lbl_NombreRazonSocial = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SeleccioneCliente
            // 
            this.lbl_SeleccioneCliente.AutoSize = true;
            this.lbl_SeleccioneCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_SeleccioneCliente.Location = new System.Drawing.Point(27, 24);
            this.lbl_SeleccioneCliente.Name = "lbl_SeleccioneCliente";
            this.lbl_SeleccioneCliente.Size = new System.Drawing.Size(190, 23);
            this.lbl_SeleccioneCliente.TabIndex = 0;
            this.lbl_SeleccioneCliente.Text = "Seleccione Cliente";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Saldo.Location = new System.Drawing.Point(28, 194);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(71, 23);
            this.lbl_Saldo.TabIndex = 1;
            this.lbl_Saldo.Text = "Saldo:";
            // 
            // cbx_TipoBusqueda
            // 
            this.cbx_TipoBusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cbx_TipoBusqueda.FormattingEnabled = true;
            this.cbx_TipoBusqueda.Items.AddRange(new object[] {
            "No. de Cliente",
            "Nombre/Razón Social"});
            this.cbx_TipoBusqueda.Location = new System.Drawing.Point(31, 63);
            this.cbx_TipoBusqueda.Name = "cbx_TipoBusqueda";
            this.cbx_TipoBusqueda.Size = new System.Drawing.Size(186, 31);
            this.cbx_TipoBusqueda.TabIndex = 2;
            this.cbx_TipoBusqueda.Text = "No. de Cliente";
            this.cbx_TipoBusqueda.UseWaitCursor = true;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Cliente.Location = new System.Drawing.Point(223, 63);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(433, 31);
            this.txt_Cliente.TabIndex = 3;
            this.txt_Cliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cliente_KeyUp);
            // 
            // lbl_SaldoDeuda
            // 
            this.lbl_SaldoDeuda.AutoSize = true;
            this.lbl_SaldoDeuda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_SaldoDeuda.Location = new System.Drawing.Point(105, 194);
            this.lbl_SaldoDeuda.Name = "lbl_SaldoDeuda";
            this.lbl_SaldoDeuda.Size = new System.Drawing.Size(64, 23);
            this.lbl_SaldoDeuda.TabIndex = 4;
            this.lbl_SaldoDeuda.Text = "$0.00";
            // 
            // lbl_FechaExpiracion
            // 
            this.lbl_FechaExpiracion.AutoSize = true;
            this.lbl_FechaExpiracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_FechaExpiracion.Location = new System.Drawing.Point(248, 238);
            this.lbl_FechaExpiracion.Name = "lbl_FechaExpiracion";
            this.lbl_FechaExpiracion.Size = new System.Drawing.Size(45, 23);
            this.lbl_FechaExpiracion.TabIndex = 6;
            this.lbl_FechaExpiracion.Text = "N/A";
            // 
            // lbl_Expiracion
            // 
            this.lbl_Expiracion.AutoSize = true;
            this.lbl_Expiracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Expiracion.Location = new System.Drawing.Point(28, 238);
            this.lbl_Expiracion.Name = "lbl_Expiracion";
            this.lbl_Expiracion.Size = new System.Drawing.Size(214, 23);
            this.lbl_Expiracion.TabIndex = 5;
            this.lbl_Expiracion.Text = "Fecha de Expiración:";
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Pago.Location = new System.Drawing.Point(28, 293);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(186, 23);
            this.lbl_Pago.TabIndex = 7;
            this.lbl_Pago.Text = "Cantidad a Pagar:";
            // 
            // txt_Pago
            // 
            this.txt_Pago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Pago.Location = new System.Drawing.Point(223, 290);
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.Size = new System.Drawing.Size(207, 31);
            this.txt_Pago.TabIndex = 8;
            // 
            // lbl_FormaPago
            // 
            this.lbl_FormaPago.AutoSize = true;
            this.lbl_FormaPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_FormaPago.Location = new System.Drawing.Point(27, 349);
            this.lbl_FormaPago.Name = "lbl_FormaPago";
            this.lbl_FormaPago.Size = new System.Drawing.Size(164, 23);
            this.lbl_FormaPago.TabIndex = 9;
            this.lbl_FormaPago.Text = "Forma de Pago:";
            // 
            // rbt_Cheque
            // 
            this.rbt_Cheque.AutoSize = true;
            this.rbt_Cheque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Cheque.Location = new System.Drawing.Point(607, 392);
            this.rbt_Cheque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_Cheque.Name = "rbt_Cheque";
            this.rbt_Cheque.Size = new System.Drawing.Size(112, 27);
            this.rbt_Cheque.TabIndex = 34;
            this.rbt_Cheque.Text = "Cheque ";
            this.rbt_Cheque.UseVisualStyleBackColor = true;
            this.rbt_Cheque.CheckedChanged += new System.EventHandler(this.cambiarReferencia);
            // 
            // rbt_TarjetaDebito
            // 
            this.rbt_TarjetaDebito.AutoSize = true;
            this.rbt_TarjetaDebito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_TarjetaDebito.Location = new System.Drawing.Point(389, 392);
            this.rbt_TarjetaDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_TarjetaDebito.Name = "rbt_TarjetaDebito";
            this.rbt_TarjetaDebito.Size = new System.Drawing.Size(200, 27);
            this.rbt_TarjetaDebito.TabIndex = 33;
            this.rbt_TarjetaDebito.Text = "Tarjeta de Debito";
            this.rbt_TarjetaDebito.UseVisualStyleBackColor = true;
            this.rbt_TarjetaDebito.CheckedChanged += new System.EventHandler(this.cambiarReferencia);
            // 
            // rbt_TarjetaCredito
            // 
            this.rbt_TarjetaCredito.AutoSize = true;
            this.rbt_TarjetaCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_TarjetaCredito.Location = new System.Drawing.Point(161, 392);
            this.rbt_TarjetaCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_TarjetaCredito.Name = "rbt_TarjetaCredito";
            this.rbt_TarjetaCredito.Size = new System.Drawing.Size(209, 27);
            this.rbt_TarjetaCredito.TabIndex = 31;
            this.rbt_TarjetaCredito.Text = "Tarjeta de Credito";
            this.rbt_TarjetaCredito.UseVisualStyleBackColor = true;
            this.rbt_TarjetaCredito.CheckedChanged += new System.EventHandler(this.cambiarReferencia);
            // 
            // rbt_Efectivo
            // 
            this.rbt_Efectivo.AutoSize = true;
            this.rbt_Efectivo.Checked = true;
            this.rbt_Efectivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Efectivo.Location = new System.Drawing.Point(32, 392);
            this.rbt_Efectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_Efectivo.Name = "rbt_Efectivo";
            this.rbt_Efectivo.Size = new System.Drawing.Size(110, 27);
            this.rbt_Efectivo.TabIndex = 32;
            this.rbt_Efectivo.TabStop = true;
            this.rbt_Efectivo.Text = "Efectivo";
            this.rbt_Efectivo.UseVisualStyleBackColor = true;
            this.rbt_Efectivo.CheckedChanged += new System.EventHandler(this.cambiarReferencia);
            // 
            // lbl_Referencia
            // 
            this.lbl_Referencia.AutoSize = true;
            this.lbl_Referencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Referencia.Location = new System.Drawing.Point(28, 445);
            this.lbl_Referencia.Name = "lbl_Referencia";
            this.lbl_Referencia.Size = new System.Drawing.Size(319, 23);
            this.lbl_Referencia.TabIndex = 35;
            this.lbl_Referencia.Text = "Numero de cuenta / Referencia:";
            // 
            // txt_Referencia
            // 
            this.txt_Referencia.Enabled = false;
            this.txt_Referencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Referencia.Location = new System.Drawing.Point(389, 442);
            this.txt_Referencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Referencia.Name = "txt_Referencia";
            this.txt_Referencia.Size = new System.Drawing.Size(335, 31);
            this.txt_Referencia.TabIndex = 36;
            // 
            // btn_RealizarPago
            // 
            this.btn_RealizarPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_RealizarPago.Location = new System.Drawing.Point(182, 488);
            this.btn_RealizarPago.Name = "btn_RealizarPago";
            this.btn_RealizarPago.Size = new System.Drawing.Size(158, 35);
            this.btn_RealizarPago.TabIndex = 37;
            this.btn_RealizarPago.Text = "Realizar Pago";
            this.btn_RealizarPago.UseVisualStyleBackColor = true;
            // 
            // lbl_CodigoCliente
            // 
            this.lbl_CodigoCliente.AutoSize = true;
            this.lbl_CodigoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_CodigoCliente.Location = new System.Drawing.Point(178, 114);
            this.lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            this.lbl_CodigoCliente.Size = new System.Drawing.Size(0, 23);
            this.lbl_CodigoCliente.TabIndex = 39;
            // 
            // lbl_NoCliente
            // 
            this.lbl_NoCliente.AutoSize = true;
            this.lbl_NoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_NoCliente.Location = new System.Drawing.Point(27, 114);
            this.lbl_NoCliente.Name = "lbl_NoCliente";
            this.lbl_NoCliente.Size = new System.Drawing.Size(152, 23);
            this.lbl_NoCliente.TabIndex = 38;
            this.lbl_NoCliente.Text = "No. de Cliente:";
            // 
            // lbl_NombreRazonSocial
            // 
            this.lbl_NombreRazonSocial.AutoSize = true;
            this.lbl_NombreRazonSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_NombreRazonSocial.Location = new System.Drawing.Point(258, 153);
            this.lbl_NombreRazonSocial.Name = "lbl_NombreRazonSocial";
            this.lbl_NombreRazonSocial.Size = new System.Drawing.Size(0, 23);
            this.lbl_NombreRazonSocial.TabIndex = 41;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Nombre.Location = new System.Drawing.Point(27, 153);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(225, 23);
            this.lbl_Nombre.TabIndex = 40;
            this.lbl_Nombre.Text = "Nombre/Razón Social:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_Cancelar.Location = new System.Drawing.Point(407, 488);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(158, 35);
            this.btn_Cancelar.TabIndex = 42;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 546);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_NombreRazonSocial);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_CodigoCliente);
            this.Controls.Add(this.lbl_NoCliente);
            this.Controls.Add(this.btn_RealizarPago);
            this.Controls.Add(this.lbl_Referencia);
            this.Controls.Add(this.txt_Referencia);
            this.Controls.Add(this.rbt_Cheque);
            this.Controls.Add(this.rbt_TarjetaDebito);
            this.Controls.Add(this.rbt_TarjetaCredito);
            this.Controls.Add(this.rbt_Efectivo);
            this.Controls.Add(this.lbl_FormaPago);
            this.Controls.Add(this.txt_Pago);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.lbl_FechaExpiracion);
            this.Controls.Add(this.lbl_Expiracion);
            this.Controls.Add(this.lbl_SaldoDeuda);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.cbx_TipoBusqueda);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.lbl_SeleccioneCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SeleccioneCliente;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.ComboBox cbx_TipoBusqueda;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label lbl_SaldoDeuda;
        private System.Windows.Forms.Label lbl_FechaExpiracion;
        private System.Windows.Forms.Label lbl_Expiracion;
        private System.Windows.Forms.Label lbl_Pago;
        private System.Windows.Forms.TextBox txt_Pago;
        private System.Windows.Forms.Label lbl_FormaPago;
        private System.Windows.Forms.RadioButton rbt_Cheque;
        private System.Windows.Forms.RadioButton rbt_TarjetaDebito;
        private System.Windows.Forms.RadioButton rbt_TarjetaCredito;
        private System.Windows.Forms.RadioButton rbt_Efectivo;
        private System.Windows.Forms.Label lbl_Referencia;
        private System.Windows.Forms.TextBox txt_Referencia;
        private System.Windows.Forms.Button btn_RealizarPago;
        private System.Windows.Forms.Label lbl_CodigoCliente;
        private System.Windows.Forms.Label lbl_NoCliente;
        private System.Windows.Forms.Label lbl_NombreRazonSocial;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}