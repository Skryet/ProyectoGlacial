namespace Proyecto_Glacial.Clientes.Credito
{
    partial class frm_AutocompletadoClientes
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
            this.clm_NumeroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clm_NumeroCliente,
            this.clm_Nombre});
            this.dgv_Clientes.Location = new System.Drawing.Point(0, 0);
            this.dgv_Clientes.MultiSelect = false;
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.RowTemplate.Height = 24;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(635, 133);
            this.dgv_Clientes.TabIndex = 0;
            this.dgv_Clientes.DoubleClick += new System.EventHandler(this.dgv_Clientes_DoubleClick);
            // 
            // clm_NumeroCliente
            // 
            this.clm_NumeroCliente.Frozen = true;
            this.clm_NumeroCliente.HeaderText = "No. de Cliente";
            this.clm_NumeroCliente.Name = "clm_NumeroCliente";
            this.clm_NumeroCliente.ReadOnly = true;
            this.clm_NumeroCliente.Width = 116;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.Frozen = true;
            this.clm_Nombre.HeaderText = "Nombre/Razón Social";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            this.clm_Nombre.Width = 159;
            // 
            // frm_AutocompletadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 134);
            this.Controls.Add(this.dgv_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AutocompletadoClientes";
            this.Text = "frm_AutocompletadoClientes";
            this.Load += new System.EventHandler(this.frm_AutocompletadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NumeroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
    }
}