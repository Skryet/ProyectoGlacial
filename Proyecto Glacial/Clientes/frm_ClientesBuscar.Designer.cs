namespace Proyecto_Glacial.Clientes
{
    partial class frm_ClientesBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_SelccionarTipo = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiene_credito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_limite_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_SelccionarTipo
            // 
            this.cmb_SelccionarTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SelccionarTipo.FormattingEnabled = true;
            this.cmb_SelccionarTipo.Items.AddRange(new object[] {
            "Número de Cliente",
            "Apellido Paterno",
            "Nombre del Cliente"});
            this.cmb_SelccionarTipo.Location = new System.Drawing.Point(12, 51);
            this.cmb_SelccionarTipo.Name = "cmb_SelccionarTipo";
            this.cmb_SelccionarTipo.Size = new System.Drawing.Size(194, 30);
            this.cmb_SelccionarTipo.TabIndex = 15;
            this.cmb_SelccionarTipo.Text = "Seleccione";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray_02_;
            this.btn_Buscar.Location = new System.Drawing.Point(746, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 80);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(212, 52);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(528, 29);
            this.txt_Buscar.TabIndex = 12;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(751, 95);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(75, 22);
            this.lbl_Buscar.TabIndex = 16;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonAllGray;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(864, 12);
            this.btn_BuscarTodo.Name = "btn_BuscarTodo";
            this.btn_BuscarTodo.Size = new System.Drawing.Size(80, 80);
            this.btn_BuscarTodo.TabIndex = 17;
            this.btn_BuscarTodo.UseVisualStyleBackColor = true;
            this.btn_BuscarTodo.Click += new System.EventHandler(this.btn_BuscarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(860, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar \r\nTodo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.clientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.telefono,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.correo,
            this.rfc,
            this.fecha_registro,
            this.tiene_credito,
            this.credito,
            this.fecha_limite_credito,
            this.CURP,
            this.precio_asignado});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(27, 167);
            this.clientesDataGridView.MultiSelect = false;
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDataGridView.Size = new System.Drawing.Size(1111, 306);
            this.clientesDataGridView.TabIndex = 16;
            this.clientesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.clientesDataGridView_CellFormatting);
            this.clientesDataGridView.Click += new System.EventHandler(this.clientesDataGridView_Click);
            this.clientesDataGridView.DoubleClick += new System.EventHandler(this.clientesDataGridView_DoubleClick);
            // 
            // Identificador
            // 
            dataGridViewCellStyle1.Format = "\"C\"";
            dataGridViewCellStyle1.NullValue = "C";
            this.Identificador.DefaultCellStyle = dataGridViewCellStyle1;
            this.Identificador.HeaderText = "";
            this.Identificador.MaxInputLength = 6;
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Identificador.Width = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cliente";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre o Razón Social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 74;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "colonia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Colonia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 67;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ciudad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 65;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cp";
            this.dataGridViewTextBoxColumn8.HeaderText = "Código Postal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 89;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 63;
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            this.rfc.ReadOnly = true;
            this.rfc.Width = 53;
            // 
            // fecha_registro
            // 
            this.fecha_registro.DataPropertyName = "fecha_registro";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.fecha_registro.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha_registro.HeaderText = "Fecha de Registro";
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.ReadOnly = true;
            this.fecha_registro.Width = 74;
            // 
            // tiene_credito
            // 
            this.tiene_credito.DataPropertyName = "tiene_credito";
            this.tiene_credito.HeaderText = "Crédito";
            this.tiene_credito.Name = "tiene_credito";
            this.tiene_credito.ReadOnly = true;
            this.tiene_credito.Width = 46;
            // 
            // credito
            // 
            this.credito.DataPropertyName = "credito";
            this.credito.HeaderText = "Crédito";
            this.credito.Name = "credito";
            this.credito.ReadOnly = true;
            this.credito.Width = 65;
            // 
            // fecha_limite_credito
            // 
            this.fecha_limite_credito.DataPropertyName = "fecha_limite_credito";
            this.fecha_limite_credito.HeaderText = "Fecha Límite del Crédito";
            this.fecha_limite_credito.Name = "fecha_limite_credito";
            this.fecha_limite_credito.ReadOnly = true;
            this.fecha_limite_credito.Width = 89;
            // 
            // CURP
            // 
            this.CURP.DataPropertyName = "CURP";
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.ReadOnly = true;
            this.CURP.Width = 62;
            // 
            // precio_asignado
            // 
            this.precio_asignado.DataPropertyName = "precio_asignado";
            dataGridViewCellStyle4.Format = "Precio #0";
            dataGridViewCellStyle4.NullValue = null;
            this.precio_asignado.DefaultCellStyle = dataGridViewCellStyle4;
            this.precio_asignado.HeaderText = "Precio Referencial";
            this.precio_asignado.Name = "precio_asignado";
            this.precio_asignado.ReadOnly = true;
            this.precio_asignado.Width = 109;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_ClientesBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarTodo);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cmb_SelccionarTipo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Name = "frm_ClientesBuscar";
            this.Text = "frm_ClientesBuscar";
            this.Load += new System.EventHandler(this.frm_ClientesBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private glacial_almacenDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmb_SelccionarTipo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tiene_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_limite_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_asignado;
    }
}