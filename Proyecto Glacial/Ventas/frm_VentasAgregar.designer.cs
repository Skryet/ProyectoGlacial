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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_Descuento = new System.Windows.Forms.Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_DescuentoCantidad = new System.Windows.Forms.TextBox();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.txt_DescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.pnl_Descuento = new System.Windows.Forms.Panel();
            this.rbt_Cantidad = new System.Windows.Forms.RadioButton();
            this.rbt_Porcentage = new System.Windows.Forms.RadioButton();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.pnl_Descuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_Cliente
            // 
            this.rbt_Cliente.AutoSize = true;
            this.rbt_Cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Cliente.Location = new System.Drawing.Point(238, 88);
            this.rbt_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_Cliente.Name = "rbt_Cliente";
            this.rbt_Cliente.Size = new System.Drawing.Size(71, 22);
            this.rbt_Cliente.TabIndex = 0;
            this.rbt_Cliente.Text = "Socio";
            this.rbt_Cliente.UseVisualStyleBackColor = true;
            this.rbt_Cliente.CheckedChanged += new System.EventHandler(this.rbt_Cliente_CheckedChanged);
            // 
            // rbt_Empresa
            // 
            this.rbt_Empresa.AutoSize = true;
            this.rbt_Empresa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Empresa.Location = new System.Drawing.Point(540, 87);
            this.rbt_Empresa.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_Empresa.Name = "rbt_Empresa";
            this.rbt_Empresa.Size = new System.Drawing.Size(97, 22);
            this.rbt_Empresa.TabIndex = 1;
            this.rbt_Empresa.Text = "Empresa";
            this.rbt_Empresa.UseVisualStyleBackColor = true;
            this.rbt_Empresa.CheckedChanged += new System.EventHandler(this.rbt_Empresa_CheckedChanged);
            // 
            // rbt_SinRegistro
            // 
            this.rbt_SinRegistro.AutoSize = true;
            this.rbt_SinRegistro.Checked = true;
            this.rbt_SinRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_SinRegistro.Location = new System.Drawing.Point(28, 100);
            this.rbt_SinRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_SinRegistro.Name = "rbt_SinRegistro";
            this.rbt_SinRegistro.Size = new System.Drawing.Size(82, 22);
            this.rbt_SinRegistro.TabIndex = 2;
            this.rbt_SinRegistro.TabStop = true;
            this.rbt_SinRegistro.Text = "Cliente";
            this.rbt_SinRegistro.UseVisualStyleBackColor = true;
            this.rbt_SinRegistro.CheckedChanged += new System.EventHandler(this.rbt_SinRegistro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(244, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo de comprador";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(138, 116);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(253, 26);
            this.txt_Cliente.TabIndex = 4;
            // 
            // btn_SeleccionarCliente
            // 
            this.btn_SeleccionarCliente.Enabled = false;
            this.btn_SeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_SeleccionarCliente.Location = new System.Drawing.Point(395, 115);
            this.btn_SeleccionarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccionarCliente.Name = "btn_SeleccionarCliente";
            this.btn_SeleccionarCliente.Size = new System.Drawing.Size(27, 28);
            this.btn_SeleccionarCliente.TabIndex = 5;
            this.btn_SeleccionarCliente.Text = "...";
            this.btn_SeleccionarCliente.UseVisualStyleBackColor = true;
            this.btn_SeleccionarCliente.Click += new System.EventHandler(this.btn_SeleccionarCliente_Click);
            // 
            // btn_SeleccionarEmpresa
            // 
            this.btn_SeleccionarEmpresa.Enabled = false;
            this.btn_SeleccionarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_SeleccionarEmpresa.Location = new System.Drawing.Point(688, 116);
            this.btn_SeleccionarEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccionarEmpresa.Name = "btn_SeleccionarEmpresa";
            this.btn_SeleccionarEmpresa.Size = new System.Drawing.Size(27, 27);
            this.btn_SeleccionarEmpresa.TabIndex = 7;
            this.btn_SeleccionarEmpresa.Text = "...";
            this.btn_SeleccionarEmpresa.UseVisualStyleBackColor = true;
            this.btn_SeleccionarEmpresa.Click += new System.EventHandler(this.btn_SeleccionarEmpresa_Click);
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Enabled = false;
            this.txt_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empresa.Location = new System.Drawing.Point(453, 117);
            this.txt_Empresa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.ReadOnly = true;
            this.txt_Empresa.Size = new System.Drawing.Size(231, 26);
            this.txt_Empresa.TabIndex = 6;
            // 
            // vista_venta_lista_productosDataGridView
            // 
            this.vista_venta_lista_productosDataGridView.AllowUserToAddRows = false;
            this.vista_venta_lista_productosDataGridView.AllowUserToDeleteRows = false;
            this.vista_venta_lista_productosDataGridView.AutoGenerateColumns = false;
            this.vista_venta_lista_productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.vista_venta_lista_productosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.vista_venta_lista_productosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.vista_venta_lista_productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista_venta_lista_productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vista_venta_lista_productosDataGridView.DataSource = this.vista_venta_lista_productosBindingSource;
            this.vista_venta_lista_productosDataGridView.Location = new System.Drawing.Point(13, 161);
            this.vista_venta_lista_productosDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.vista_venta_lista_productosDataGridView.MultiSelect = false;
            this.vista_venta_lista_productosDataGridView.Name = "vista_venta_lista_productosDataGridView";
            this.vista_venta_lista_productosDataGridView.ReadOnly = true;
            this.vista_venta_lista_productosDataGridView.RowTemplate.Height = 24;
            this.vista_venta_lista_productosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vista_venta_lista_productosDataGridView.Size = new System.Drawing.Size(710, 234);
            this.vista_venta_lista_productosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_linea_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Linea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unidad_medida";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 56;
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
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(589, 512);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 30);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(146, 405);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(143, 26);
            this.txt_Subtotal.TabIndex = 12;
            this.txt_Subtotal.Text = "0.00";
            this.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.Location = new System.Drawing.Point(31, 408);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(75, 18);
            this.lbl_Subtotal.TabIndex = 13;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IVA.Location = new System.Drawing.Point(31, 439);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(51, 18);
            this.lbl_IVA.TabIndex = 15;
            this.lbl_IVA.Text = "I.V.A.";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IVA.Location = new System.Drawing.Point(146, 436);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.ReadOnly = true;
            this.txt_IVA.Size = new System.Drawing.Size(143, 26);
            this.txt_IVA.TabIndex = 14;
            this.txt_IVA.Text = "0.00";
            this.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(31, 471);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(48, 18);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(146, 468);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(143, 26);
            this.txt_Total.TabIndex = 16;
            this.txt_Total.Text = "0.00";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Descuento
            // 
            this.btn_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Descuento.Location = new System.Drawing.Point(61, 512);
            this.btn_Descuento.Name = "btn_Descuento";
            this.btn_Descuento.Size = new System.Drawing.Size(190, 30);
            this.btn_Descuento.TabIndex = 18;
            this.btn_Descuento.Text = "Aplicar Descuento";
            this.btn_Descuento.UseVisualStyleBackColor = true;
            this.btn_Descuento.Click += new System.EventHandler(this.btn_Descuento_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Enabled = false;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(31, 72);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(118, 18);
            this.lbl_Cantidad.TabIndex = 22;
            this.lbl_Cantidad.Text = "Cantidad       $";
            // 
            // txt_DescuentoCantidad
            // 
            this.txt_DescuentoCantidad.Enabled = false;
            this.txt_DescuentoCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescuentoCantidad.Location = new System.Drawing.Point(157, 69);
            this.txt_DescuentoCantidad.Name = "txt_DescuentoCantidad";
            this.txt_DescuentoCantidad.Size = new System.Drawing.Size(132, 26);
            this.txt_DescuentoCantidad.TabIndex = 21;
            this.txt_DescuentoCantidad.Text = "0.00";
            this.txt_DescuentoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentaje.Location = new System.Drawing.Point(31, 40);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(120, 18);
            this.lbl_Porcentaje.TabIndex = 20;
            this.lbl_Porcentaje.Text = "Porcentage %";
            // 
            // txt_DescuentoPorcentaje
            // 
            this.txt_DescuentoPorcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescuentoPorcentaje.Location = new System.Drawing.Point(157, 37);
            this.txt_DescuentoPorcentaje.Name = "txt_DescuentoPorcentaje";
            this.txt_DescuentoPorcentaje.Size = new System.Drawing.Size(132, 26);
            this.txt_DescuentoPorcentaje.TabIndex = 19;
            this.txt_DescuentoPorcentaje.Text = "0.00";
            this.txt_DescuentoPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Descuento
            // 
            this.pnl_Descuento.Controls.Add(this.rbt_Cantidad);
            this.pnl_Descuento.Controls.Add(this.rbt_Porcentage);
            this.pnl_Descuento.Controls.Add(this.lbl_Descuento);
            this.pnl_Descuento.Controls.Add(this.lbl_Porcentaje);
            this.pnl_Descuento.Controls.Add(this.lbl_Cantidad);
            this.pnl_Descuento.Controls.Add(this.txt_DescuentoPorcentaje);
            this.pnl_Descuento.Controls.Add(this.txt_DescuentoCantidad);
            this.pnl_Descuento.Location = new System.Drawing.Point(308, 399);
            this.pnl_Descuento.Name = "pnl_Descuento";
            this.pnl_Descuento.Size = new System.Drawing.Size(294, 101);
            this.pnl_Descuento.TabIndex = 23;
            this.pnl_Descuento.Visible = false;
            // 
            // rbt_Cantidad
            // 
            this.rbt_Cantidad.AutoSize = true;
            this.rbt_Cantidad.Location = new System.Drawing.Point(16, 75);
            this.rbt_Cantidad.Name = "rbt_Cantidad";
            this.rbt_Cantidad.Size = new System.Drawing.Size(14, 13);
            this.rbt_Cantidad.TabIndex = 25;
            this.rbt_Cantidad.UseVisualStyleBackColor = true;
            this.rbt_Cantidad.CheckedChanged += new System.EventHandler(this.rdb_Cantidad_CheckedChanged);
            // 
            // rbt_Porcentage
            // 
            this.rbt_Porcentage.AutoSize = true;
            this.rbt_Porcentage.Checked = true;
            this.rbt_Porcentage.Location = new System.Drawing.Point(16, 43);
            this.rbt_Porcentage.Name = "rbt_Porcentage";
            this.rbt_Porcentage.Size = new System.Drawing.Size(14, 13);
            this.rbt_Porcentage.TabIndex = 24;
            this.rbt_Porcentage.TabStop = true;
            this.rbt_Porcentage.UseVisualStyleBackColor = true;
            this.rbt_Porcentage.CheckedChanged += new System.EventHandler(this.rbt_Porcentage_CheckedChanged);
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(40, 3);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(183, 18);
            this.lbl_Descuento.TabIndex = 23;
            this.lbl_Descuento.Text = "Aplicar descuento en:";
            // 
            // frm_VentasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 555);
            this.Controls.Add(this.pnl_Descuento);
            this.Controls.Add(this.btn_Descuento);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.vista_venta_lista_productosDataGridView);
            this.Controls.Add(this.btn_SeleccionarEmpresa);
            this.Controls.Add(this.txt_Empresa);
            this.Controls.Add(this.btn_SeleccionarCliente);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbt_SinRegistro);
            this.Controls.Add(this.rbt_Empresa);
            this.Controls.Add(this.rbt_Cliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_VentasAgregar";
            this.Text = "Ventas - Agregar";
            this.Load += new System.EventHandler(this.frm_VentasAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.pnl_Descuento.ResumeLayout(false);
            this.pnl_Descuento.PerformLayout();
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
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Descuento;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_DescuentoCantidad;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.TextBox txt_DescuentoPorcentaje;
        private System.Windows.Forms.Panel pnl_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.RadioButton rbt_Cantidad;
        private System.Windows.Forms.RadioButton rbt_Porcentage;
    }
}