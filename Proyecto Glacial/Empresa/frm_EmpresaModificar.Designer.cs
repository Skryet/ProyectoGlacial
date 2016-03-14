namespace Proyecto_Glacial.Empresa
{
    partial class frm_EmpresaModificar
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
            System.Windows.Forms.Label lbl_Estado;
            System.Windows.Forms.Label lbl_Colonia;
            System.Windows.Forms.Label lbl_Direccion;
            System.Windows.Forms.Label lbl_Telefono;
            System.Windows.Forms.Label lbl_Nombre;
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.empresaTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_Colonia = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_Telefono = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Estado.Location = new System.Drawing.Point(35, 224);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(64, 18);
            lbl_Estado.TabIndex = 21;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_Colonia
            // 
            lbl_Colonia.AutoSize = true;
            lbl_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Colonia.Location = new System.Drawing.Point(35, 177);
            lbl_Colonia.Name = "lbl_Colonia";
            lbl_Colonia.Size = new System.Drawing.Size(68, 18);
            lbl_Colonia.TabIndex = 19;
            lbl_Colonia.Text = "Colonia";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Direccion.Location = new System.Drawing.Point(35, 132);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new System.Drawing.Size(85, 18);
            lbl_Direccion.TabIndex = 17;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Telefono.Location = new System.Drawing.Point(35, 87);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new System.Drawing.Size(77, 18);
            lbl_Telefono.TabIndex = 15;
            lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Nombre.Location = new System.Drawing.Point(35, 42);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(71, 18);
            lbl_Nombre.TabIndex = 13;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Modificar.Location = new System.Drawing.Point(552, 424);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(95, 22);
            this.lbl_Modificar.TabIndex = 23;
            this.lbl_Modificar.Text = "Modificar";
            // 
            // txt_Estado
            // 
            this.txt_Estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "estado", true));
            this.txt_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(132, 221);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(231, 26);
            this.txt_Estado.TabIndex = 22;
            this.txt_Estado.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Colonia
            // 
            this.txt_Colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "colonia", true));
            this.txt_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Colonia.Location = new System.Drawing.Point(132, 174);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(356, 26);
            this.txt_Colonia.TabIndex = 20;
            this.txt_Colonia.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "direccion", true));
            this.txt_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(132, 129);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(347, 26);
            this.txt_Direccion.TabIndex = 18;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "telefono", true));
            this.txt_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(132, 84);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(169, 26);
            this.txt_Telefono.TabIndex = 16;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "nombre", true));
            this.txt_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(132, 39);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(355, 26);
            this.txt_Nombre.TabIndex = 14;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(563, 348);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 75);
            this.btn_Modificar.TabIndex = 24;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
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
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.empresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_EmpresaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 484);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Modificar);
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
            this.Name = "frm_EmpresaModificar";
            this.Text = "Empresa - Modificar";
            this.Load += new System.EventHandler(this.frm_EmpresaModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private glacial_almacenDataSetTableAdapters.empresaTableAdapter empresaTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}