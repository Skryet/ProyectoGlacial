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
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
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
            this.rbt_Todo = new System.Windows.Forms.RadioButton();
            this.rbt_Existencia = new System.Windows.Forms.RadioButton();
            this.lbl_Mostrar = new System.Windows.Forms.Label();
            this.btn_MostrarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(384, 30);
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
            "Descripción",
            "Línea"});
            this.cbx_Tipo.Location = new System.Drawing.Point(205, 69);
            this.cbx_Tipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(166, 26);
            this.cbx_Tipo.TabIndex = 3;
            this.cbx_Tipo.Text = "Código";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(375, 69);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(263, 26);
            this.txt_Buscar.TabIndex = 4;
            this.txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buscar_KeyPress);
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProducto.Location = new System.Drawing.Point(573, 686);
            this.btn_AgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(162, 32);
            this.btn_AgregarProducto.TabIndex = 6;
            this.btn_AgregarProducto.Text = "Agregar producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_Agregar_Click);
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
            this.productosDataGridView.Location = new System.Drawing.Point(25, 139);
            this.productosDataGridView.MultiSelect = false;
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGridView.Size = new System.Drawing.Size(1302, 521);
            this.productosDataGridView.TabIndex = 14;
            this.productosDataGridView.Click += new System.EventHandler(this.productosDataGridView_Click);
            this.productosDataGridView.DoubleClick += new System.EventHandler(this.productosDataGridView_DoubleClick);
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
            // rbt_Todo
            // 
            this.rbt_Todo.AutoSize = true;
            this.rbt_Todo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Todo.Location = new System.Drawing.Point(668, 73);
            this.rbt_Todo.Name = "rbt_Todo";
            this.rbt_Todo.Size = new System.Drawing.Size(66, 22);
            this.rbt_Todo.TabIndex = 15;
            this.rbt_Todo.Text = "Todo";
            this.rbt_Todo.UseVisualStyleBackColor = true;
            this.rbt_Todo.CheckedChanged += new System.EventHandler(this.rbt_Todo_CheckedChanged);
            // 
            // rbt_Existencia
            // 
            this.rbt_Existencia.AutoSize = true;
            this.rbt_Existencia.Checked = true;
            this.rbt_Existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Existencia.Location = new System.Drawing.Point(802, 73);
            this.rbt_Existencia.Name = "rbt_Existencia";
            this.rbt_Existencia.Size = new System.Drawing.Size(108, 22);
            this.rbt_Existencia.TabIndex = 16;
            this.rbt_Existencia.TabStop = true;
            this.rbt_Existencia.Text = "Existencia";
            this.rbt_Existencia.UseVisualStyleBackColor = true;
            this.rbt_Existencia.CheckedChanged += new System.EventHandler(this.rbt_Existencia_CheckedChanged);
            // 
            // lbl_Mostrar
            // 
            this.lbl_Mostrar.AutoSize = true;
            this.lbl_Mostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mostrar.Location = new System.Drawing.Point(733, 30);
            this.lbl_Mostrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mostrar.Name = "lbl_Mostrar";
            this.lbl_Mostrar.Size = new System.Drawing.Size(106, 18);
            this.lbl_Mostrar.TabIndex = 17;
            this.lbl_Mostrar.Text = "Mostrar por:";
            // 
            // btn_MostrarLista
            // 
            this.btn_MostrarLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarLista.Location = new System.Drawing.Point(989, 41);
            this.btn_MostrarLista.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MostrarLista.Name = "btn_MostrarLista";
            this.btn_MostrarLista.Size = new System.Drawing.Size(103, 53);
            this.btn_MostrarLista.TabIndex = 18;
            this.btn_MostrarLista.Text = "Mostrar Lista";
            this.btn_MostrarLista.UseVisualStyleBackColor = true;
            this.btn_MostrarLista.Click += new System.EventHandler(this.btn_MostrarLista_Click);
            // 
            // frm_VentasAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_MostrarLista);
            this.Controls.Add(this.lbl_Mostrar);
            this.Controls.Add(this.rbt_Existencia);
            this.Controls.Add(this.rbt_Todo);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.lbl_Buscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_VentasAgregarProducto";
            this.Text = "frm_VentasAgregarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btn_AgregarProducto;
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
        private System.Windows.Forms.RadioButton rbt_Todo;
        private System.Windows.Forms.RadioButton rbt_Existencia;
        private System.Windows.Forms.Label lbl_Mostrar;
        private System.Windows.Forms.Button btn_MostrarLista;
    }
}