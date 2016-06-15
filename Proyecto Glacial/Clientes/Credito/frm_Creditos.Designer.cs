namespace Proyecto_Glacial.Clientes.Credito
{
    partial class btn_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_Pago));
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.clm_IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TieneCredito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clm_LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DiasCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CreditoUsuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_FechaExpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbt_MostrarTodo = new System.Windows.Forms.RadioButton();
            this.rbt_CreditosUso = new System.Windows.Forms.RadioButton();
            this.rbt_CreditosSinUso = new System.Windows.Forms.RadioButton();
            this.rbt_CreditosExpirados = new System.Windows.Forms.RadioButton();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_IdCliente,
            this.clm_nombre,
            this.clm_TieneCredito,
            this.clm_LimiteCredito,
            this.clm_DiasCredito,
            this.clm_CreditoUsuado,
            this.clm_FechaExpiracion});
            this.dgv_Clientes.Location = new System.Drawing.Point(42, 137);
            this.dgv_Clientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(1449, 442);
            this.dgv_Clientes.TabIndex = 0;
            // 
            // clm_IdCliente
            // 
            this.clm_IdCliente.HeaderText = "ID";
            this.clm_IdCliente.Name = "clm_IdCliente";
            this.clm_IdCliente.ReadOnly = true;
            this.clm_IdCliente.Width = 50;
            // 
            // clm_nombre
            // 
            this.clm_nombre.HeaderText = "Nombre";
            this.clm_nombre.Name = "clm_nombre";
            this.clm_nombre.ReadOnly = true;
            this.clm_nombre.Width = 87;
            // 
            // clm_TieneCredito
            // 
            this.clm_TieneCredito.HeaderText = "Credito";
            this.clm_TieneCredito.Name = "clm_TieneCredito";
            this.clm_TieneCredito.ReadOnly = true;
            this.clm_TieneCredito.Width = 59;
            // 
            // clm_LimiteCredito
            // 
            this.clm_LimiteCredito.HeaderText = "Limite Credito";
            this.clm_LimiteCredito.Name = "clm_LimiteCredito";
            this.clm_LimiteCredito.ReadOnly = true;
            this.clm_LimiteCredito.Width = 123;
            // 
            // clm_DiasCredito
            // 
            this.clm_DiasCredito.HeaderText = "Dias de Credito";
            this.clm_DiasCredito.Name = "clm_DiasCredito";
            this.clm_DiasCredito.ReadOnly = true;
            this.clm_DiasCredito.Width = 123;
            // 
            // clm_CreditoUsuado
            // 
            this.clm_CreditoUsuado.HeaderText = "Credito Usado";
            this.clm_CreditoUsuado.Name = "clm_CreditoUsuado";
            this.clm_CreditoUsuado.ReadOnly = true;
            this.clm_CreditoUsuado.Width = 117;
            // 
            // clm_FechaExpiracion
            // 
            this.clm_FechaExpiracion.HeaderText = "Fecha de Expiración";
            this.clm_FechaExpiracion.Name = "clm_FechaExpiracion";
            this.clm_FechaExpiracion.ReadOnly = true;
            this.clm_FechaExpiracion.Width = 151;
            // 
            // rbt_MostrarTodo
            // 
            this.rbt_MostrarTodo.AutoSize = true;
            this.rbt_MostrarTodo.Checked = true;
            this.rbt_MostrarTodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_MostrarTodo.Location = new System.Drawing.Point(280, 61);
            this.rbt_MostrarTodo.Name = "rbt_MostrarTodo";
            this.rbt_MostrarTodo.Size = new System.Drawing.Size(157, 27);
            this.rbt_MostrarTodo.TabIndex = 1;
            this.rbt_MostrarTodo.TabStop = true;
            this.rbt_MostrarTodo.Text = "Mostrar todo";
            this.rbt_MostrarTodo.UseVisualStyleBackColor = true;
            this.rbt_MostrarTodo.CheckedChanged += new System.EventHandler(this.FiltroCreditos);
            // 
            // rbt_CreditosUso
            // 
            this.rbt_CreditosUso.AutoSize = true;
            this.rbt_CreditosUso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_CreditosUso.Location = new System.Drawing.Point(489, 61);
            this.rbt_CreditosUso.Name = "rbt_CreditosUso";
            this.rbt_CreditosUso.Size = new System.Drawing.Size(187, 27);
            this.rbt_CreditosUso.TabIndex = 2;
            this.rbt_CreditosUso.Text = "Creditos en Uso";
            this.rbt_CreditosUso.UseVisualStyleBackColor = true;
            this.rbt_CreditosUso.CheckedChanged += new System.EventHandler(this.FiltroCreditos);
            // 
            // rbt_CreditosSinUso
            // 
            this.rbt_CreditosSinUso.AutoSize = true;
            this.rbt_CreditosSinUso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_CreditosSinUso.Location = new System.Drawing.Point(728, 61);
            this.rbt_CreditosSinUso.Name = "rbt_CreditosSinUso";
            this.rbt_CreditosSinUso.Size = new System.Drawing.Size(191, 27);
            this.rbt_CreditosSinUso.TabIndex = 3;
            this.rbt_CreditosSinUso.Text = "Creditos sin Uso";
            this.rbt_CreditosSinUso.UseVisualStyleBackColor = true;
            this.rbt_CreditosSinUso.CheckedChanged += new System.EventHandler(this.FiltroCreditos);
            // 
            // rbt_CreditosExpirados
            // 
            this.rbt_CreditosExpirados.AutoSize = true;
            this.rbt_CreditosExpirados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_CreditosExpirados.Location = new System.Drawing.Point(948, 61);
            this.rbt_CreditosExpirados.Name = "rbt_CreditosExpirados";
            this.rbt_CreditosExpirados.Size = new System.Drawing.Size(218, 27);
            this.rbt_CreditosExpirados.TabIndex = 4;
            this.rbt_CreditosExpirados.Text = "Creditos Expirados";
            this.rbt_CreditosExpirados.UseVisualStyleBackColor = true;
            this.rbt_CreditosExpirados.CheckedChanged += new System.EventHandler(this.FiltroCreditos);
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Pago.Location = new System.Drawing.Point(1347, 104);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(144, 23);
            this.lbl_Pago.TabIndex = 6;
            this.lbl_Pago.Text = "Realizar Pago";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1368, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 85);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 597);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbt_CreditosExpirados);
            this.Controls.Add(this.rbt_CreditosSinUso);
            this.Controls.Add(this.rbt_CreditosUso);
            this.Controls.Add(this.rbt_MostrarTodo);
            this.Controls.Add(this.dgv_Clientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btn_Pago";
            this.Text = "frm_Creditos";
            this.Load += new System.EventHandler(this.frm_Creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clm_TieneCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_LimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DiasCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_CreditoUsuado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_FechaExpiracion;
        private System.Windows.Forms.RadioButton rbt_MostrarTodo;
        private System.Windows.Forms.RadioButton rbt_CreditosUso;
        private System.Windows.Forms.RadioButton rbt_CreditosSinUso;
        private System.Windows.Forms.RadioButton rbt_CreditosExpirados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Pago;
    }
}