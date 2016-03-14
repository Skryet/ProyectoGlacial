namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    partial class frm_InventarioAgregarDatosProveedoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Medida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.but_agregarProveedor = new System.Windows.Forms.Button();
            this.txt_idProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.proveedor_codigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedor_codigoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(141, 164);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(167, 29);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(374, 164);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(167, 29);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // txt_Medida
            // 
            this.txt_Medida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Medida.Location = new System.Drawing.Point(374, 89);
            this.txt_Medida.Name = "txt_Medida";
            this.txt_Medida.Size = new System.Drawing.Size(167, 29);
            this.txt_Medida.TabIndex = 1;
            this.txt_Medida.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medida:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(79, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(433, 33);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Almacén - Agregar productos";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddIconBlue_02_;
            this.btn_agregar.Location = new System.Drawing.Point(578, 95);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(80, 80);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(166, 64);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(111, 22);
            this.lbl_proveedor.TabIndex = 8;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Enabled = false;
            this.txt_proveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proveedor.Location = new System.Drawing.Point(141, 89);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(167, 29);
            this.txt_proveedor.TabIndex = 9;
            this.txt_proveedor.Text = ".";
            // 
            // but_agregarProveedor
            // 
            this.but_agregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_agregarProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregarProveedor.Location = new System.Drawing.Point(314, 87);
            this.but_agregarProveedor.Name = "but_agregarProveedor";
            this.but_agregarProveedor.Size = new System.Drawing.Size(42, 30);
            this.but_agregarProveedor.TabIndex = 10;
            this.but_agregarProveedor.Text = "...";
            this.but_agregarProveedor.UseVisualStyleBackColor = false;
            this.but_agregarProveedor.Click += new System.EventHandler(this.but_agregarProveedor_Click);
            // 
            // txt_idProveedor
            // 
            this.txt_idProveedor.Enabled = false;
            this.txt_idProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idProveedor.Location = new System.Drawing.Point(38, 88);
            this.txt_idProveedor.Name = "txt_idProveedor";
            this.txt_idProveedor.Size = new System.Drawing.Size(82, 29);
            this.txt_idProveedor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "No. Proveedor";
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
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = this.proveedor_codigoTableAdapter;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_InventarioAgregarDatosProveedoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 223);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idProveedor);
            this.Controls.Add(this.but_agregarProveedor);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_Medida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Name = "frm_InventarioAgregarDatosProveedoProducto";
            this.Text = "Almacén - Agregar datos Producto";
            this.Activated += new System.EventHandler(this.frm_InventarioAgregarDatosProveedoProducto_Activated);
            this.Load += new System.EventHandler(this.frm_InventarioAgregarDatosProveedoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Medida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Button but_agregarProveedor;
        private System.Windows.Forms.TextBox txt_idProveedor;
        private System.Windows.Forms.Label label4;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource proveedor_codigoBindingSource;
        private glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter proveedor_codigoTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}