namespace Proyecto_Glacial.Clientes
{
    partial class frm_ClientesModificar
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label rfcLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cURPLabel;
            System.Windows.Forms.Label lbl_credito;
            System.Windows.Forms.Label fecha_limite_creditoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_CURP = new System.Windows.Forms.TextBox();
            this.check_tieneCredito = new System.Windows.Forms.CheckBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.fecha_limiteCredito = new System.Windows.Forms.DateTimePicker();
            this.grp_credito = new System.Windows.Forms.GroupBox();
            this.txt_numeroCliente = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.cmb_precioSeleccionar = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            id_clienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            rfcLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            lbl_credito = new System.Windows.Forms.Label();
            fecha_limite_creditoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.grp_credito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(749, 43);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(185, 22);
            id_clienteLabel.TabIndex = 0;
            id_clienteLabel.Text = "Número de Cliente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(12, 43);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(243, 22);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre(s) / Razón social:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(12, 109);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(103, 22);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(12, 176);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(84, 22);
            coloniaLabel.TabIndex = 10;
            coloniaLabel.Text = "Colonia:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(296, 176);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(81, 22);
            ciudadLabel.TabIndex = 12;
            ciudadLabel.Text = "Ciudad:";
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpLabel.Location = new System.Drawing.Point(296, 242);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(143, 22);
            cpLabel.TabIndex = 14;
            cpLabel.Text = "Código Postal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(850, 485);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 22);
            label1.TabIndex = 17;
            label1.Text = "Actualizar";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(12, 303);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(73, 22);
            correoLabel.TabIndex = 18;
            correoLabel.Text = "Correo";
            // 
            // rfcLabel
            // 
            rfcLabel.AutoSize = true;
            rfcLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rfcLabel.Location = new System.Drawing.Point(12, 360);
            rfcLabel.Name = "rfcLabel";
            rfcLabel.Size = new System.Drawing.Size(55, 22);
            rfcLabel.TabIndex = 20;
            rfcLabel.Text = "RFC:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(12, 242);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(94, 22);
            telefonoLabel.TabIndex = 22;
            telefonoLabel.Text = "Teléfono:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cURPLabel.Location = new System.Drawing.Point(306, 360);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(71, 22);
            cURPLabel.TabIndex = 24;
            cURPLabel.Text = "CURP:";
            // 
            // lbl_credito
            // 
            lbl_credito.AutoSize = true;
            lbl_credito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_credito.Location = new System.Drawing.Point(6, 26);
            lbl_credito.Name = "lbl_credito";
            lbl_credito.Size = new System.Drawing.Size(78, 22);
            lbl_credito.TabIndex = 26;
            lbl_credito.Text = "Crédito";
            // 
            // fecha_limite_creditoLabel
            // 
            fecha_limite_creditoLabel.AutoSize = true;
            fecha_limite_creditoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_limite_creditoLabel.Location = new System.Drawing.Point(269, 16);
            fecha_limite_creditoLabel.Name = "fecha_limite_creditoLabel";
            fecha_limite_creditoLabel.Size = new System.Drawing.Size(120, 22);
            fecha_limite_creditoLabel.TabIndex = 27;
            fecha_limite_creditoLabel.Text = "Fecha límite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(431, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 22);
            label2.TabIndex = 2;
            label2.Text = "Modificar";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id_cliente", true));
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(772, 68);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(142, 29);
            this.txt_cliente.TabIndex = 1;
            this.txt_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(12, 68);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(754, 29);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_direccion
            // 
            this.txt_direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txt_direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(12, 134);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(754, 29);
            this.txt_direccion.TabIndex = 2;
            // 
            // txt_colonia
            // 
            this.txt_colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "colonia", true));
            this.txt_colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colonia.Location = new System.Drawing.Point(16, 203);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(246, 29);
            this.txt_colonia.TabIndex = 3;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ciudad", true));
            this.txt_ciudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(300, 203);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(235, 29);
            this.txt_ciudad.TabIndex = 4;
            // 
            // txt_cp
            // 
            this.txt_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txt_cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cp.Location = new System.Drawing.Point(300, 267);
            this.txt_cp.MaxLength = 5;
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(235, 29);
            this.txt_cp.TabIndex = 6;
            // 
            // txt_correo
            // 
            this.txt_correo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.txt_correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(16, 328);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(524, 29);
            this.txt_correo.TabIndex = 7;
            // 
            // txt_rfc
            // 
            this.txt_rfc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "rfc", true));
            this.txt_rfc.Enabled = false;
            this.txt_rfc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.Location = new System.Drawing.Point(16, 392);
            this.txt_rfc.MaxLength = 15;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(251, 29);
            this.txt_rfc.TabIndex = 9;
            // 
            // txt_telefono
            // 
            this.txt_telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.txt_telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(16, 267);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(246, 29);
            this.txt_telefono.TabIndex = 5;
            // 
            // txt_CURP
            // 
            this.txt_CURP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CURP", true));
            this.txt_CURP.Enabled = false;
            this.txt_CURP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CURP.Location = new System.Drawing.Point(300, 389);
            this.txt_CURP.Name = "txt_CURP";
            this.txt_CURP.Size = new System.Drawing.Size(235, 29);
            this.txt_CURP.TabIndex = 10;
            // 
            // check_tieneCredito
            // 
            this.check_tieneCredito.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientesBindingSource, "tiene_credito", true));
            this.check_tieneCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_tieneCredito.Location = new System.Drawing.Point(16, 451);
            this.check_tieneCredito.Name = "check_tieneCredito";
            this.check_tieneCredito.Size = new System.Drawing.Size(146, 56);
            this.check_tieneCredito.TabIndex = 11;
            this.check_tieneCredito.Text = "¿Tiene Crédito?";
            this.check_tieneCredito.UseVisualStyleBackColor = true;
            this.check_tieneCredito.CheckedChanged += new System.EventHandler(this.check_tieneCredito_CheckedChanged);
            // 
            // txt_credito
            // 
            this.txt_credito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "credito", true));
            this.txt_credito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credito.Location = new System.Drawing.Point(10, 51);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(160, 29);
            this.txt_credito.TabIndex = 12;
            // 
            // fecha_limiteCredito
            // 
            this.fecha_limiteCredito.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fecha_limite_credito", true));
            this.fecha_limiteCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_limiteCredito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_limiteCredito.Location = new System.Drawing.Point(273, 49);
            this.fecha_limiteCredito.Name = "fecha_limiteCredito";
            this.fecha_limiteCredito.Size = new System.Drawing.Size(161, 29);
            this.fecha_limiteCredito.TabIndex = 13;
            // 
            // grp_credito
            // 
            this.grp_credito.Controls.Add(this.txt_credito);
            this.grp_credito.Controls.Add(this.fecha_limiteCredito);
            this.grp_credito.Controls.Add(fecha_limite_creditoLabel);
            this.grp_credito.Controls.Add(lbl_credito);
            this.grp_credito.Location = new System.Drawing.Point(150, 427);
            this.grp_credito.Name = "grp_credito";
            this.grp_credito.Size = new System.Drawing.Size(482, 92);
            this.grp_credito.TabIndex = 29;
            this.grp_credito.TabStop = false;
            this.grp_credito.Text = "Crédito";
            this.grp_credito.Visible = false;
            // 
            // txt_numeroCliente
            // 
            this.txt_numeroCliente.BackColor = System.Drawing.Color.LightGreen;
            this.txt_numeroCliente.Enabled = false;
            this.txt_numeroCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroCliente.Location = new System.Drawing.Point(772, 68);
            this.txt_numeroCliente.Name = "txt_numeroCliente";
            this.txt_numeroCliente.Size = new System.Drawing.Size(142, 29);
            this.txt_numeroCliente.TabIndex = 30;
            this.txt_numeroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // cmb_precioSeleccionar
            // 
            this.cmb_precioSeleccionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_precioSeleccionar.FormattingEnabled = true;
            this.cmb_precioSeleccionar.Items.AddRange(new object[] {
            "Precio Libre",
            "Precio 1",
            "Precio 2",
            "Precio 3",
            "Precio Especial"});
            this.cmb_precioSeleccionar.Location = new System.Drawing.Point(592, 327);
            this.cmb_precioSeleccionar.Name = "cmb_precioSeleccionar";
            this.cmb_precioSeleccionar.Size = new System.Drawing.Size(138, 30);
            this.cmb_precioSeleccionar.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(588, 303);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(178, 22);
            label3.TabIndex = 32;
            label3.Text = "Precio referencial:";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_Actualizar.Location = new System.Drawing.Point(854, 402);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_Actualizar.TabIndex = 16;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // frm_ClientesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 527);
            this.Controls.Add(label3);
            this.Controls.Add(this.cmb_precioSeleccionar);
            this.Controls.Add(this.txt_numeroCliente);
            this.Controls.Add(this.grp_credito);
            this.Controls.Add(this.check_tieneCredito);
            this.Controls.Add(cURPLabel);
            this.Controls.Add(this.txt_CURP);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(rfcLabel);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(cpLabel);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(coloniaLabel);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(label2);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.txt_cliente);
            this.Name = "frm_ClientesModificar";
            this.Text = "Clientes - Modificar";
            this.Load += new System.EventHandler(this.frm_ClientesModificar_Load);
            this.grp_credito.ResumeLayout(false);
            this.grp_credito.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_CURP;
        private System.Windows.Forms.CheckBox check_tieneCredito;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.DateTimePicker fecha_limiteCredito;
        private System.Windows.Forms.GroupBox grp_credito;
        private System.Windows.Forms.TextBox txt_numeroCliente;
        private System.Windows.Forms.ComboBox cmb_precioSeleccionar;
    }
}