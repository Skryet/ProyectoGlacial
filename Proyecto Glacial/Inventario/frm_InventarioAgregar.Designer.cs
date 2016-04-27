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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.vista_listar_proveedores_productoDataGridView = new System.Windows.Forms.DataGridView();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.lbl_precio1 = new System.Windows.Forms.Label();
            this.lbl_precio2 = new System.Windows.Forms.Label();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.lbl_precio3 = new System.Windows.Forms.Label();
            this.txt_precio3 = new System.Windows.Forms.TextBox();
            this.lbl_LineaProducto = new System.Windows.Forms.Label();
            this.txt_lineaProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numeroPedimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precioEspecial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.txt_compatibilidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_detallesProveedor = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vista_listar_proveedores_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.vista_listar_proveedores_productoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.vista_listar_proveedores_productoTableAdapter();
            this.lista_proveedores_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_proveedores_productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_proveedores_productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_proveedores_productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(171, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(300, 29);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(76, 46);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 22);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(293, 137);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(125, 22);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(424, 133);
            this.txt_descripcion.MaxLength = 100;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(395, 29);
            this.txt_descripcion.TabIndex = 10;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_existencia
            // 
            this.lbl_existencia.AutoSize = true;
            this.lbl_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_existencia.Location = new System.Drawing.Point(55, 84);
            this.lbl_existencia.Name = "lbl_existencia";
            this.lbl_existencia.Size = new System.Drawing.Size(110, 22);
            this.lbl_existencia.TabIndex = 5;
            this.lbl_existencia.Text = "Existencia:";
            // 
            // txt_existencia
            // 
            this.txt_existencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.Location = new System.Drawing.Point(171, 84);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(58, 29);
            this.txt_existencia.TabIndex = 3;
            this.txt_existencia.TextChanged += new System.EventHandler(this.despintarTexto);
            this.txt_existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // lbl_cantidadMinima
            // 
            this.lbl_cantidadMinima.AutoSize = true;
            this.lbl_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadMinima.Location = new System.Drawing.Point(12, 343);
            this.lbl_cantidadMinima.Name = "lbl_cantidadMinima";
            this.lbl_cantidadMinima.Size = new System.Drawing.Size(164, 44);
            this.lbl_cantidadMinima.TabIndex = 11;
            this.lbl_cantidadMinima.Text = "Cantidad mínima\r\n  en Inventario:";
            this.lbl_cantidadMinima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cantidadMinima
            // 
            this.txt_cantidadMinima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadMinima.Location = new System.Drawing.Point(32, 390);
            this.txt_cantidadMinima.Name = "txt_cantidadMinima";
            this.txt_cantidadMinima.Size = new System.Drawing.Size(121, 29);
            this.txt_cantidadMinima.TabIndex = 15;
            this.txt_cantidadMinima.TextChanged += new System.EventHandler(this.despintarTexto);
            this.txt_cantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.Location = new System.Drawing.Point(237, 177);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(181, 22);
            this.lbl_unidadMedida.TabIndex = 13;
            this.lbl_unidadMedida.Text = "Unidad de Medida:";
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.Location = new System.Drawing.Point(424, 172);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.Size = new System.Drawing.Size(163, 29);
            this.txt_unidadMedida.TabIndex = 11;
            this.txt_unidadMedida.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_AgregarProveedor
            // 
            this.lbl_AgregarProveedor.AutoSize = true;
            this.lbl_AgregarProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AgregarProveedor.Location = new System.Drawing.Point(382, 459);
            this.lbl_AgregarProveedor.Name = "lbl_AgregarProveedor";
            this.lbl_AgregarProveedor.Size = new System.Drawing.Size(126, 44);
            this.lbl_AgregarProveedor.TabIndex = 17;
            this.lbl_AgregarProveedor.Text = "Agregar \r\nProveedores";
            this.lbl_AgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_completar
            // 
            this.lbl_completar.AutoSize = true;
            this.lbl_completar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completar.Location = new System.Drawing.Point(705, 365);
            this.lbl_completar.Name = "lbl_completar";
            this.lbl_completar.Size = new System.Drawing.Size(86, 22);
            this.lbl_completar.TabIndex = 18;
            this.lbl_completar.Text = "Guardar";
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
            this.vista_listar_proveedores_productoDataGridView.Location = new System.Drawing.Point(740, 460);
            this.vista_listar_proveedores_productoDataGridView.Name = "vista_listar_proveedores_productoDataGridView";
            this.vista_listar_proveedores_productoDataGridView.ReadOnly = true;
            this.vista_listar_proveedores_productoDataGridView.Size = new System.Drawing.Size(49, 43);
            this.vista_listar_proveedores_productoDataGridView.TabIndex = 18;
            // 
            // txt_precio1
            // 
            this.txt_precio1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio1.Enabled = false;
            this.txt_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(112, 173);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(117, 29);
            this.txt_precio1.TabIndex = 5;
            this.txt_precio1.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_precio1
            // 
            this.lbl_precio1.AutoSize = true;
            this.lbl_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio1.Location = new System.Drawing.Point(12, 174);
            this.lbl_precio1.Name = "lbl_precio1";
            this.lbl_precio1.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio1.TabIndex = 20;
            this.lbl_precio1.Text = "Precio 1:";
            // 
            // lbl_precio2
            // 
            this.lbl_precio2.AutoSize = true;
            this.lbl_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio2.Location = new System.Drawing.Point(12, 208);
            this.lbl_precio2.Name = "lbl_precio2";
            this.lbl_precio2.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio2.TabIndex = 22;
            this.lbl_precio2.Text = "Precio 2:";
            // 
            // txt_precio2
            // 
            this.txt_precio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio2.Enabled = false;
            this.txt_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio2.Location = new System.Drawing.Point(112, 208);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(117, 29);
            this.txt_precio2.TabIndex = 6;
            this.txt_precio2.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_precio3
            // 
            this.lbl_precio3.AutoSize = true;
            this.lbl_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio3.Location = new System.Drawing.Point(12, 243);
            this.lbl_precio3.Name = "lbl_precio3";
            this.lbl_precio3.Size = new System.Drawing.Size(91, 22);
            this.lbl_precio3.TabIndex = 24;
            this.lbl_precio3.Text = "Precio 3:";
            // 
            // txt_precio3
            // 
            this.txt_precio3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio3.Enabled = false;
            this.txt_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio3.Location = new System.Drawing.Point(112, 243);
            this.txt_precio3.Name = "txt_precio3";
            this.txt_precio3.Size = new System.Drawing.Size(118, 29);
            this.txt_precio3.TabIndex = 7;
            this.txt_precio3.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_LineaProducto
            // 
            this.lbl_LineaProducto.AutoSize = true;
            this.lbl_LineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LineaProducto.Location = new System.Drawing.Point(12, 11);
            this.lbl_LineaProducto.Name = "lbl_LineaProducto";
            this.lbl_LineaProducto.Size = new System.Drawing.Size(153, 22);
            this.lbl_LineaProducto.TabIndex = 26;
            this.lbl_LineaProducto.Text = "Línea producto:";
            // 
            // txt_lineaProducto
            // 
            this.txt_lineaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_lineaProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_lineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lineaProducto.Location = new System.Drawing.Point(171, 8);
            this.txt_lineaProducto.MaxLength = 4;
            this.txt_lineaProducto.Name = "txt_lineaProducto";
            this.txt_lineaProducto.Size = new System.Drawing.Size(181, 29);
            this.txt_lineaProducto.TabIndex = 1;
            this.txt_lineaProducto.TextChanged += new System.EventHandler(this.despintarTexto);
            this.txt_lineaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio1_KeyPress);
            this.txt_lineaProducto.Leave += new System.EventHandler(this.txt_lineaProducto_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Agregar Imagen";
            // 
            // txt_año
            // 
            this.txt_año.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_año.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_año.Location = new System.Drawing.Point(690, 238);
            this.txt_año.MaxLength = 4;
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(115, 32);
            this.txt_año.TabIndex = 14;
            this.txt_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(723, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Año:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Marca perteneciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Modelo perteneciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "No. pedimento:";
            // 
            // txt_numeroPedimento
            // 
            this.txt_numeroPedimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numeroPedimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPedimento.Location = new System.Drawing.Point(424, 93);
            this.txt_numeroPedimento.MaxLength = 5;
            this.txt_numeroPedimento.Name = "txt_numeroPedimento";
            this.txt_numeroPedimento.Size = new System.Drawing.Size(104, 29);
            this.txt_numeroPedimento.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 44);
            this.label3.TabIndex = 39;
            this.label3.Text = "Precio \r\nEspecial:";
            // 
            // txt_precioEspecial
            // 
            this.txt_precioEspecial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precioEspecial.Enabled = false;
            this.txt_precioEspecial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioEspecial.Location = new System.Drawing.Point(111, 292);
            this.txt_precioEspecial.Name = "txt_precioEspecial";
            this.txt_precioEspecial.Size = new System.Drawing.Size(118, 29);
            this.txt_precioEspecial.TabIndex = 8;
            this.txt_precioEspecial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDecimal);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Compatibilidad con otros vehículos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Image = global::Proyecto_Glacial.Properties.Resources.addPictureBlue;
            this.btn_examinar.Location = new System.Drawing.Point(695, 11);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(80, 80);
            this.btn_examinar.TabIndex = 28;
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Glacial.Properties.Resources._Insert_image_here__svg;
            this.pictureBox1.Location = new System.Drawing.Point(534, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_Guardar.Location = new System.Drawing.Point(709, 278);
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
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(534, 460);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(80, 80);
            this.btn_AgregarProveedor.TabIndex = 15;
            this.btn_AgregarProveedor.UseVisualStyleBackColor = true;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(113, 138);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(116, 29);
            this.txt_precio.TabIndex = 4;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDecimal);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(261, 241);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(184, 32);
            this.cmb_modelo.TabIndex = 12;
            // 
            // cmb_marca
            // 
            this.cmb_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(483, 241);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(184, 32);
            this.cmb_marca.TabIndex = 13;
            // 
            // txt_compatibilidad
            // 
            this.txt_compatibilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_compatibilidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_compatibilidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compatibilidad.Location = new System.Drawing.Point(11, 459);
            this.txt_compatibilidad.Multiline = true;
            this.txt_compatibilidad.Name = "txt_compatibilidad";
            this.txt_compatibilidad.Size = new System.Drawing.Size(797, 80);
            this.txt_compatibilidad.TabIndex = 17;
            this.txt_compatibilidad.Text = "NINGUNO...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Detalles del Proveedor:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_detallesProveedor
            // 
            this.txt_detallesProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_detallesProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_detallesProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detallesProveedor.Location = new System.Drawing.Point(256, 324);
            this.txt_detallesProveedor.Multiline = true;
            this.txt_detallesProveedor.Name = "txt_detallesProveedor";
            this.txt_detallesProveedor.Size = new System.Drawing.Size(411, 63);
            this.txt_detallesProveedor.TabIndex = 16;
            this.txt_detallesProveedor.Text = "...";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de proveedor";
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
            // vista_listar_proveedores_productoBindingSource
            // 
            this.vista_listar_proveedores_productoBindingSource.DataMember = "vista_listar_proveedores_producto";
            this.vista_listar_proveedores_productoBindingSource.DataSource = this.glacial_almacenDataSet;
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
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // vista_listar_proveedores_productoTableAdapter
            // 
            this.vista_listar_proveedores_productoTableAdapter.ClearBeforeFill = true;
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
            this.ClientSize = new System.Drawing.Size(831, 545);
            this.Controls.Add(this.txt_detallesProveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.cmb_modelo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_compatibilidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_precioEspecial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numeroPedimento);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_InventarioAgregar";
            this.Text = "Inventario - Agregar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_InventarioAgregar_FormClosed);
            this.Load += new System.EventHandler(this.frm_InventarioAgregar_Load);
            this.MouseEnter += new System.EventHandler(this.frm_InventarioAgregar_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_listar_proveedores_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numeroPedimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precioEspecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.TextBox txt_compatibilidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_detallesProveedor;
    }
}