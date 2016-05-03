namespace Proyecto_Glacial.Ventas
{
    partial class frm_AutocompletadoProductos
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
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.clm_Codifo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Codifo,
            this.clm_Nombre,
            this.clm_Descripcion,
            this.clm_Existencia,
            this.clm_UnidadMedida,
            this.clm_Precio1,
            this.clm_Precio2,
            this.clm_Precio3});
            this.dgv_Productos.Location = new System.Drawing.Point(1, 0);
            this.dgv_Productos.MultiSelect = false;
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.Size = new System.Drawing.Size(668, 244);
            this.dgv_Productos.TabIndex = 0;
            // 
            // clm_Codifo
            // 
            this.clm_Codifo.HeaderText = "Código";
            this.clm_Codifo.Name = "clm_Codifo";
            this.clm_Codifo.ReadOnly = true;
            this.clm_Codifo.Width = 65;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            this.clm_Nombre.Width = 69;
            // 
            // clm_Descripcion
            // 
            this.clm_Descripcion.HeaderText = "Descripción";
            this.clm_Descripcion.Name = "clm_Descripcion";
            this.clm_Descripcion.ReadOnly = true;
            this.clm_Descripcion.Width = 88;
            // 
            // clm_Existencia
            // 
            this.clm_Existencia.HeaderText = "Existencia";
            this.clm_Existencia.Name = "clm_Existencia";
            this.clm_Existencia.ReadOnly = true;
            this.clm_Existencia.Width = 80;
            // 
            // clm_UnidadMedida
            // 
            this.clm_UnidadMedida.HeaderText = "Unidad de Medida";
            this.clm_UnidadMedida.Name = "clm_UnidadMedida";
            this.clm_UnidadMedida.ReadOnly = true;
            this.clm_UnidadMedida.Width = 109;
            // 
            // clm_Precio1
            // 
            this.clm_Precio1.HeaderText = "Precio 1";
            this.clm_Precio1.Name = "clm_Precio1";
            this.clm_Precio1.ReadOnly = true;
            this.clm_Precio1.Width = 66;
            // 
            // clm_Precio2
            // 
            this.clm_Precio2.HeaderText = "Precio 2";
            this.clm_Precio2.Name = "clm_Precio2";
            this.clm_Precio2.ReadOnly = true;
            this.clm_Precio2.Width = 66;
            // 
            // clm_Precio3
            // 
            this.clm_Precio3.HeaderText = "Precio 3";
            this.clm_Precio3.Name = "clm_Precio3";
            this.clm_Precio3.ReadOnly = true;
            this.clm_Precio3.Width = 66;
            // 
            // frm_AutocompletadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 247);
            this.Controls.Add(this.dgv_Productos);
            this.Name = "frm_AutocompletadoProductos";
            this.Text = "frm_AutocompletadoProductos";
            this.Load += new System.EventHandler(this.frm_AutocompletadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Codifo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio3;
    }
}