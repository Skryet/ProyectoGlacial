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
            System.Windows.Forms.Label apellidoPLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label apellidoMLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label lbl_RFC;
            System.Windows.Forms.Label lbl_Cp;
            System.Windows.Forms.Label lbl_email;
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoPLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            apellidoMLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            lbl_RFC = new System.Windows.Forms.Label();
            lbl_Cp = new System.Windows.Forms.Label();
            lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(7, 49);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(97, 18);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre(s):";
            // 
            // apellidoPLabel
            // 
            apellidoPLabel.AutoSize = true;
            apellidoPLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoPLabel.Location = new System.Drawing.Point(7, 86);
            apellidoPLabel.Name = "apellidoPLabel";
            apellidoPLabel.Size = new System.Drawing.Size(145, 18);
            apellidoPLabel.TabIndex = 3;
            apellidoPLabel.Text = "Apellido Paterno:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(7, 127);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(90, 18);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Dirección:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(454, 127);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(73, 18);
            coloniaLabel.TabIndex = 7;
            coloniaLabel.Text = "Colonia:";
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpLabel.Location = new System.Drawing.Point(7, 211);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(123, 18);
            cpLabel.TabIndex = 9;
            cpLabel.Text = "Código Postal:";
            // 
            // apellidoMLabel
            // 
            apellidoMLabel.AutoSize = true;
            apellidoMLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoMLabel.Location = new System.Drawing.Point(338, 86);
            apellidoMLabel.Name = "apellidoMLabel";
            apellidoMLabel.Size = new System.Drawing.Size(147, 18);
            apellidoMLabel.TabIndex = 11;
            apellidoMLabel.Text = "Apellido Materno:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(7, 171);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(69, 18);
            ciudadLabel.TabIndex = 13;
            ciudadLabel.Text = "Ciudad:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(110, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 26);
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
            // txtApellidoP
            // 
            this.txtApellidoP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidoP", true));
            this.txtApellidoP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(163, 83);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(169, 26);
            this.txtApellidoP.TabIndex = 2;
            this.txtApellidoP.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txtDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(103, 124);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(345, 26);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtColonia
            // 
            this.txtColonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "colonia", true));
            this.txtColonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(533, 124);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(127, 26);
            this.txtColonia.TabIndex = 5;
            this.txtColonia.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txtCodigoPostal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(141, 208);
            this.txtCodigoPostal.MaxLength = 5;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoPostal.TabIndex = 6;
            this.txtCodigoPostal.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidoM", true));
            this.txtApellidoM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(491, 83);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(169, 26);
            this.txtApellidoM.TabIndex = 3;
            this.txtApellidoM.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txtCiudad
            // 
            this.txtCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ciudad", true));
            this.txtCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(103, 168);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(366, 26);
            this.txtCiudad.TabIndex = 6;
            this.txtCiudad.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Image = global::Proyecto_Glacial.Properties.Resources.AddIconBlue_2_;
            this.btn_AgregarCliente.Location = new System.Drawing.Point(570, 293);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(80, 80);
            this.btn_AgregarCliente.TabIndex = 15;
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
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
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(567, 376);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(87, 18);
            this.lblConfirmar.TabIndex = 16;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // lbl_RFC
            // 
            lbl_RFC.AutoSize = true;
            lbl_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_RFC.Location = new System.Drawing.Point(7, 338);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new System.Drawing.Size(57, 18);
            lbl_RFC.TabIndex = 37;
            lbl_RFC.Text = "R.F.C.";
            // 
            // txt_RFC
            // 
            this.txt_RFC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "rfc", true));
            this.txt_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_RFC.Location = new System.Drawing.Point(104, 335);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(231, 26);
            this.txt_RFC.TabIndex = 39;
            // 
            // lbl_Cp
            // 
            lbl_Cp.AutoSize = true;
            lbl_Cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_Cp.Location = new System.Drawing.Point(7, 297);
            lbl_Cp.Name = "lbl_Cp";
            lbl_Cp.Size = new System.Drawing.Size(41, 18);
            lbl_Cp.TabIndex = 35;
            lbl_Cp.Text = "C.P.";
            // 
            // txt_cp
            // 
            this.txt_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txt_cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_cp.Location = new System.Drawing.Point(104, 294);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 26);
            this.txt_cp.TabIndex = 38;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_email.Location = new System.Drawing.Point(7, 255);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new System.Drawing.Size(51, 18);
            lbl_email.TabIndex = 34;
            lbl_email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.txt_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Email.Location = new System.Drawing.Point(104, 252);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(306, 26);
            this.txt_Email.TabIndex = 36;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(464, 296);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancelar.TabIndex = 41;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.AutoSize = true;
            this.lbl_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Cancelar.Location = new System.Drawing.Point(456, 372);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(95, 22);
            this.lbl_Cancelar.TabIndex = 40;
            this.lbl_Cancelar.Text = "Regresar";
            // 
            // frm_ClientesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Cancelar);
            this.Controls.Add(lbl_RFC);
            this.Controls.Add(this.txt_RFC);
            this.Controls.Add(lbl_Cp);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(lbl_email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(apellidoMLabel);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(cpLabel);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(coloniaLabel);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(apellidoPLabel);
            this.Controls.Add(this.txtApellidoP);
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
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Cancelar;
    }
}