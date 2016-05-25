namespace Proyecto_Glacial.Ventas
{
    partial class frm_VentasAgregarProducto
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.cbx_TipoPrecio = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.clm_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(337, 21);
            this.lbl_Buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(102, 18);
            this.lbl_Buscar.TabIndex = 2;
            this.lbl_Buscar.Text = "Buscar por:";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Items.AddRange(new object[] {
            "Código",
            "Descripcion"});
            this.cbx_Tipo.Location = new System.Drawing.Point(128, 60);
            this.cbx_Tipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(166, 26);
            this.cbx_Tipo.TabIndex = 3;
            this.cbx_Tipo.Text = "Seleccione";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(298, 60);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(219, 26);
            this.txt_Buscar.TabIndex = 4;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(535, 60);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(103, 26);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.Location = new System.Drawing.Point(310, 468);
            this.btn_AgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(162, 32);
            this.btn_AgregarProducto.TabIndex = 6;
            this.btn_AgregarProducto.Text = "Agregar producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // cbx_TipoPrecio
            // 
            this.cbx_TipoPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TipoPrecio.FormattingEnabled = true;
            this.cbx_TipoPrecio.Items.AddRange(new object[] {
            "Especial",
            "Precio 1",
            "Precio 2",
            "Precio 3"});
            this.cbx_TipoPrecio.Location = new System.Drawing.Point(363, 104);
            this.cbx_TipoPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_TipoPrecio.Name = "cbx_TipoPrecio";
            this.cbx_TipoPrecio.Size = new System.Drawing.Size(120, 26);
            this.cbx_TipoPrecio.TabIndex = 7;
            this.cbx_TipoPrecio.Text = "Seleccione";
            this.cbx_TipoPrecio.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoPrecio_SelectedIndexChanged);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(66, 107);
            this.lbl_Precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(293, 18);
            this.lbl_Precio.TabIndex = 8;
            this.lbl_Precio.Text = "Seleccione el precio que desea dar:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(529, 107);
            this.lbl_Cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(80, 18);
            this.lbl_Cantidad.TabIndex = 9;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(613, 104);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(76, 26);
            this.txt_Cantidad.TabIndex = 10;
            this.txt_Cantidad.Text = "0";
            this.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AllowUserToAddRows = false;
            this.productosDataGridView.AllowUserToDeleteRows = false;
            this.productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.productosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Codigo,
            this.clm_Nombre,
            this.clm_Descripcion,
            this.clm_Existencia,
            this.clm_UnidadMedida,
            this.clm_Precio1,
            this.clm_Precio2,
            this.clm_Precio3});
            this.productosDataGridView.Location = new System.Drawing.Point(12, 169);
            this.productosDataGridView.MultiSelect = false;
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGridView.Size = new System.Drawing.Size(750, 283);
            this.productosDataGridView.TabIndex = 14;
            this.productosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosDataGridView_CellDoubleClick);
            this.productosDataGridView.Click += new System.EventHandler(this.productosDataGridView_Click);
            // 
            // clm_Codigo
            // 
            this.clm_Codigo.HeaderText = "Código";
            this.clm_Codigo.Name = "clm_Codigo";
            this.clm_Codigo.ReadOnly = true;
            this.clm_Codigo.Width = 65;
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
            this.clm_UnidadMedida.HeaderText = "Unidad";
            this.clm_UnidadMedida.Name = "clm_UnidadMedida";
            this.clm_UnidadMedida.ReadOnly = true;
            this.clm_UnidadMedida.Width = 66;
            // 
            // clm_Precio1
            // 
            this.clm_Precio1.HeaderText = "Precio 1";
            this.clm_Precio1.Name = "clm_Precio1";
            this.clm_Precio1.ReadOnly = true;
            this.clm_Precio1.Width = 71;
            // 
            // clm_Precio2
            // 
            this.clm_Precio2.HeaderText = "Precio 2";
            this.clm_Precio2.Name = "clm_Precio2";
            this.clm_Precio2.ReadOnly = true;
            this.clm_Precio2.Width = 71;
            // 
            // clm_Precio3
            // 
            this.clm_Precio3.HeaderText = "Precio 3";
            this.clm_Precio3.Name = "clm_Precio3";
            this.clm_Precio3.ReadOnly = true;
            this.clm_Precio3.Width = 71;
            // 
            // frm_VentasAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 516);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.cbx_TipoPrecio);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.lbl_Buscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_VentasAgregarProducto";
            this.Text = "frm_VentasAgregarProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_VentasAgregarProducto_FormClosing);
            this.Load += new System.EventHandler(this.frm_VentasAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.ComboBox cbx_TipoPrecio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio3;
    }
}