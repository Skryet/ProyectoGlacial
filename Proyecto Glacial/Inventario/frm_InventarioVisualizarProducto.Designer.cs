namespace Proyecto_Glacial.Inventario
{
    partial class frm_InventarioVisualizarProducto
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
            System.Windows.Forms.Label id_linea_productoLabel1;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel1;
            System.Windows.Forms.Label precio1Label1;
            System.Windows.Forms.Label precio2Label1;
            System.Windows.Forms.Label precio3Label1;
            System.Windows.Forms.Label marcaCarroLabel1;
            System.Windows.Forms.Label anioCarroLabel1;
            System.Windows.Forms.Label modeloCarroLabel1;
            System.Windows.Forms.Label unidad_medidaLabel1;
            System.Windows.Forms.Label precio_especialLabel;
            System.Windows.Forms.Label compatibilidadCarrosLabel1;
            System.Windows.Forms.Label numeroPedimentoLabel1;
            System.Windows.Forms.Label datos_proveedorLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.txt_lineaNombre = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.marcaCarroTextBox = new System.Windows.Forms.TextBox();
            this.anioCarroTextBox = new System.Windows.Forms.TextBox();
            this.modeloCarroTextBox = new System.Windows.Forms.TextBox();
            this.unidad_medidaTextBox = new System.Windows.Forms.TextBox();
            this.precio_especialTextBox = new System.Windows.Forms.TextBox();
            this.compatibilidadCarrosTextBox = new System.Windows.Forms.TextBox();
            this.numeroPedimentoTextBox = new System.Windows.Forms.TextBox();
            this.txt_lineaCodigo = new System.Windows.Forms.TextBox();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.datos_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.txt_precio3 = new System.Windows.Forms.TextBox();
            id_linea_productoLabel1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel1 = new System.Windows.Forms.Label();
            precio1Label1 = new System.Windows.Forms.Label();
            precio2Label1 = new System.Windows.Forms.Label();
            precio3Label1 = new System.Windows.Forms.Label();
            marcaCarroLabel1 = new System.Windows.Forms.Label();
            anioCarroLabel1 = new System.Windows.Forms.Label();
            modeloCarroLabel1 = new System.Windows.Forms.Label();
            unidad_medidaLabel1 = new System.Windows.Forms.Label();
            precio_especialLabel = new System.Windows.Forms.Label();
            compatibilidadCarrosLabel1 = new System.Windows.Forms.Label();
            numeroPedimentoLabel1 = new System.Windows.Forms.Label();
            datos_proveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_linea_productoLabel1
            // 
            id_linea_productoLabel1.AutoSize = true;
            id_linea_productoLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_linea_productoLabel1.Location = new System.Drawing.Point(56, 44);
            id_linea_productoLabel1.Name = "id_linea_productoLabel1";
            id_linea_productoLabel1.Size = new System.Drawing.Size(91, 24);
            id_linea_productoLabel1.TabIndex = 70;
            id_linea_productoLabel1.Text = "Código:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(74, 83);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(73, 24);
            nombreLabel1.TabIndex = 71;
            nombreLabel1.Text = "Línea:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(6, 138);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(140, 24);
            descripcionLabel.TabIndex = 72;
            descripcionLabel.Text = "Descripción:";
            // 
            // existenciaLabel1
            // 
            existenciaLabel1.AutoSize = true;
            existenciaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel1.Location = new System.Drawing.Point(25, 194);
            existenciaLabel1.Name = "existenciaLabel1";
            existenciaLabel1.Size = new System.Drawing.Size(121, 24);
            existenciaLabel1.TabIndex = 73;
            existenciaLabel1.Text = "Existencia:";
            // 
            // precio1Label1
            // 
            precio1Label1.AutoSize = true;
            precio1Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio1Label1.Location = new System.Drawing.Point(46, 239);
            precio1Label1.Name = "precio1Label1";
            precio1Label1.Size = new System.Drawing.Size(100, 24);
            precio1Label1.TabIndex = 74;
            precio1Label1.Text = "Precio 1:";
            // 
            // precio2Label1
            // 
            precio2Label1.AutoSize = true;
            precio2Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio2Label1.Location = new System.Drawing.Point(46, 275);
            precio2Label1.Name = "precio2Label1";
            precio2Label1.Size = new System.Drawing.Size(100, 24);
            precio2Label1.TabIndex = 75;
            precio2Label1.Text = "Precio 2:";
            // 
            // precio3Label1
            // 
            precio3Label1.AutoSize = true;
            precio3Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio3Label1.Location = new System.Drawing.Point(46, 308);
            precio3Label1.Name = "precio3Label1";
            precio3Label1.Size = new System.Drawing.Size(100, 24);
            precio3Label1.TabIndex = 76;
            precio3Label1.Text = "Precio 3:";
            // 
            // marcaCarroLabel1
            // 
            marcaCarroLabel1.AutoSize = true;
            marcaCarroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaCarroLabel1.Location = new System.Drawing.Point(296, 196);
            marcaCarroLabel1.Name = "marcaCarroLabel1";
            marcaCarroLabel1.Size = new System.Drawing.Size(79, 24);
            marcaCarroLabel1.TabIndex = 77;
            marcaCarroLabel1.Text = "Marca:";
            // 
            // anioCarroLabel1
            // 
            anioCarroLabel1.AutoSize = true;
            anioCarroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anioCarroLabel1.Location = new System.Drawing.Point(296, 334);
            anioCarroLabel1.Name = "anioCarroLabel1";
            anioCarroLabel1.Size = new System.Drawing.Size(58, 24);
            anioCarroLabel1.TabIndex = 78;
            anioCarroLabel1.Text = "Año:";
            // 
            // modeloCarroLabel1
            // 
            modeloCarroLabel1.AutoSize = true;
            modeloCarroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloCarroLabel1.Location = new System.Drawing.Point(296, 272);
            modeloCarroLabel1.Name = "modeloCarroLabel1";
            modeloCarroLabel1.Size = new System.Drawing.Size(91, 24);
            modeloCarroLabel1.TabIndex = 79;
            modeloCarroLabel1.Text = "Modelo:";
            // 
            // unidad_medidaLabel1
            // 
            unidad_medidaLabel1.AutoSize = true;
            unidad_medidaLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidad_medidaLabel1.Location = new System.Drawing.Point(644, 228);
            unidad_medidaLabel1.Name = "unidad_medidaLabel1";
            unidad_medidaLabel1.Size = new System.Drawing.Size(118, 48);
            unidad_medidaLabel1.TabIndex = 80;
            unidad_medidaLabel1.Text = "Unidad de \r\nMedida:";
            // 
            // precio_especialLabel
            // 
            precio_especialLabel.AutoSize = true;
            precio_especialLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_especialLabel.Location = new System.Drawing.Point(46, 427);
            precio_especialLabel.Name = "precio_especialLabel";
            precio_especialLabel.Size = new System.Drawing.Size(174, 24);
            precio_especialLabel.TabIndex = 81;
            precio_especialLabel.Text = "Precio Especial:";
            // 
            // compatibilidadCarrosLabel1
            // 
            compatibilidadCarrosLabel1.AutoSize = true;
            compatibilidadCarrosLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            compatibilidadCarrosLabel1.Location = new System.Drawing.Point(12, 386);
            compatibilidadCarrosLabel1.Name = "compatibilidadCarrosLabel1";
            compatibilidadCarrosLabel1.Size = new System.Drawing.Size(219, 24);
            compatibilidadCarrosLabel1.TabIndex = 82;
            compatibilidadCarrosLabel1.Text = "Compatibilidad Con:";
            // 
            // numeroPedimentoLabel1
            // 
            numeroPedimentoLabel1.AutoSize = true;
            numeroPedimentoLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroPedimentoLabel1.Location = new System.Drawing.Point(12, 492);
            numeroPedimentoLabel1.Name = "numeroPedimentoLabel1";
            numeroPedimentoLabel1.Size = new System.Drawing.Size(242, 24);
            numeroPedimentoLabel1.TabIndex = 83;
            numeroPedimentoLabel1.Text = "Número de pedimento:";
            // 
            // datos_proveedorLabel
            // 
            datos_proveedorLabel.AutoSize = true;
            datos_proveedorLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datos_proveedorLabel.Location = new System.Drawing.Point(454, 413);
            datos_proveedorLabel.Name = "datos_proveedorLabel";
            datos_proveedorLabel.Size = new System.Drawing.Size(246, 24);
            datos_proveedorLabel.TabIndex = 86;
            datos_proveedorLabel.Text = "Detalles del Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "Detalles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(682, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
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
            // txt_lineaNombre
            // 
            this.txt_lineaNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "id_linea_producto", true));
            this.txt_lineaNombre.Enabled = false;
            this.txt_lineaNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lineaNombre.Location = new System.Drawing.Point(690, 28);
            this.txt_lineaNombre.Name = "txt_lineaNombre";
            this.txt_lineaNombre.Size = new System.Drawing.Size(10, 32);
            this.txt_lineaNombre.TabIndex = 71;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(153, 82);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(491, 29);
            this.nombreTextBox.TabIndex = 72;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(153, 117);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(491, 68);
            this.descripcionTextBox.TabIndex = 73;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "existencia", true));
            this.existenciaTextBox.Enabled = false;
            this.existenciaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaTextBox.Location = new System.Drawing.Point(152, 191);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(118, 29);
            this.existenciaTextBox.TabIndex = 74;
            this.existenciaTextBox.Leave += new System.EventHandler(this.existenciaTextBox_Leave);
            // 
            // marcaCarroTextBox
            // 
            this.marcaCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "marcaCarro", true));
            this.marcaCarroTextBox.Enabled = false;
            this.marcaCarroTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaCarroTextBox.Location = new System.Drawing.Point(300, 230);
            this.marcaCarroTextBox.Name = "marcaCarroTextBox";
            this.marcaCarroTextBox.Size = new System.Drawing.Size(324, 29);
            this.marcaCarroTextBox.TabIndex = 78;
            // 
            // anioCarroTextBox
            // 
            this.anioCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "anioCarro", true));
            this.anioCarroTextBox.Enabled = false;
            this.anioCarroTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioCarroTextBox.Location = new System.Drawing.Point(300, 361);
            this.anioCarroTextBox.Name = "anioCarroTextBox";
            this.anioCarroTextBox.Size = new System.Drawing.Size(324, 29);
            this.anioCarroTextBox.TabIndex = 79;
            // 
            // modeloCarroTextBox
            // 
            this.modeloCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "modeloCarro", true));
            this.modeloCarroTextBox.Enabled = false;
            this.modeloCarroTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloCarroTextBox.Location = new System.Drawing.Point(300, 302);
            this.modeloCarroTextBox.Name = "modeloCarroTextBox";
            this.modeloCarroTextBox.Size = new System.Drawing.Size(324, 29);
            this.modeloCarroTextBox.TabIndex = 80;
            // 
            // unidad_medidaTextBox
            // 
            this.unidad_medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "unidad_medida", true));
            this.unidad_medidaTextBox.Enabled = false;
            this.unidad_medidaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_medidaTextBox.Location = new System.Drawing.Point(643, 287);
            this.unidad_medidaTextBox.Name = "unidad_medidaTextBox";
            this.unidad_medidaTextBox.Size = new System.Drawing.Size(324, 29);
            this.unidad_medidaTextBox.TabIndex = 81;
            // 
            // precio_especialTextBox
            // 
            this.precio_especialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio_especial", true));
            this.precio_especialTextBox.Enabled = false;
            this.precio_especialTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_especialTextBox.Location = new System.Drawing.Point(226, 424);
            this.precio_especialTextBox.Name = "precio_especialTextBox";
            this.precio_especialTextBox.Size = new System.Drawing.Size(132, 32);
            this.precio_especialTextBox.TabIndex = 82;
            // 
            // compatibilidadCarrosTextBox
            // 
            this.compatibilidadCarrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "compatibilidadCarros", true));
            this.compatibilidadCarrosTextBox.Enabled = false;
            this.compatibilidadCarrosTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatibilidadCarrosTextBox.Location = new System.Drawing.Point(10, 413);
            this.compatibilidadCarrosTextBox.Multiline = true;
            this.compatibilidadCarrosTextBox.Name = "compatibilidadCarrosTextBox";
            this.compatibilidadCarrosTextBox.Size = new System.Drawing.Size(438, 59);
            this.compatibilidadCarrosTextBox.TabIndex = 83;
            // 
            // numeroPedimentoTextBox
            // 
            this.numeroPedimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "numeroPedimento", true));
            this.numeroPedimentoTextBox.Enabled = false;
            this.numeroPedimentoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroPedimentoTextBox.Location = new System.Drawing.Point(16, 516);
            this.numeroPedimentoTextBox.Name = "numeroPedimentoTextBox";
            this.numeroPedimentoTextBox.Size = new System.Drawing.Size(193, 29);
            this.numeroPedimentoTextBox.TabIndex = 84;
            // 
            // txt_lineaCodigo
            // 
            this.txt_lineaCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "linea_producto_codigo", true));
            this.txt_lineaCodigo.Location = new System.Drawing.Point(798, 31);
            this.txt_lineaCodigo.Name = "txt_lineaCodigo";
            this.txt_lineaCodigo.Size = new System.Drawing.Size(10, 20);
            this.txt_lineaCodigo.TabIndex = 85;
            // 
            // txt_linea
            // 
            this.txt_linea.Enabled = false;
            this.txt_linea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linea.Location = new System.Drawing.Point(153, 44);
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.Size = new System.Drawing.Size(491, 29);
            this.txt_linea.TabIndex = 86;
            // 
            // datos_proveedorTextBox
            // 
            this.datos_proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "datos_proveedor", true));
            this.datos_proveedorTextBox.Enabled = false;
            this.datos_proveedorTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_proveedorTextBox.Location = new System.Drawing.Point(458, 440);
            this.datos_proveedorTextBox.Name = "datos_proveedorTextBox";
            this.datos_proveedorTextBox.Size = new System.Drawing.Size(304, 29);
            this.datos_proveedorTextBox.TabIndex = 87;
            // 
            // txt_precio1
            // 
            this.txt_precio1.Enabled = false;
            this.txt_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(154, 238);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(116, 29);
            this.txt_precio1.TabIndex = 88;
            // 
            // txt_precio2
            // 
            this.txt_precio2.Enabled = false;
            this.txt_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio2.Location = new System.Drawing.Point(154, 275);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(116, 29);
            this.txt_precio2.TabIndex = 89;
            // 
            // txt_precio3
            // 
            this.txt_precio3.Enabled = false;
            this.txt_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio3.Location = new System.Drawing.Point(154, 310);
            this.txt_precio3.Name = "txt_precio3";
            this.txt_precio3.Size = new System.Drawing.Size(116, 29);
            this.txt_precio3.TabIndex = 89;
            // 
            // frm_InventarioVisualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 550);
            this.Controls.Add(this.txt_precio3);
            this.Controls.Add(this.txt_precio2);
            this.Controls.Add(this.txt_precio1);
            this.Controls.Add(datos_proveedorLabel);
            this.Controls.Add(this.datos_proveedorTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_linea);
            this.Controls.Add(this.txt_lineaCodigo);
            this.Controls.Add(numeroPedimentoLabel1);
            this.Controls.Add(this.numeroPedimentoTextBox);
            this.Controls.Add(compatibilidadCarrosLabel1);
            this.Controls.Add(this.compatibilidadCarrosTextBox);
            this.Controls.Add(precio_especialLabel);
            this.Controls.Add(this.precio_especialTextBox);
            this.Controls.Add(unidad_medidaLabel1);
            this.Controls.Add(this.unidad_medidaTextBox);
            this.Controls.Add(modeloCarroLabel1);
            this.Controls.Add(this.modeloCarroTextBox);
            this.Controls.Add(anioCarroLabel1);
            this.Controls.Add(this.anioCarroTextBox);
            this.Controls.Add(marcaCarroLabel1);
            this.Controls.Add(this.marcaCarroTextBox);
            this.Controls.Add(precio3Label1);
            this.Controls.Add(precio2Label1);
            this.Controls.Add(precio1Label1);
            this.Controls.Add(existenciaLabel1);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(id_linea_productoLabel1);
            this.Controls.Add(this.txt_lineaNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_InventarioVisualizarProducto";
            this.Text = "Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_InventarioVisualizarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_lineaNombre;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox marcaCarroTextBox;
        private System.Windows.Forms.TextBox anioCarroTextBox;
        private System.Windows.Forms.TextBox modeloCarroTextBox;
        private System.Windows.Forms.TextBox unidad_medidaTextBox;
        private System.Windows.Forms.TextBox precio_especialTextBox;
        private System.Windows.Forms.TextBox compatibilidadCarrosTextBox;
        private System.Windows.Forms.TextBox numeroPedimentoTextBox;
        private System.Windows.Forms.TextBox txt_lineaCodigo;
        private System.Windows.Forms.TextBox txt_linea;
        private System.Windows.Forms.TextBox datos_proveedorTextBox;
        private System.Windows.Forms.TextBox txt_precio1;
        private System.Windows.Forms.TextBox txt_precio2;
        private System.Windows.Forms.TextBox txt_precio3;
    }
}