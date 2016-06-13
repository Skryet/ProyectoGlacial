namespace Proyecto_Glacial.Clientes.Credito
{
    partial class frm_Creditos
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
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.clm_IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TieneCredito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clm_LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DiasCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_CreditoUsuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_FechaExpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clientes
            // 
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
            this.dgv_Clientes.Location = new System.Drawing.Point(180, 114);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(958, 359);
            this.dgv_Clientes.TabIndex = 0;
            // 
            // clm_IdCliente
            // 
            this.clm_IdCliente.HeaderText = "ID";
            this.clm_IdCliente.Name = "clm_IdCliente";
            this.clm_IdCliente.ReadOnly = true;
            this.clm_IdCliente.Width = 43;
            // 
            // clm_nombre
            // 
            this.clm_nombre.HeaderText = "Nombre";
            this.clm_nombre.Name = "clm_nombre";
            this.clm_nombre.ReadOnly = true;
            this.clm_nombre.Width = 69;
            // 
            // clm_TieneCredito
            // 
            this.clm_TieneCredito.HeaderText = "Credito";
            this.clm_TieneCredito.Name = "clm_TieneCredito";
            this.clm_TieneCredito.ReadOnly = true;
            this.clm_TieneCredito.Width = 46;
            // 
            // clm_LimiteCredito
            // 
            this.clm_LimiteCredito.HeaderText = "Limite Credito";
            this.clm_LimiteCredito.Name = "clm_LimiteCredito";
            this.clm_LimiteCredito.ReadOnly = true;
            this.clm_LimiteCredito.Width = 87;
            // 
            // clm_DiasCredito
            // 
            this.clm_DiasCredito.HeaderText = "Dias de Credito";
            this.clm_DiasCredito.Name = "clm_DiasCredito";
            this.clm_DiasCredito.ReadOnly = true;
            this.clm_DiasCredito.Width = 96;
            // 
            // clm_CreditoUsuado
            // 
            this.clm_CreditoUsuado.HeaderText = "Credito Usado";
            this.clm_CreditoUsuado.Name = "clm_CreditoUsuado";
            this.clm_CreditoUsuado.ReadOnly = true;
            this.clm_CreditoUsuado.Width = 91;
            // 
            // clm_FechaExpiracion
            // 
            this.clm_FechaExpiracion.HeaderText = "Fecha de Expiración";
            this.clm_FechaExpiracion.Name = "clm_FechaExpiracion";
            this.clm_FechaExpiracion.ReadOnly = true;
            this.clm_FechaExpiracion.Width = 118;
            // 
            // frm_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 485);
            this.Controls.Add(this.dgv_Clientes);
            this.Name = "frm_Creditos";
            this.Text = "frm_Creditos";
            this.Load += new System.EventHandler(this.frm_Creditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);

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
    }
}