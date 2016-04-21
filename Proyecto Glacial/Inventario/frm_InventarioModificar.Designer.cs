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
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_lineaProducto = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.txt_cantidadMinima = new System.Windows.Forms.TextBox();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.txt_precio1 = new System.Windows.Forms.TextBox();
            this.txt_precio2 = new System.Windows.Forms.TextBox();
            this.txt_precio3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(98, 119);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(99, 24);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // id_linea_productoLabel
            // 
            id_linea_productoLabel.AutoSize = true;
            id_linea_productoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_linea_productoLabel.Location = new System.Drawing.Point(12, 67);
            id_linea_productoLabel.Name = "id_linea_productoLabel";
            id_linea_productoLabel.Size = new System.Drawing.Size(190, 24);
            id_linea_productoLabel.TabIndex = 2;
            id_linea_productoLabel.Text = "Código Producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(60, 160);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(140, 24);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripción:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel.Location = new System.Drawing.Point(17, 273);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(121, 24);
            existenciaLabel.TabIndex = 6;
            existenciaLabel.Text = "Existencia:";
            // 
            // cantidad_minimaLabel
            // 
            cantidad_minimaLabel.AutoSize = true;
            cantidad_minimaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidad_minimaLabel.Location = new System.Drawing.Point(17, 332);
            cantidad_minimaLabel.Name = "cantidad_minimaLabel";
            cantidad_minimaLabel.Size = new System.Drawing.Size(187, 24);
            cantidad_minimaLabel.TabIndex = 8;
            cantidad_minimaLabel.Text = "Cantidad Mínima:";
            // 
            // unidad_medidaLabel
            // 
            unidad_medidaLabel.AutoSize = true;
            unidad_medidaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidad_medidaLabel.Location = new System.Drawing.Point(6, 384);
            unidad_medidaLabel.Name = "unidad_medidaLabel";
            unidad_medidaLabel.Size = new System.Drawing.Size(198, 24);
            unidad_medidaLabel.TabIndex = 10;
            unidad_medidaLabel.Text = "Unidad de Medida:";
            // 
            // precio1Label
            // 
            precio1Label.AutoSize = true;
            precio1Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio1Label.Location = new System.Drawing.Point(12, 211);
            precio1Label.Name = "precio1Label";
            precio1Label.Size = new System.Drawing.Size(100, 24);
            precio1Label.TabIndex = 12;
            precio1Label.Text = "Precio 1:";
            // 
            // precio2Label
            // 
            precio2Label.AutoSize = true;
            precio2Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio2Label.Location = new System.Drawing.Point(275, 211);
            precio2Label.Name = "precio2Label";
            precio2Label.Size = new System.Drawing.Size(100, 24);
            precio2Label.TabIndex = 14;
            precio2Label.Text = "Precio 2:";
            // 
            // precio3Label
            // 
            precio3Label.AutoSize = true;
            precio3Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio3Label.Location = new System.Drawing.Point(318, 270);
            precio3Label.Name = "precio3Label";
            precio3Label.Size = new System.Drawing.Size(100, 24);
            precio3Label.TabIndex = 16;
            precio3Label.Text = "Precio 3:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(405, 387);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 24);
            label2.TabIndex = 20;
            label2.Text = "Guardar";
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
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            //this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // txt_nombre
            // 
            this.txt_nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "nombre", true));
            this.txt_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(203, 111);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(328, 32);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_lineaProducto
            // 
            this.txt_lineaProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "id_linea_producto", true));
            this.txt_lineaProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lineaProducto.Location = new System.Drawing.Point(203, 67);
            this.txt_lineaProducto.Name = "txt_lineaProducto";
            this.txt_lineaProducto.Size = new System.Drawing.Size(145, 32);
            this.txt_lineaProducto.TabIndex = 1;
            this.txt_lineaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descripcion", true));
            this.txt_descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(203, 152);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(328, 32);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_existencia
            // 
            this.txt_existencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "existencia", true));
            this.txt_existencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.Location = new System.Drawing.Point(144, 270);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(141, 32);
            this.txt_existencia.TabIndex = 7;
            this.txt_existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_cantidadMinima
            // 
            this.txt_cantidadMinima.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "cantidad_minima", true));
            this.txt_cantidadMinima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadMinima.Location = new System.Drawing.Point(210, 329);
            this.txt_cantidadMinima.Name = "txt_cantidadMinima";
            this.txt_cantidadMinima.Size = new System.Drawing.Size(134, 32);
            this.txt_cantidadMinima.TabIndex = 8;
            this.txt_cantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "unidad_medida", true));
            this.txt_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.Location = new System.Drawing.Point(210, 376);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.Size = new System.Drawing.Size(145, 32);
            this.txt_unidadMedida.TabIndex = 9;
            // 
            // txt_precio1
            // 
            this.txt_precio1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio1", true));
            this.txt_precio1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio1.Location = new System.Drawing.Point(118, 208);
            this.txt_precio1.Name = "txt_precio1";
            this.txt_precio1.Size = new System.Drawing.Size(141, 32);
            this.txt_precio1.TabIndex = 4;
            this.txt_precio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDecimal);
            // 
            // txt_precio2
            // 
            this.txt_precio2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio2", true));
            this.txt_precio2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio2.Location = new System.Drawing.Point(381, 208);
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Size = new System.Drawing.Size(141, 32);
            this.txt_precio2.TabIndex = 5;
            this.txt_precio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDecimal);
            // 
            // txt_precio3
            // 
            this.txt_precio3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio3", true));
            this.txt_precio3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio3.Location = new System.Drawing.Point(424, 262);
            this.txt_precio3.Name = "txt_precio3";
            this.txt_precio3.Size = new System.Drawing.Size(141, 32);
            this.txt_precio3.TabIndex = 6;
            this.txt_precio3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDecimal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modifcar Producto";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_actualizar.Location = new System.Drawing.Point(409, 307);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // frm_InventarioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 473);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(precio3Label);
            this.Controls.Add(this.txt_precio3);
            this.Controls.Add(precio2Label);
            this.Controls.Add(this.txt_precio2);
            this.Controls.Add(precio1Label);
            this.Controls.Add(this.txt_precio1);
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
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txt_precio1;
        private System.Windows.Forms.TextBox txt_precio2;
        private System.Windows.Forms.TextBox txt_precio3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
    }
}