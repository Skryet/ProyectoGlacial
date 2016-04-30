namespace Proyecto_Glacial
{
    partial class frm_ClientesAgregar
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label lbl_correo;
            System.Windows.Forms.Label lbl_RFC;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_CURP = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.txt_fechaIngre = new System.Windows.Forms.Label();
            this.lbl_fechaIngreso = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            lbl_correo = new System.Windows.Forms.Label();
            lbl_RFC = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(12, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(240, 22);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre(s) / Razón Social";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(17, 146);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(103, 22);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Dirección:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(350, 203);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(84, 22);
            coloniaLabel.TabIndex = 7;
            coloniaLabel.Text = "Colonia:";
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpLabel.Location = new System.Drawing.Point(586, 203);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(143, 22);
            cpLabel.TabIndex = 9;
            cpLabel.Text = "Código Postal:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(15, 203);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(81, 22);
            ciudadLabel.TabIndex = 13;
            ciudadLabel.Text = "Ciudad:";
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_correo.Location = new System.Drawing.Point(17, 273);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new System.Drawing.Size(79, 22);
            lbl_correo.TabIndex = 18;
            lbl_correo.Text = "Correo:";
            // 
            // lbl_RFC
            // 
            lbl_RFC.AutoSize = true;
            lbl_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_RFC.Location = new System.Drawing.Point(17, 330);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new System.Drawing.Size(55, 22);
            lbl_RFC.TabIndex = 20;
            lbl_RFC.Text = "RFC:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(355, 146);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 22);
            label1.TabIndex = 22;
            label1.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(591, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 22);
            label2.TabIndex = 22;
            label2.Text = "CURP:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(16, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(890, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.despintarTexto);
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
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txtDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(16, 171);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(332, 29);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "colonia", true));
            this.txtColonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(354, 228);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(219, 29);
            this.txtColonia.TabIndex = 6;
            this.txtColonia.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txtCodigoPostal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(595, 228);
            this.txtCodigoPostal.MaxLength = 5;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(214, 29);
            this.txtCodigoPostal.TabIndex = 7;
            this.txtCodigoPostal.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtCiudad
            // 
            this.txtCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ciudad", true));
            this.txtCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(16, 228);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(332, 29);
            this.txtCiudad.TabIndex = 5;
            this.txtCiudad.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(562, 373);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(86, 22);
            this.lblConfirmar.TabIndex = 16;
            this.lblConfirmar.Text = "Agregar";
            // 
            // txt_correo
            // 
            this.txt_correo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txt_correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(16, 298);
            this.txt_correo.MaxLength = 255;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(441, 29);
            this.txt_correo.TabIndex = 8;
            // 
            // txt_rfc
            // 
            this.txt_rfc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txt_rfc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.Location = new System.Drawing.Point(16, 355);
            this.txt_rfc.MaxLength = 15;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(441, 29);
            this.txt_rfc.TabIndex = 9;
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
            // txt_telefono
            // 
            this.txt_telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txt_telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(354, 171);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(219, 29);
            this.txt_telefono.TabIndex = 3;
            // 
            // txt_CURP
            // 
            this.txt_CURP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CURP.Location = new System.Drawing.Point(590, 171);
            this.txt_CURP.Name = "txt_CURP";
            this.txt_CURP.Size = new System.Drawing.Size(219, 29);
            this.txt_CURP.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_codigo.Location = new System.Drawing.Point(294, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(0, 33);
            this.lbl_codigo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(165, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cliente:";
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Image = global::Proyecto_Glacial.Properties.Resources.AddIconBlue_2_;
            this.btn_AgregarCliente.Location = new System.Drawing.Point(568, 287);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(80, 80);
            this.btn_AgregarCliente.TabIndex = 15;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // txt_fechaIngre
            // 
            this.txt_fechaIngre.AutoSize = true;
            this.txt_fechaIngre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaIngre.ForeColor = System.Drawing.Color.Black;
            this.txt_fechaIngre.Location = new System.Drawing.Point(620, 34);
            this.txt_fechaIngre.Name = "txt_fechaIngre";
            this.txt_fechaIngre.Size = new System.Drawing.Size(162, 24);
            this.txt_fechaIngre.TabIndex = 23;
            this.txt_fechaIngre.Text = "Fecha Ingreso:";
            // 
            // lbl_fechaIngreso
            // 
            this.lbl_fechaIngreso.AutoSize = true;
            this.lbl_fechaIngreso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaIngreso.Location = new System.Drawing.Point(788, 36);
            this.lbl_fechaIngreso.Name = "lbl_fechaIngreso";
            this.lbl_fechaIngreso.Size = new System.Drawing.Size(60, 22);
            this.lbl_fechaIngreso.TabIndex = 24;
            this.lbl_fechaIngreso.Text = "sssss";
            // 
            // frm_ClientesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 550);
            this.Controls.Add(this.lbl_fechaIngreso);
            this.Controls.Add(this.txt_fechaIngre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txt_CURP);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(lbl_RFC);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(lbl_correo);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(cpLabel);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(coloniaLabel);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Name = "frm_ClientesAgregar";
            this.Text = "Clientes-Agregar";
            this.Load += new System.EventHandler(this.frm_ClientesAgregar_Load);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_CURP;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_fechaIngre;
        private System.Windows.Forms.Label lbl_fechaIngreso;
    }
}