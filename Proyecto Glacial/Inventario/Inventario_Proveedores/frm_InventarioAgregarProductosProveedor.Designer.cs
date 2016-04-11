namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    partial class frm_InventarioAgregarProductosProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.vista_listar_proveedores_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_listar_proveedores_productoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.vista_listar_proveedores_productoTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.vista_listar_proveedores_productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_agregarProveedor = new System.Windows.Forms.Label();
            this.lbl_completar = new System.Windows.Forms.Label();
            this.btn_completar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(152, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(470, 32);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Lista de Proveedores del Producto";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.EnforceConstraints = false;
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_listar_proveedores_productoBindingSource
            // 
            this.vista_listar_proveedores_productoBindingSource.DataMember = "vista_listar_proveedores_producto";
            this.vista_listar_proveedores_productoBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // vista_listar_proveedores_productoTableAdapter
            // 
            this.vista_listar_proveedores_productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // vista_listar_proveedores_productoDataGridView
            // 
            this.vista_listar_proveedores_productoDataGridView.AutoGenerateColumns = false;
            this.vista_listar_proveedores_productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_listar_proveedores_productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vista_listar_proveedores_productoDataGridView.DataSource = this.vista_listar_proveedores_productoBindingSource;
            this.vista_listar_proveedores_productoDataGridView.Location = new System.Drawing.Point(12, 104);
            this.vista_listar_proveedores_productoDataGridView.Name = "vista_listar_proveedores_productoDataGridView";
            this.vista_listar_proveedores_productoDataGridView.ReadOnly = true;
            this.vista_listar_proveedores_productoDataGridView.Size = new System.Drawing.Size(565, 220);
            this.vista_listar_proveedores_productoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de Proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unidad de Medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_lista_proveedores";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_lista_proveedores";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // lbl_agregarProveedor
            // 
            this.lbl_agregarProveedor.AutoSize = true;
            this.lbl_agregarProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregarProveedor.Location = new System.Drawing.Point(594, 177);
            this.lbl_agregarProveedor.Name = "lbl_agregarProveedor";
            this.lbl_agregarProveedor.Size = new System.Drawing.Size(116, 48);
            this.lbl_agregarProveedor.TabIndex = 4;
            this.lbl_agregarProveedor.Text = "Agregar \r\nProveedor";
            this.lbl_agregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_completar
            // 
            this.lbl_completar.AutoSize = true;
            this.lbl_completar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completar.Location = new System.Drawing.Point(594, 311);
            this.lbl_completar.Name = "lbl_completar";
            this.lbl_completar.Size = new System.Drawing.Size(117, 24);
            this.lbl_completar.TabIndex = 6;
            this.lbl_completar.Text = "Completar";
            this.lbl_completar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_completar
            // 
            this.btn_completar.Enabled = false;
            this.btn_completar.Image = global::Proyecto_Glacial.Properties.Resources.CheckBlue;
            this.btn_completar.Location = new System.Drawing.Point(610, 228);
            this.btn_completar.Name = "btn_completar";
            this.btn_completar.Size = new System.Drawing.Size(80, 80);
            this.btn_completar.TabIndex = 5;
            this.btn_completar.UseVisualStyleBackColor = true;
            this.btn_completar.Click += new System.EventHandler(this.btn_completar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddProviderBlue;
            this.btn_agregar.Location = new System.Drawing.Point(610, 94);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 80);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // frm_InventarioAgregarProductosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 349);
            this.Controls.Add(this.lbl_completar);
            this.Controls.Add(this.btn_completar);
            this.Controls.Add(this.lbl_agregarProveedor);
            this.Controls.Add(this.vista_listar_proveedores_productoDataGridView);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_InventarioAgregarProductosProveedor";
            this.Text = "Almacén - Agregar Proveedores";
            this.Activated += new System.EventHandler(this.frm_InventarioAgregarProductosProveedor_Activated_1);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_InventarioAgregarProductosProveedor_FormClosing);
            this.Load += new System.EventHandler(this.frm_InventarioAgregarProductosProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_agregar;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource vista_listar_proveedores_productoBindingSource;
        private glacial_almacenDataSetTableAdapters.vista_listar_proveedores_productoTableAdapter vista_listar_proveedores_productoTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vista_listar_proveedores_productoDataGridView;
        private System.Windows.Forms.Label lbl_agregarProveedor;
        private System.Windows.Forms.Label lbl_completar;
        private System.Windows.Forms.Button btn_completar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}