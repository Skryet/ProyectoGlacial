namespace Proyecto_Glacial.Proveedores
{
    partial class frm_ProveedorAgregar
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
            System.Windows.Forms.Label lbl_Nombre;
            System.Windows.Forms.Label lbl_Telefono;
            System.Windows.Forms.Label lbl_Direccion;
            System.Windows.Forms.Label lbl_Colonia;
            System.Windows.Forms.Label lbl_Estado;
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.proveedoresTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedoresTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_Telefono = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_Colonia = new System.Windows.Forms.Label();
            lbl_Estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Nombre.Location = new System.Drawing.Point(32, 49);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(71, 18);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "nombre", true));
            this.txt_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(129, 46);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(355, 26);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Telefono.Location = new System.Drawing.Point(32, 94);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new System.Drawing.Size(77, 18);
            lbl_Telefono.TabIndex = 3;
            lbl_Telefono.Text = "Teléfono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "telefono", true));
            this.txt_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(129, 91);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 26);
            this.txt_Telefono.TabIndex = 4;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Direccion.Location = new System.Drawing.Point(32, 139);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new System.Drawing.Size(85, 18);
            lbl_Direccion.TabIndex = 5;
            lbl_Direccion.Text = "Dirección";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "direccion", true));
            this.txt_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(129, 136);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(347, 26);
            this.txt_Direccion.TabIndex = 6;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_Colonia
            // 
            lbl_Colonia.AutoSize = true;
            lbl_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Colonia.Location = new System.Drawing.Point(32, 184);
            lbl_Colonia.Name = "lbl_Colonia";
            lbl_Colonia.Size = new System.Drawing.Size(68, 18);
            lbl_Colonia.TabIndex = 7;
            lbl_Colonia.Text = "Colonia";
            // 
            // txt_Colonia
            // 
            this.txt_Colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "colonia", true));
            this.txt_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Colonia.Location = new System.Drawing.Point(129, 181);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(356, 26);
            this.txt_Colonia.TabIndex = 8;
            this.txt_Colonia.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Estado.Location = new System.Drawing.Point(32, 231);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(64, 18);
            lbl_Estado.TabIndex = 9;
            lbl_Estado.Text = "Estado";
            // 
            // txt_Estado
            // 
            this.txt_Estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "estado", true));
            this.txt_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(129, 228);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(231, 26);
            this.txt_Estado.TabIndex = 10;
            this.txt_Estado.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            this.btn_Agregar.Location = new System.Drawing.Point(560, 355);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 75);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Agregar.Location = new System.Drawing.Point(555, 431);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(86, 22);
            this.lbl_Agregar.TabIndex = 11;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frm_ProveedorAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 484);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Agregar);
            this.Controls.Add(lbl_Estado);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(lbl_Colonia);
            this.Controls.Add(this.txt_Colonia);
            this.Controls.Add(lbl_Direccion);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(lbl_Telefono);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Name = "frm_ProveedorAgregar";
            this.Text = "Proveedor - Agregar";
            this.Load += new System.EventHandler(this.frm_ProveedorAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private glacial_almacenDataSetTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Agregar;
    }
}