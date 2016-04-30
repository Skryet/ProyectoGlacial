namespace Proyecto_Glacial.Clientes
{
    partial class frm_ClientesVisualizarIndividual
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label rfcLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label precio_asignadoLabel;
            System.Windows.Forms.Label fecha_limite_creditoLabel;
            System.Windows.Forms.Label creditoLabel;
            System.Windows.Forms.Label fecha_registroLabel1;
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.coloniaTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.rfcTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.precio_asignadoTextBox = new System.Windows.Forms.TextBox();
            this.CHECK_tieneCredito = new System.Windows.Forms.CheckBox();
            this.fecha_limite_creditoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_registroDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grp_credito = new System.Windows.Forms.GroupBox();
            this.txt_codigoClienteFormato = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            rfcLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            precio_asignadoLabel = new System.Windows.Forms.Label();
            fecha_limite_creditoLabel = new System.Windows.Forms.Label();
            creditoLabel = new System.Windows.Forms.Label();
            fecha_registroLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.grp_credito.SuspendLayout();
            this.SuspendLayout();
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.glacial_almacenDataSet;
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
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(105, 45);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(248, 22);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre (s) / Razón social:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(105, 70);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(406, 29);
            this.nombreTextBox.TabIndex = 2;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(105, 107);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(103, 22);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Dirección:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.direccionTextBox.Enabled = false;
            this.direccionTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(105, 132);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(403, 29);
            this.direccionTextBox.TabIndex = 3;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(710, 20);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(185, 22);
            id_clienteLabel.TabIndex = 4;
            id_clienteLabel.Text = "Número de Cliente:";
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Enabled = false;
            this.id_clienteTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_clienteTextBox.Location = new System.Drawing.Point(714, 45);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(180, 29);
            this.id_clienteTextBox.TabIndex = 5;
            this.id_clienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(526, 175);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(84, 22);
            coloniaLabel.TabIndex = 6;
            coloniaLabel.Text = "Colonia:";
            // 
            // coloniaTextBox
            // 
            this.coloniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "colonia", true));
            this.coloniaTextBox.Enabled = false;
            this.coloniaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coloniaTextBox.Location = new System.Drawing.Point(530, 200);
            this.coloniaTextBox.Name = "coloniaTextBox";
            this.coloniaTextBox.Size = new System.Drawing.Size(377, 29);
            this.coloniaTextBox.TabIndex = 7;
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(104, 175);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(81, 22);
            ciudadLabel.TabIndex = 8;
            ciudadLabel.Text = "Ciudad:";
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ciudad", true));
            this.ciudadTextBox.Enabled = false;
            this.ciudadTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.Location = new System.Drawing.Point(105, 200);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(406, 29);
            this.ciudadTextBox.TabIndex = 9;
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpLabel.Location = new System.Drawing.Point(723, 247);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(143, 22);
            cpLabel.TabIndex = 10;
            cpLabel.Text = "Código Postal:";
            // 
            // cpTextBox
            // 
            this.cpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.cpTextBox.Enabled = false;
            this.cpTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpTextBox.Location = new System.Drawing.Point(727, 272);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(180, 29);
            this.cpTextBox.TabIndex = 11;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(105, 250);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(79, 22);
            correoLabel.TabIndex = 12;
            correoLabel.Text = "Correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.correoTextBox.Enabled = false;
            this.correoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(105, 275);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(403, 29);
            this.correoTextBox.TabIndex = 13;
            // 
            // rfcLabel
            // 
            rfcLabel.AutoSize = true;
            rfcLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rfcLabel.Location = new System.Drawing.Point(105, 311);
            rfcLabel.Name = "rfcLabel";
            rfcLabel.Size = new System.Drawing.Size(55, 22);
            rfcLabel.TabIndex = 14;
            rfcLabel.Text = "RFC:";
            // 
            // rfcTextBox
            // 
            this.rfcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "rfc", true));
            this.rfcTextBox.Enabled = false;
            this.rfcTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfcTextBox.Location = new System.Drawing.Point(108, 336);
            this.rfcTextBox.Name = "rfcTextBox";
            this.rfcTextBox.Size = new System.Drawing.Size(400, 29);
            this.rfcTextBox.TabIndex = 15;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(534, 247);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(94, 22);
            telefonoLabel.TabIndex = 16;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(530, 272);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(180, 29);
            this.telefonoTextBox.TabIndex = 17;
            // 
            // precio_asignadoLabel
            // 
            precio_asignadoLabel.AutoSize = true;
            precio_asignadoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precio_asignadoLabel.Location = new System.Drawing.Point(534, 311);
            precio_asignadoLabel.Name = "precio_asignadoLabel";
            precio_asignadoLabel.Size = new System.Drawing.Size(163, 22);
            precio_asignadoLabel.TabIndex = 22;
            precio_asignadoLabel.Text = "Precio asignado:";
            // 
            // precio_asignadoTextBox
            // 
            this.precio_asignadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "precio_asignado", true));
            this.precio_asignadoTextBox.Enabled = false;
            this.precio_asignadoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_asignadoTextBox.Location = new System.Drawing.Point(530, 336);
            this.precio_asignadoTextBox.Name = "precio_asignadoTextBox";
            this.precio_asignadoTextBox.Size = new System.Drawing.Size(172, 29);
            this.precio_asignadoTextBox.TabIndex = 23;
            // 
            // CHECK_tieneCredito
            // 
            this.CHECK_tieneCredito.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientesBindingSource, "tiene_credito", true));
            this.CHECK_tieneCredito.Enabled = false;
            this.CHECK_tieneCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECK_tieneCredito.Location = new System.Drawing.Point(120, 377);
            this.CHECK_tieneCredito.Name = "CHECK_tieneCredito";
            this.CHECK_tieneCredito.Size = new System.Drawing.Size(135, 93);
            this.CHECK_tieneCredito.TabIndex = 25;
            this.CHECK_tieneCredito.Text = "¿Tiene Crédito?";
            this.CHECK_tieneCredito.UseVisualStyleBackColor = true;
            // 
            // fecha_limite_creditoLabel
            // 
            fecha_limite_creditoLabel.AutoSize = true;
            fecha_limite_creditoLabel.Location = new System.Drawing.Point(112, 38);
            fecha_limite_creditoLabel.Name = "fecha_limite_creditoLabel";
            fecha_limite_creditoLabel.Size = new System.Drawing.Size(191, 22);
            fecha_limite_creditoLabel.TabIndex = 26;
            fecha_limite_creditoLabel.Text = "fecha limite credito:";
            // 
            // fecha_limite_creditoDateTimePicker
            // 
            this.fecha_limite_creditoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fecha_limite_credito", true));
            this.fecha_limite_creditoDateTimePicker.Enabled = false;
            this.fecha_limite_creditoDateTimePicker.Location = new System.Drawing.Point(116, 61);
            this.fecha_limite_creditoDateTimePicker.Name = "fecha_limite_creditoDateTimePicker";
            this.fecha_limite_creditoDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.fecha_limite_creditoDateTimePicker.TabIndex = 27;
            // 
            // creditoLabel
            // 
            creditoLabel.AutoSize = true;
            creditoLabel.Location = new System.Drawing.Point(6, 38);
            creditoLabel.Name = "creditoLabel";
            creditoLabel.Size = new System.Drawing.Size(81, 22);
            creditoLabel.TabIndex = 28;
            creditoLabel.Text = "credito:";
            // 
            // creditoTextBox
            // 
            this.creditoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "credito", true));
            this.creditoTextBox.Enabled = false;
            this.creditoTextBox.Location = new System.Drawing.Point(10, 63);
            this.creditoTextBox.Name = "creditoTextBox";
            this.creditoTextBox.Size = new System.Drawing.Size(100, 29);
            this.creditoTextBox.TabIndex = 29;
            // 
            // fecha_registroLabel1
            // 
            fecha_registroLabel1.AutoSize = true;
            fecha_registroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_registroLabel1.Location = new System.Drawing.Point(526, 105);
            fecha_registroLabel1.Name = "fecha_registroLabel1";
            fecha_registroLabel1.Size = new System.Drawing.Size(181, 22);
            fecha_registroLabel1.TabIndex = 30;
            fecha_registroLabel1.Text = "Fecha de  registro:";
            // 
            // fecha_registroDateTimePicker1
            // 
            this.fecha_registroDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker1.Enabled = false;
            this.fecha_registroDateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_registroDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_registroDateTimePicker1.Location = new System.Drawing.Point(530, 130);
            this.fecha_registroDateTimePicker1.Name = "fecha_registroDateTimePicker1";
            this.fecha_registroDateTimePicker1.Size = new System.Drawing.Size(207, 29);
            this.fecha_registroDateTimePicker1.TabIndex = 31;
            // 
            // grp_credito
            // 
            this.grp_credito.Controls.Add(creditoLabel);
            this.grp_credito.Controls.Add(this.creditoTextBox);
            this.grp_credito.Controls.Add(this.fecha_limite_creditoDateTimePicker);
            this.grp_credito.Controls.Add(fecha_limite_creditoLabel);
            this.grp_credito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_credito.Location = new System.Drawing.Point(255, 377);
            this.grp_credito.Name = "grp_credito";
            this.grp_credito.Size = new System.Drawing.Size(381, 100);
            this.grp_credito.TabIndex = 32;
            this.grp_credito.TabStop = false;
            this.grp_credito.Text = "Crédito";
            // 
            // txt_codigoClienteFormato
            // 
            this.txt_codigoClienteFormato.BackColor = System.Drawing.Color.LightGreen;
            this.txt_codigoClienteFormato.Enabled = false;
            this.txt_codigoClienteFormato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoClienteFormato.Location = new System.Drawing.Point(714, 45);
            this.txt_codigoClienteFormato.Name = "txt_codigoClienteFormato";
            this.txt_codigoClienteFormato.Size = new System.Drawing.Size(180, 29);
            this.txt_codigoClienteFormato.TabIndex = 5;
            this.txt_codigoClienteFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_ClientesVisualizarIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.grp_credito);
            this.Controls.Add(fecha_registroLabel1);
            this.Controls.Add(this.fecha_registroDateTimePicker1);
            this.Controls.Add(this.CHECK_tieneCredito);
            this.Controls.Add(precio_asignadoLabel);
            this.Controls.Add(this.precio_asignadoTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(rfcLabel);
            this.Controls.Add(this.rfcTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(cpLabel);
            this.Controls.Add(this.cpTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(coloniaLabel);
            this.Controls.Add(this.coloniaTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.txt_codigoClienteFormato);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "frm_ClientesVisualizarIndividual";
            this.Text = "Visualizar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ClientesVisualizarIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.grp_credito.ResumeLayout(false);
            this.grp_credito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private glacial_almacenDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox coloniaTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox rfcTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox precio_asignadoTextBox;
        private System.Windows.Forms.CheckBox CHECK_tieneCredito;
        private System.Windows.Forms.DateTimePicker fecha_limite_creditoDateTimePicker;
        private System.Windows.Forms.TextBox creditoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker1;
        private System.Windows.Forms.GroupBox grp_credito;
        private System.Windows.Forms.TextBox txt_codigoClienteFormato;
    }
}