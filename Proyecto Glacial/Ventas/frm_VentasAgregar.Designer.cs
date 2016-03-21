namespace Proyecto_Glacial.Ventas
{
    partial class frm_VentasAgregar
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
            this.rbt_Cliente = new System.Windows.Forms.RadioButton();
            this.rbt_Empresa = new System.Windows.Forms.RadioButton();
            this.rbt_SinRegistro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_SeleccionarCliente = new System.Windows.Forms.Button();
            this.btn_SeleccionarEmpresa = new System.Windows.Forms.Button();
            this.txt_Empresa = new System.Windows.Forms.TextBox();
            this.vista_venta_lista_productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_venta_lista_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.vista_venta_lista_productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.vista_venta_lista_productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_Cliente
            // 
            this.rbt_Cliente.AutoSize = true;
            this.rbt_Cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Cliente.Location = new System.Drawing.Point(364, 73);
            this.rbt_Cliente.Name = "rbt_Cliente";
            this.rbt_Cliente.Size = new System.Drawing.Size(80, 27);
            this.rbt_Cliente.TabIndex = 0;
            this.rbt_Cliente.TabStop = true;
            this.rbt_Cliente.Text = "Socio";
            this.rbt_Cliente.UseVisualStyleBackColor = true;
            // 
            // rbt_Empresa
            // 
            this.rbt_Empresa.AutoSize = true;
            this.rbt_Empresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Empresa.Location = new System.Drawing.Point(766, 72);
            this.rbt_Empresa.Name = "rbt_Empresa";
            this.rbt_Empresa.Size = new System.Drawing.Size(110, 27);
            this.rbt_Empresa.TabIndex = 1;
            this.rbt_Empresa.TabStop = true;
            this.rbt_Empresa.Text = "Empresa";
            this.rbt_Empresa.UseVisualStyleBackColor = true;
            // 
            // rbt_SinRegistro
            // 
            this.rbt_SinRegistro.AutoSize = true;
            this.rbt_SinRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_SinRegistro.Location = new System.Drawing.Point(54, 87);
            this.rbt_SinRegistro.Name = "rbt_SinRegistro";
            this.rbt_SinRegistro.Size = new System.Drawing.Size(91, 27);
            this.rbt_SinRegistro.TabIndex = 2;
            this.rbt_SinRegistro.TabStop = true;
            this.rbt_SinRegistro.Text = "Cliente";
            this.rbt_SinRegistro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo de comprador";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(187, 104);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(380, 30);
            this.txt_Cliente.TabIndex = 4;
            // 
            // btn_SeleccionarCliente
            // 
            this.btn_SeleccionarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccionarCliente.Location = new System.Drawing.Point(573, 105);
            this.btn_SeleccionarCliente.Name = "btn_SeleccionarCliente";
            this.btn_SeleccionarCliente.Size = new System.Drawing.Size(36, 31);
            this.btn_SeleccionarCliente.TabIndex = 5;
            this.btn_SeleccionarCliente.Text = "...";
            this.btn_SeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_SeleccionarEmpresa
            // 
            this.btn_SeleccionarEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccionarEmpresa.Location = new System.Drawing.Point(964, 104);
            this.btn_SeleccionarEmpresa.Name = "btn_SeleccionarEmpresa";
            this.btn_SeleccionarEmpresa.Size = new System.Drawing.Size(36, 31);
            this.btn_SeleccionarEmpresa.TabIndex = 7;
            this.btn_SeleccionarEmpresa.Text = "...";
            this.btn_SeleccionarEmpresa.UseVisualStyleBackColor = true;
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empresa.Location = new System.Drawing.Point(651, 105);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.Size = new System.Drawing.Size(307, 30);
            this.txt_Empresa.TabIndex = 6;
            // 
            // vista_venta_lista_productosDataGridView
            // 
            this.vista_venta_lista_productosDataGridView.AutoGenerateColumns = false;
            this.vista_venta_lista_productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_venta_lista_productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vista_venta_lista_productosDataGridView.DataSource = this.vista_venta_lista_productosBindingSource;
            this.vista_venta_lista_productosDataGridView.Location = new System.Drawing.Point(66, 231);
            this.vista_venta_lista_productosDataGridView.Name = "vista_venta_lista_productosDataGridView";
            this.vista_venta_lista_productosDataGridView.RowTemplate.Height = 24;
            this.vista_venta_lista_productosDataGridView.Size = new System.Drawing.Size(934, 332);
            this.vista_venta_lista_productosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_linea_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Linea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // vista_venta_lista_productosBindingSource
            // 
            this.vista_venta_lista_productosBindingSource.DataMember = "vista_venta_lista_productos";
            this.vista_venta_lista_productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_venta_lista_productosTableAdapter
            // 
            this.vista_venta_lista_productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.material_ventasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_VentasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 683);
            this.Controls.Add(this.vista_venta_lista_productosDataGridView);
            this.Controls.Add(this.btn_SeleccionarEmpresa);
            this.Controls.Add(this.txt_Empresa);
            this.Controls.Add(this.btn_SeleccionarCliente);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbt_SinRegistro);
            this.Controls.Add(this.rbt_Empresa);
            this.Controls.Add(this.rbt_Cliente);
            this.Name = "frm_VentasAgregar";
            this.Text = "Ventas - Agregar";
            this.Load += new System.EventHandler(this.frm_VentasAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Cliente;
        private System.Windows.Forms.RadioButton rbt_Empresa;
        private System.Windows.Forms.RadioButton rbt_SinRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_SeleccionarCliente;
        private System.Windows.Forms.Button btn_SeleccionarEmpresa;
        private System.Windows.Forms.TextBox txt_Empresa;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource vista_venta_lista_productosBindingSource;
        private glacial_almacenDataSetTableAdapters.vista_venta_lista_productosTableAdapter vista_venta_lista_productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vista_venta_lista_productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}