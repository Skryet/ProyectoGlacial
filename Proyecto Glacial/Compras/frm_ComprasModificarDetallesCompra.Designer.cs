namespace Proyecto_Glacial.Compras
{
    partial class frm_ComprasModificarDetallesCompra
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
            this.lista_material_comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_material_comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.lista_material_comprasDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.comprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
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
            // lista_material_comprasBindingSource
            // 
            this.lista_material_comprasBindingSource.DataMember = "lista_material_compras";
            this.lista_material_comprasBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // lista_material_comprasTableAdapter
            // 
            this.lista_material_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = this.lista_material_comprasTableAdapter;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.lista_material_comprasDataGridView.DataSource = this.lista_material_comprasBindingSource;
            this.lista_material_comprasDataGridView.Location = new System.Drawing.Point(2, 70);
            this.lista_material_comprasDataGridView.Name = "lista_material_comprasDataGridView";
            this.lista_material_comprasDataGridView.Size = new System.Drawing.Size(562, 220);
            this.lista_material_comprasDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_lista_material_compra";
            this.Column1.HeaderText = "ListaCompras";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Númerod del Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre del Producto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unidad de Medida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificar Detalles de Compra";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Proyecto_Glacial.Properties.Resources.arrowsPurpleModify;
            this.btn_actualizar.Location = new System.Drawing.Point(589, 70);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actualizar";
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
            // frm_ComprasModificarDetallesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_material_comprasDataGridView);
            this.Name = "frm_ComprasModificarDetallesCompra";
            this.Text = "Compras - Modificar Detalles de la Compra";
            this.Load += new System.EventHandler(this.frm_ComprasModificarDetallesCompra_Load);
            this.Enter += new System.EventHandler(this.frm_ComprasModificarDetallesCompra_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource lista_material_comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter lista_material_comprasTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lista_material_comprasDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.comprasTableAdapter comprasTableAdapter;
    }
}