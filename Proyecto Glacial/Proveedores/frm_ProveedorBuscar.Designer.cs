namespace Proyecto_Glacial.Proveedores
{
    partial class frm_ProveedorBuscar
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
            this.cbb_Opciones = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_BuscarPor = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedoresTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_Opciones
            // 
            this.cbb_Opciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cbb_Opciones.FormattingEnabled = true;
            this.cbb_Opciones.Items.AddRange(new object[] {
            "Nombre",
            "Estado"});
            this.cbb_Opciones.Location = new System.Drawing.Point(14, 45);
            this.cbb_Opciones.Name = "cbb_Opciones";
            this.cbb_Opciones.Size = new System.Drawing.Size(141, 23);
            this.cbb_Opciones.TabIndex = 10;
            this.cbb_Opciones.Text = "Seleccione";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txt_Buscar.Location = new System.Drawing.Point(161, 45);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(400, 23);
            this.txt_Buscar.TabIndex = 8;
            // 
            // lbl_BuscarPor
            // 
            this.lbl_BuscarPor.AutoSize = true;
            this.lbl_BuscarPor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.lbl_BuscarPor.Location = new System.Drawing.Point(265, 16);
            this.lbl_BuscarPor.Name = "lbl_BuscarPor";
            this.lbl_BuscarPor.Size = new System.Drawing.Size(116, 21);
            this.lbl_BuscarPor.TabIndex = 7;
            this.lbl_BuscarPor.Text = "Buscar Por:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            this.btn_Buscar.Location = new System.Drawing.Point(582, 19);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 75);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AllowUserToAddRows = false;
            this.proveedoresDataGridView.AllowUserToDeleteRows = false;
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.proveedoresDataGridView.DataSource = this.proveedoresBindingSource;
            this.proveedoresDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(2, 126);
            this.proveedoresDataGridView.MultiSelect = false;
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.ReadOnly = true;
            this.proveedoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proveedoresDataGridView.Size = new System.Drawing.Size(676, 346);
            this.proveedoresDataGridView.TabIndex = 11;
            this.proveedoresDataGridView.Click += new System.EventHandler(this.proveedoresDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "colonia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Colonia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frm_ProveedorBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 484);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Controls.Add(this.cbb_Opciones);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lbl_BuscarPor);
            this.Name = "frm_ProveedorBuscar";
            this.Text = "Proveedor - Buscar";
            this.Load += new System.EventHandler(this.frm_ProveedorBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Opciones;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_BuscarPor;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private glacial_almacenDataSetTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}