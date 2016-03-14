namespace Proyecto_Glacial.Inventario
{
    partial class frm_InventarioAgregar
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_existencia = new System.Windows.Forms.Label();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.lbl_cantidadMinima = new System.Windows.Forms.Label();
            this.txt_cantidadMinima = new System.Windows.Forms.TextBox();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.lbl_AgregarProveedor = new System.Windows.Forms.Label();
            this.lbl_completar = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.vista_listar_proveedores_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_listar_proveedores_productoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.vista_listar_proveedores_productoTableAdapter();
            this.vista_listar_proveedores_productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.lbl_precio1 = new System.Windows.Forms.Label();
            this.lbl_precio2 = new System.Windows.Forms.Label();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.lbl_precio3 = new System.Windows.Forms.Label();
            this.txt_precio3 = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.lbl_LineaProducto = new System.Windows.Forms.Label();
            this.txt_lineaProducto = new System.Windows.Forms.TextBox();
            this.lista_proveedores_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_proveedores_productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_proveedores_productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_proveedores_productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(114, 78);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(181, 29);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(19, 78);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 22);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(301, 81);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(125, 22);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(432, 78);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(219, 29);
            this.txt_descripcion.TabIndex = 2;
            // 
            // lbl_existencia
            // 
            this.lbl_existencia.AutoSize = true;
            this.lbl_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_existencia.Location = new System.Drawing.Point(19, 116);
            this.lbl_existencia.Name = "lbl_existencia";
            this.lbl_existencia.Size = new System.Drawing.Size(110, 22);
            this.lbl_existencia.TabIndex = 5;
            this.lbl_existencia.Text = "Existencia:";
            // 
            // txt_existencia
            // 
            this.txt_existencia.Enabled = false;
            this.txt_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.Location = new System.Drawing.Point(135, 113);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(160, 29);
            this.txt_existencia.TabIndex = 4;
            // 
            // lbl_cantidadMinima
            // 
            this.lbl_cantidadMinima.AutoSize = true;
            this.lbl_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadMinima.Location = new System.Drawing.Point(161, 218);
            this.lbl_cantidadMinima.Name = "lbl_cantidadMinima";
            this.lbl_cantidadMinima.Size = new System.Drawing.Size(298, 22);
            this.lbl_cantidadMinima.TabIndex = 11;
            this.lbl_cantidadMinima.Text = "Cantidad mínima  en Inventario:";
            this.lbl_cantidadMinima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cantidadMinima
            // 
            this.txt_cantidadMinima.Enabled = false;
            this.txt_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadMinima.Location = new System.Drawing.Point(253, 243);
            this.txt_cantidadMinima.Name = "txt_cantidadMinima";
            this.txt_cantidadMinima.Size = new System.Drawing.Size(100, 29);
            this.txt_cantidadMinima.TabIndex = 10;
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.Location = new System.Drawing.Point(301, 116);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(181, 22);
            this.lbl_unidadMedida.TabIndex = 13;
            this.lbl_unidadMedida.Text = "Unidad de Medida:";
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.Enabled = false;
            this.txt_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.Location = new System.Drawing.Point(488, 113);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.Size = new System.Drawing.Size(163, 29);
            this.txt_unidadMedida.TabIndex = 12;
            // 
            // lbl_AgregarProveedor
            // 
            this.lbl_AgregarProveedor.AutoSize = true;
            this.lbl_AgregarProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AgregarProveedor.Location = new System.Drawing.Point(473, 415);
            this.lbl_AgregarProveedor.Name = "lbl_AgregarProveedor";
            this.lbl_AgregarProveedor.Size = new System.Drawing.Size(86, 22);
            this.lbl_AgregarProveedor.TabIndex = 17;
            this.lbl_AgregarProveedor.Text = "Agregar";
            // 
            // lbl_completar
            // 
            this.lbl_completar.AutoSize = true;
            this.lbl_completar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completar.Location = new System.Drawing.Point(527, 290);
            this.lbl_completar.Name = "lbl_completar";
            this.lbl_completar.Size = new System.Drawing.Size(106, 22);
            this.lbl_completar.TabIndex = 18;
            this.lbl_completar.Text = "Completar";
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.EnforceConstraints = false;
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
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
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
            this.vista_listar_proveedores_productoDataGridView.Location = new System.Drawing.Point(12, 293);
            this.vista_listar_proveedores_productoDataGridView.Name = "vista_listar_proveedores_productoDataGridView";
            this.vista_listar_proveedores_productoDataGridView.Size = new System.Drawing.Size(447, 220);
            this.vista_listar_proveedores_productoDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "unidad_medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_lista_proveedores";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_lista_proveedores";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // txt_precio1
            // 
            this.txt_precio1.Enabled = false;
            this.txt_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(114, 161);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(117, 29);
            this.txt_precio1.TabIndex = 19;
            // 
            // lbl_precio1
            // 
            this.lbl_precio1.AutoSize = true;
            this.lbl_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio1.Location = new System.Drawing.Point(17, 164);
            this.lbl_precio1.Name = "lbl_precio1";
            this.lbl_precio1.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio1.TabIndex = 20;
            this.lbl_precio1.Text = "Precio 1:";
            // 
            // lbl_precio2
            // 
            this.lbl_precio2.AutoSize = true;
            this.lbl_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio2.Location = new System.Drawing.Point(262, 164);
            this.lbl_precio2.Name = "lbl_precio2";
            this.lbl_precio2.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio2.TabIndex = 22;
            this.lbl_precio2.Text = "Precio 2:";
            // 
            // txt_precio2
            // 
            this.txt_precio2.Enabled = false;
            this.txt_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio2.Location = new System.Drawing.Point(359, 161);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(100, 29);
            this.txt_precio2.TabIndex = 21;
            // 
            // lbl_precio3
            // 
            this.lbl_precio3.AutoSize = true;
            this.lbl_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio3.Location = new System.Drawing.Point(484, 164);
            this.lbl_precio3.Name = "lbl_precio3";
            this.lbl_precio3.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio3.TabIndex = 24;
            this.lbl_precio3.Text = "Precio 3:";
            // 
            // txt_precio3
            // 
            this.txt_precio3.Enabled = false;
            this.txt_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio3.Location = new System.Drawing.Point(581, 161);
            this.txt_precio3.Name = "txt_precio3";
            this.txt_precio3.Size = new System.Drawing.Size(100, 29);
            this.txt_precio3.TabIndex = 23;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_Guardar.Location = new System.Drawing.Point(542, 207);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(80, 80);
            this.btn_Guardar.TabIndex = 16;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_proveedoresAgregado_Click);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProveedor.Image = global::Proyecto_Glacial.Properties.Resources.socialBlack;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(477, 332);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(80, 80);
            this.btn_AgregarProveedor.TabIndex = 15;
            this.btn_AgregarProveedor.UseVisualStyleBackColor = true;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // lbl_LineaProducto
            // 
            this.lbl_LineaProducto.AutoSize = true;
            this.lbl_LineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LineaProducto.Location = new System.Drawing.Point(17, 27);
            this.lbl_LineaProducto.Name = "lbl_LineaProducto";
            this.lbl_LineaProducto.Size = new System.Drawing.Size(153, 22);
            this.lbl_LineaProducto.TabIndex = 26;
            this.lbl_LineaProducto.Text = "Línea producto:";
            // 
            // txt_lineaProducto
            // 
            this.txt_lineaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_lineaProducto.Enabled = false;
            this.txt_lineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lineaProducto.Location = new System.Drawing.Point(176, 27);
            this.txt_lineaProducto.Name = "txt_lineaProducto";
            this.txt_lineaProducto.Size = new System.Drawing.Size(181, 29);
            this.txt_lineaProducto.TabIndex = 25;
            // 
            // lista_proveedores_productosBindingSource
            // 
            this.lista_proveedores_productosBindingSource.DataMember = "lista_proveedores_productos";
            this.lista_proveedores_productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // lista_proveedores_productosTableAdapter
            // 
            this.lista_proveedores_productosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_InventarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 556);
            this.Controls.Add(this.lbl_LineaProducto);
            this.Controls.Add(this.txt_lineaProducto);
            this.Controls.Add(this.lbl_precio3);
            this.Controls.Add(this.txt_precio3);
            this.Controls.Add(this.lbl_precio2);
            this.Controls.Add(this.txt_precio2);
            this.Controls.Add(this.lbl_precio1);
            this.Controls.Add(this.txt_precio1);
            this.Controls.Add(this.vista_listar_proveedores_productoDataGridView);
            this.Controls.Add(this.lbl_completar);
            this.Controls.Add(this.lbl_AgregarProveedor);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_AgregarProveedor);
            this.Controls.Add(this.lbl_unidadMedida);
            this.Controls.Add(this.txt_unidadMedida);
            this.Controls.Add(this.lbl_cantidadMinima);
            this.Controls.Add(this.txt_cantidadMinima);
            this.Controls.Add(this.lbl_existencia);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Name = "frm_InventarioAgregar";
            this.Text = "Inventario - Agregar";
            this.Load += new System.EventHandler(this.frm_InventarioAgregar_Load);
            this.MouseEnter += new System.EventHandler(this.frm_InventarioAgregar_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_proveedores_productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_existencia;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.Label lbl_cantidadMinima;
        private System.Windows.Forms.TextBox txt_cantidadMinima;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.TextBox txt_unidadMedida;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_AgregarProveedor;
        private System.Windows.Forms.Label lbl_completar;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vista_listar_proveedores_productoBindingSource;
        private glacial_almacenDataSetTableAdapters.vista_listar_proveedores_productoTableAdapter vista_listar_proveedores_productoTableAdapter;
        private System.Windows.Forms.DataGridView vista_listar_proveedores_productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txt_precio1;
        private System.Windows.Forms.Label lbl_precio1;
        private System.Windows.Forms.Label lbl_precio2;
        private System.Windows.Forms.TextBox txt_precio2;
        private System.Windows.Forms.Label lbl_precio3;
        private System.Windows.Forms.TextBox txt_precio3;
        private System.Windows.Forms.Label lbl_LineaProducto;
        private System.Windows.Forms.TextBox txt_lineaProducto;
        private System.Windows.Forms.BindingSource lista_proveedores_productosBindingSource;
        private glacial_almacenDataSetTableAdapters.lista_proveedores_productosTableAdapter lista_proveedores_productosTableAdapter;
    }
}