namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    partial class frm_InventarioModificarDatosProveedorProducto
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label unidad_medidaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.proveedor_codigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedor_codigoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.glacial_almacenDataSet1 = new Proyecto_Glacial.glacial_almacenDataSet();
            codigoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            unidad_medidaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(14, 77);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(91, 24);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Código:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(10, 149);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(83, 24);
            precioLabel.TabIndex = 2;
            precioLabel.Text = "Precio:";
            // 
            // unidad_medidaLabel
            // 
            unidad_medidaLabel.AutoSize = true;
            unidad_medidaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidad_medidaLabel.Location = new System.Drawing.Point(185, 77);
            unidad_medidaLabel.Name = "unidad_medidaLabel";
            unidad_medidaLabel.Size = new System.Drawing.Size(198, 24);
            unidad_medidaLabel.TabIndex = 4;
            unidad_medidaLabel.Text = "Unidad de Medida:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(22, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(381, 24);
            label1.TabIndex = 6;
            label1.Text = "Modificar Datos Producto-Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(236, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 24);
            label2.TabIndex = 8;
            label2.Text = "Actualizar";
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedor_codigoBindingSource
            // 
            this.proveedor_codigoBindingSource.DataMember = "proveedor_codigo";
            this.proveedor_codigoBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // proveedor_codigoTableAdapter
            // 
            this.proveedor_codigoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            //      this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
           // this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = this.proveedor_codigoTableAdapter;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // txt_codigo
            // 
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedor_codigoBindingSource, "codigo", true));
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(14, 104);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(151, 32);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedor_codigoBindingSource, "precio", true));
            this.txt_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(14, 176);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(151, 32);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedor_codigoBindingSource, "unidad_medida", true));
            this.txt_unidadMedida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.Location = new System.Drawing.Point(189, 104);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.Size = new System.Drawing.Size(194, 32);
            this.txt_unidadMedida.TabIndex = 5;
            this.txt_unidadMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unidadMedida_KeyPress);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_actualizar.Location = new System.Drawing.Point(251, 142);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_actualizar.TabIndex = 7;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // glacial_almacenDataSet1
            // 
            this.glacial_almacenDataSet1.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_InventarioModificarDatosProveedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 266);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(label1);
            this.Controls.Add(unidad_medidaLabel);
            this.Controls.Add(this.txt_unidadMedida);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.txt_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_InventarioModificarDatosProveedorProducto";
            this.Text = "Inventario - Modificar Productos Proveedor";
            this.Load += new System.EventHandler(this.frm_InventarioModificarDatosProveedorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource proveedor_codigoBindingSource;
        private glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter proveedor_codigoTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_unidadMedida;
        private System.Windows.Forms.Button btn_actualizar;
        private glacial_almacenDataSet glacial_almacenDataSet1;
    }
}