namespace Proyecto_Glacial.Ventas
{
    partial class frm_VentasSeleccionEmpresa
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
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.cbb_Opciones = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_BuscarPor = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
          //  this.empresaTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.empresaTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.empresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarEmpresa = new System.Windows.Forms.Button();
            this.btn_SeleccionarEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(291, 96);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(320, 28);
            this.btn_Actualizar.TabIndex = 22;
            this.btn_Actualizar.Text = "Actualizar lista de empresas";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // cbb_Opciones
            // 
            this.cbb_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_Opciones.FormattingEnabled = true;
            this.cbb_Opciones.Items.AddRange(new object[] {
            "Nombre",
            "Estado"});
            this.cbb_Opciones.Location = new System.Drawing.Point(34, 48);
            this.cbb_Opciones.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Opciones.Name = "cbb_Opciones";
            this.cbb_Opciones.Size = new System.Drawing.Size(187, 28);
            this.cbb_Opciones.TabIndex = 21;
            this.cbb_Opciones.Text = "Seleccione";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            this.btn_Buscar.Location = new System.Drawing.Point(791, 16);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(100, 92);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Buscar.Location = new System.Drawing.Point(230, 48);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(532, 26);
            this.txt_Buscar.TabIndex = 19;
            // 
            // lbl_BuscarPor
            // 
            this.lbl_BuscarPor.AutoSize = true;
            this.lbl_BuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_BuscarPor.Location = new System.Drawing.Point(369, 13);
            this.lbl_BuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarPor.Name = "lbl_BuscarPor";
            this.lbl_BuscarPor.Size = new System.Drawing.Size(126, 26);
            this.lbl_BuscarPor.TabIndex = 18;
            this.lbl_BuscarPor.Text = "Buscar Por:";
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "empresa";
            this.empresaBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // empresaTableAdapter
            // 
          //  this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
        //    this.tableAdapterManager.empresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;            
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;           
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // empresaDataGridView
            // 
            this.empresaDataGridView.AllowUserToAddRows = false;
            this.empresaDataGridView.AllowUserToDeleteRows = false;
            this.empresaDataGridView.AutoGenerateColumns = false;
            this.empresaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.empresaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.empresaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.empresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.empresaDataGridView.DataSource = this.empresaBindingSource;
            this.empresaDataGridView.Location = new System.Drawing.Point(2, 143);
            this.empresaDataGridView.MultiSelect = false;
            this.empresaDataGridView.Name = "empresaDataGridView";
            this.empresaDataGridView.ReadOnly = true;
            this.empresaDataGridView.RowTemplate.Height = 24;
            this.empresaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empresaDataGridView.Size = new System.Drawing.Size(906, 342);
            this.empresaDataGridView.TabIndex = 23;
            this.empresaDataGridView.Click += new System.EventHandler(this.empresaDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_empresa";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 87;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "rfc";
            this.dataGridViewTextBoxColumn9.HeaderText = "R.F.C.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // btn_AgregarEmpresa
            // 
            this.btn_AgregarEmpresa.Location = new System.Drawing.Point(185, 513);
            this.btn_AgregarEmpresa.Name = "btn_AgregarEmpresa";
            this.btn_AgregarEmpresa.Size = new System.Drawing.Size(173, 42);
            this.btn_AgregarEmpresa.TabIndex = 27;
            this.btn_AgregarEmpresa.Text = "Agregar Empresa";
            this.btn_AgregarEmpresa.UseVisualStyleBackColor = true;
            this.btn_AgregarEmpresa.Click += new System.EventHandler(this.btn_AgregarEmpresa_Click);
            // 
            // btn_SeleccionarEmpresa
            // 
            this.btn_SeleccionarEmpresa.Location = new System.Drawing.Point(562, 513);
            this.btn_SeleccionarEmpresa.Name = "btn_SeleccionarEmpresa";
            this.btn_SeleccionarEmpresa.Size = new System.Drawing.Size(173, 42);
            this.btn_SeleccionarEmpresa.TabIndex = 26;
            this.btn_SeleccionarEmpresa.Text = "Seleccionar Empresa";
            this.btn_SeleccionarEmpresa.UseVisualStyleBackColor = true;
            this.btn_SeleccionarEmpresa.Click += new System.EventHandler(this.btn_SeleccionarEmpresa_Click);
            // 
            // frm_VentasSeleccionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 596);
            this.Controls.Add(this.btn_AgregarEmpresa);
            this.Controls.Add(this.btn_SeleccionarEmpresa);
            this.Controls.Add(this.empresaDataGridView);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.cbb_Opciones);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lbl_BuscarPor);
            this.Name = "frm_VentasSeleccionEmpresa";
            this.Text = "Ventas - Seleccion Empresa";
            this.Load += new System.EventHandler(this.frm_VentasSeleccionEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.ComboBox cbb_Opciones;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_BuscarPor;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
      //  private glacial_almacenDataSetTableAdapters.empresaTableAdapter empresaTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView empresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btn_AgregarEmpresa;
        private System.Windows.Forms.Button btn_SeleccionarEmpresa;
    }
}