namespace Proyecto_Glacial.Inventario
{
    partial class frm_InventarioModificar
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label id_linea_productoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label cantidad_minimaLabel;
            System.Windows.Forms.Label unidad_medidaLabel;
            System.Windows.Forms.Label precio1Label;
            System.Windows.Forms.Label precio2Label;
            System.Windows.Forms.Label precio3Label;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label marcaCarroLabel;
            System.Windows.Forms.Label anioCarroLabel;
            System.Windows.Forms.Label modeloCarroLabel;
            System.Windows.Forms.Label numeroPedimentoLabel;
            System.Windows.Forms.Label precio_especialLabel;
            System.Windows.Forms.Label compatibilidadCarrosLabel;
            System.Windows.Forms.Label precioLabel;
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.txt_lineaProducto = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.txt_cantidadMinima = new System.Windows.Forms.TextBox();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_marcaCarro = new System.Windows.Forms.TextBox();
            this.txt_anioCarro = new System.Windows.Forms.TextBox();
            this.txt_modeloCarro = new System.Windows.Forms.TextBox();
            this.txt_numeroPedimento = new System.Windows.Forms.TextBox();
            this.txt_precioEspecial = new System.Windows.Forms.TextBox();
            this.txt_compatibilidad = new System.Windows.Forms.TextBox();
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.txt_precio3 = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            id_linea_productoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            cantidad_minimaLabel = new System.Windows.Forms.Label();
            unidad_medidaLabel = new System.Windows.Forms.Label();
            precio1Label = new System.Windows.Forms.Label();
            precio2Label = new System.Windows.Forms.Label();
            precio3Label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            marcaCarroLabel = new System.Windows.Forms.Label();
            anioCarroLabel = new System.Windows.Forms.Label();
            modeloCarroLabel = new System.Windows.Forms.Label();
            numeroPedimentoLabel = new System.Windows.Forms.Label();
            precio_especialLabel = new System.Windows.Forms.Label();
            compatibilidadCarrosLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(29, 75);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 24);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Línea:";
            // 
            // id_linea_productoLabel
            // 
            id_linea_productoLabel.AutoSize = true;
            id_linea_productoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_linea_productoLabel.Location = new System.Drawing.Point(29, 117);
            id_linea_productoLabel.Name = "id_linea_productoLabel";
            id_linea_productoLabel.Size = new System.Drawing.Size(91, 24);
            id_linea_productoLabel.TabIndex = 2;
            id_linea_productoLabel.Text = "Código:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(277, 117);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(140, 24);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripción:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel.Location = new System.Drawing.Point(3, 261);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(121, 24);
            existenciaLabel.TabIndex = 6;
            existenciaLabel.Text = "Existencia:";
            // 
            // cantidad_minimaLabel
            // 
            cantidad_minimaLabel.AutoSize = true;
            cantidad_minimaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidad_minimaLabel.Location = new System.Drawing.Point(3, 310);
            cantidad_minimaLabel.Name = "cantidad_minimaLabel";
            cantidad_minimaLabel.Size = new System.Drawing.Size(187, 24);
            cantidad_minimaLabel.TabIndex = 8;
            cantidad_minimaLabel.Text = "Cantidad Mínima:";
            // 
            // unidad_medidaLabel
            // 
            unidad_medidaLabel.AutoSize = true;
            unidad_medidaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidad_medidaLabel.Location = new System.Drawing.Point(4, 352);
            unidad_medidaLabel.Name = "unidad_medidaLabel";
            unidad_medidaLabel.Size = new System.Drawing.Size(198, 24);
            unidad_medidaLabel.TabIndex = 10;
            unidad_medidaLabel.Text = "Unidad de Medida:";
            // 
            // precio1Label
            // 
            precio1Label.AutoSize = true;
            precio1Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio1Label.Location = new System.Drawing.Point(14, 210);
            precio1Label.Name = "precio1Label";
            precio1Label.Size = new System.Drawing.Size(100, 24);
            precio1Label.TabIndex = 12;
            precio1Label.Text = "Precio 1:";
            // 
            // precio2Label
            // 
            precio2Label.AutoSize = true;
            precio2Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio2Label.Location = new System.Drawing.Point(277, 211);
            precio2Label.Name = "precio2Label";
            precio2Label.Size = new System.Drawing.Size(100, 24);
            precio2Label.TabIndex = 14;
            precio2Label.Text = "Precio 2:";
            // 
            // precio3Label
            // 
            precio3Label.AutoSize = true;
            precio3Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio3Label.Location = new System.Drawing.Point(530, 211);
            precio3Label.Name = "precio3Label";
            precio3Label.Size = new System.Drawing.Size(100, 24);
            precio3Label.TabIndex = 16;
            precio3Label.Text = "Precio 3:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            label2.Location = new System.Drawing.Point(604, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 24);
            label2.TabIndex = 20;
            label2.Text = "Actualizar";
            // 
            // marcaCarroLabel
            // 
            marcaCarroLabel.AutoSize = true;
            marcaCarroLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaCarroLabel.Location = new System.Drawing.Point(451, 310);
            marcaCarroLabel.Name = "marcaCarroLabel";
            marcaCarroLabel.Size = new System.Drawing.Size(73, 22);
            marcaCarroLabel.TabIndex = 21;
            marcaCarroLabel.Text = "Marca:";
            // 
            // anioCarroLabel
            // 
            anioCarroLabel.AutoSize = true;
            anioCarroLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anioCarroLabel.Location = new System.Drawing.Point(464, 384);
            anioCarroLabel.Name = "anioCarroLabel";
            anioCarroLabel.Size = new System.Drawing.Size(52, 22);
            anioCarroLabel.TabIndex = 23;
            anioCarroLabel.Text = "Año:";
            // 
            // modeloCarroLabel
            // 
            modeloCarroLabel.AutoSize = true;
            modeloCarroLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloCarroLabel.Location = new System.Drawing.Point(441, 351);
            modeloCarroLabel.Name = "modeloCarroLabel";
            modeloCarroLabel.Size = new System.Drawing.Size(82, 22);
            modeloCarroLabel.TabIndex = 25;
            modeloCarroLabel.Text = "Modelo:";
            // 
            // numeroPedimentoLabel
            // 
            numeroPedimentoLabel.AutoSize = true;
            numeroPedimentoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroPedimentoLabel.Location = new System.Drawing.Point(421, 430);
            numeroPedimentoLabel.Name = "numeroPedimentoLabel";
            numeroPedimentoLabel.Size = new System.Drawing.Size(218, 22);
            numeroPedimentoLabel.TabIndex = 27;
            numeroPedimentoLabel.Text = "Número de pedimento:";
            // 
            // precio_especialLabel
            // 
            precio_especialLabel.AutoSize = true;
            precio_especialLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_especialLabel.Location = new System.Drawing.Point(390, 259);
            precio_especialLabel.Name = "precio_especialLabel";
            precio_especialLabel.Size = new System.Drawing.Size(156, 22);
            precio_especialLabel.TabIndex = 29;
            precio_especialLabel.Text = "Precio especial:";
            // 
            // compatibilidadCarrosLabel
            // 
            compatibilidadCarrosLabel.AutoSize = true;
            compatibilidadCarrosLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            compatibilidadCarrosLabel.Location = new System.Drawing.Point(12, 397);
            compatibilidadCarrosLabel.Name = "compatibilidadCarrosLabel";
            compatibilidadCarrosLabel.Size = new System.Drawing.Size(159, 22);
            compatibilidadCarrosLabel.TabIndex = 31;
            compatibilidadCarrosLabel.Text = "Compatible con:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(43, 164);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(77, 24);
            precioLabel.TabIndex = 35;
            precioLabel.Text = "Costo:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "nombre", true));
            this.txt_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(112, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(328, 32);
            this.txt_nombre.TabIndex = 2;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_lineaProducto
            // 
            this.txt_lineaProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "id_linea_producto", true));
            this.txt_lineaProducto.Enabled = false;
            this.txt_lineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lineaProducto.Location = new System.Drawing.Point(133, 117);
            this.txt_lineaProducto.Name = "txt_lineaProducto";
            this.txt_lineaProducto.Size = new System.Drawing.Size(132, 29);
            this.txt_lineaProducto.TabIndex = 1;
            this.txt_lineaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descripcion", true));
            this.txt_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(280, 144);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(487, 60);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_existencia
            // 
            this.txt_existencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "existencia", true));
            this.txt_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.Location = new System.Drawing.Point(133, 254);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(141, 29);
            this.txt_existencia.TabIndex = 7;
            this.txt_existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_cantidadMinima
            // 
            this.txt_cantidadMinima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "cantidad_minima", true));
            this.txt_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadMinima.Location = new System.Drawing.Point(203, 302);
            this.txt_cantidadMinima.Name = "txt_cantidadMinima";
            this.txt_cantidadMinima.Size = new System.Drawing.Size(134, 32);
            this.txt_cantidadMinima.TabIndex = 8;
            this.txt_cantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "unidad_medida", true));
            this.txt_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.Location = new System.Drawing.Point(203, 349);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.Size = new System.Drawing.Size(145, 32);
            this.txt_unidadMedida.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modifcar Producto";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_actualizar.Location = new System.Drawing.Point(608, 12);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_marcaCarro
            // 
            this.txt_marcaCarro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "marcaCarro", true));
            this.txt_marcaCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marcaCarro.Location = new System.Drawing.Point(534, 307);
            this.txt_marcaCarro.Name = "txt_marcaCarro";
            this.txt_marcaCarro.Size = new System.Drawing.Size(177, 29);
            this.txt_marcaCarro.TabIndex = 22;
            // 
            // txt_anioCarro
            // 
            this.txt_anioCarro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "anioCarro", true));
            this.txt_anioCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anioCarro.Location = new System.Drawing.Point(534, 377);
            this.txt_anioCarro.MaxLength = 4;
            this.txt_anioCarro.Name = "txt_anioCarro";
            this.txt_anioCarro.Size = new System.Drawing.Size(177, 29);
            this.txt_anioCarro.TabIndex = 24;
            // 
            // txt_modeloCarro
            // 
            this.txt_modeloCarro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "modeloCarro", true));
            this.txt_modeloCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modeloCarro.Location = new System.Drawing.Point(534, 342);
            this.txt_modeloCarro.Name = "txt_modeloCarro";
            this.txt_modeloCarro.Size = new System.Drawing.Size(177, 29);
            this.txt_modeloCarro.TabIndex = 26;
            // 
            // txt_numeroPedimento
            // 
            this.txt_numeroPedimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "numeroPedimento", true));
            this.txt_numeroPedimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPedimento.Location = new System.Drawing.Point(646, 427);
            this.txt_numeroPedimento.Name = "txt_numeroPedimento";
            this.txt_numeroPedimento.Size = new System.Drawing.Size(121, 29);
            this.txt_numeroPedimento.TabIndex = 28;
            // 
            // txt_precioEspecial
            // 
            this.txt_precioEspecial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio_especial", true));
            this.txt_precioEspecial.Enabled = false;
            this.txt_precioEspecial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioEspecial.Location = new System.Drawing.Point(552, 256);
            this.txt_precioEspecial.Name = "txt_precioEspecial";
            this.txt_precioEspecial.Size = new System.Drawing.Size(175, 29);
            this.txt_precioEspecial.TabIndex = 30;
            // 
            // txt_compatibilidad
            // 
            this.txt_compatibilidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "compatibilidadCarros", true));
            this.txt_compatibilidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compatibilidad.Location = new System.Drawing.Point(3, 422);
            this.txt_compatibilidad.Multiline = true;
            this.txt_compatibilidad.Name = "txt_compatibilidad";
            this.txt_compatibilidad.Size = new System.Drawing.Size(387, 49);
            this.txt_compatibilidad.TabIndex = 32;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(369, 40);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 34;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(133, 164);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(132, 29);
            this.txt_precio.TabIndex = 37;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave_1);
            // 
            // txt_precio1
            // 
            this.txt_precio1.Enabled = false;
            this.txt_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(133, 210);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(132, 29);
            this.txt_precio1.TabIndex = 38;
            // 
            // txt_precio2
            // 
            this.txt_precio2.Enabled = false;
            this.txt_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio2.Location = new System.Drawing.Point(383, 210);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(141, 29);
            this.txt_precio2.TabIndex = 39;
            // 
            // txt_precio3
            // 
            this.txt_precio3.Enabled = false;
            this.txt_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio3.Location = new System.Drawing.Point(627, 210);
            this.txt_precio3.Name = "txt_precio3";
            this.txt_precio3.Size = new System.Drawing.Size(141, 29);
            this.txt_precio3.TabIndex = 40;
            // 
            // frm_InventarioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.txt_precio3);
            this.Controls.Add(this.txt_precio2);
            this.Controls.Add(this.txt_precio1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(compatibilidadCarrosLabel);
            this.Controls.Add(this.txt_compatibilidad);
            this.Controls.Add(precio_especialLabel);
            this.Controls.Add(this.txt_precioEspecial);
            this.Controls.Add(numeroPedimentoLabel);
            this.Controls.Add(this.txt_numeroPedimento);
            this.Controls.Add(modeloCarroLabel);
            this.Controls.Add(this.txt_modeloCarro);
            this.Controls.Add(anioCarroLabel);
            this.Controls.Add(this.txt_anioCarro);
            this.Controls.Add(marcaCarroLabel);
            this.Controls.Add(this.txt_marcaCarro);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(precio3Label);
            this.Controls.Add(precio2Label);
            this.Controls.Add(precio1Label);
            this.Controls.Add(unidad_medidaLabel);
            this.Controls.Add(this.txt_unidadMedida);
            this.Controls.Add(cantidad_minimaLabel);
            this.Controls.Add(this.txt_cantidadMinima);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(id_linea_productoLabel);
            this.Controls.Add(this.txt_lineaProducto);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txt_nombre);
            this.Name = "frm_InventarioModificar";
            this.Text = "Inventario - Modificar Producto";
            this.Load += new System.EventHandler(this.frm_InventarioModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_lineaProducto;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.TextBox txt_cantidadMinima;
        private System.Windows.Forms.TextBox txt_unidadMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_marcaCarro;
        private System.Windows.Forms.TextBox txt_anioCarro;
        private System.Windows.Forms.TextBox txt_modeloCarro;
        private System.Windows.Forms.TextBox txt_numeroPedimento;
        private System.Windows.Forms.TextBox txt_precioEspecial;
        private System.Windows.Forms.TextBox txt_compatibilidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_precio1;
        private System.Windows.Forms.TextBox txt_precio2;
        private System.Windows.Forms.TextBox txt_precio3;
    }
}