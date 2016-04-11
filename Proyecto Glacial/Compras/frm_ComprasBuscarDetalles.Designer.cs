namespace Proyecto_Glacial.Compras
{
    partial class frm_ComprasBuscarDetalles
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
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.lista_proveedores_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_proveedores_productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_proveedores_productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.lista_material_comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter();
            this.lista_material_comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_material_comprasDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.comprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_proveedores_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = this.lista_material_comprasTableAdapter;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = this.lista_proveedores_productosTableAdapter;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // lista_material_comprasTableAdapter
            // 
            this.lista_material_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // lista_material_comprasBindingSource
            // 
            this.lista_material_comprasBindingSource.DataMember = "lista_material_compras";
            this.lista_material_comprasBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // lista_material_comprasDataGridView
            // 
            this.lista_material_comprasDataGridView.AutoGenerateColumns = false;
            this.lista_material_comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_material_comprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3});
            this.lista_material_comprasDataGridView.DataSource = this.lista_material_comprasBindingSource;
            this.lista_material_comprasDataGridView.Location = new System.Drawing.Point(12, 52);
            this.lista_material_comprasDataGridView.Name = "lista_material_comprasDataGridView";
            this.lista_material_comprasDataGridView.ReadOnly = true;
            this.lista_material_comprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_material_comprasDataGridView.Size = new System.Drawing.Size(560, 220);
            this.lista_material_comprasDataGridView.TabIndex = 0;
            this.lista_material_comprasDataGridView.Click += new System.EventHandler(this.lista_material_comprasDataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles de la Compra";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::Proyecto_Glacial.Properties.Resources.DeleteProductRed;
            this.button1.Location = new System.Drawing.Point(707, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modificar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eliminar";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Proyecto_Glacial.Properties.Resources.tool;
            this.btn_modificar.Location = new System.Drawing.Point(592, 52);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(80, 80);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_lista_material_compra";
            this.Column1.HeaderText = "Lista MaterialCompra";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número del producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidad de Medida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "compras";
            this.comprasBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ComprasBuscarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_material_comprasDataGridView);
            this.Name = "frm_ComprasBuscarDetalles";
            this.Text = "Buscar Detalles de Productos";
            this.Activated += new System.EventHandler(this.frm_ComprasBuscarDetalles_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ComprasBuscarDetalles_FormClosed);
            this.Load += new System.EventHandler(this.frm_ComprasBuscarDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_proveedores_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource lista_proveedores_productosBindingSource;
        private glacial_almacenDataSetTableAdapters.lista_proveedores_productosTableAdapter lista_proveedores_productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter lista_material_comprasTableAdapter;
        private System.Windows.Forms.BindingSource lista_material_comprasBindingSource;
        private System.Windows.Forms.DataGridView lista_material_comprasDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.comprasTableAdapter comprasTableAdapter;
    }
}