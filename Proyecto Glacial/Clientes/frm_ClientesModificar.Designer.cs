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
            System.Windows.Forms.Label apellidoPLabel;
            System.Windows.Forms.Label apellidoMLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label rfcLabel;
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoPLabel = new System.Windows.Forms.Label();
            apellidoMLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            rfcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(469, 9);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(185, 22);
            id_clienteLabel.TabIndex = 0;
            id_clienteLabel.Text = "Número de Cliente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(12, 9);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(113, 22);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre(s):";
            // 
            // apellidoPLabel
            // 
            apellidoPLabel.AutoSize = true;
            apellidoPLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoPLabel.Location = new System.Drawing.Point(8, 66);
            apellidoPLabel.Name = "apellidoPLabel";
            apellidoPLabel.Size = new System.Drawing.Size(168, 22);
            apellidoPLabel.TabIndex = 4;
            apellidoPLabel.Text = "Apellido Paterno:";
            // 
            // apellidoMLabel
            // 
            apellidoMLabel.AutoSize = true;
            apellidoMLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoMLabel.Location = new System.Drawing.Point(258, 66);
            apellidoMLabel.Name = "apellidoMLabel";
            apellidoMLabel.Size = new System.Drawing.Size(171, 22);
            apellidoMLabel.TabIndex = 6;
            apellidoMLabel.Text = "Apellido Materno:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(8, 123);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(103, 22);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(261, 125);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(84, 22);
            coloniaLabel.TabIndex = 10;
            coloniaLabel.Text = "Colonia:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(513, 125);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(81, 22);
            ciudadLabel.TabIndex = 12;
            ciudadLabel.Text = "Ciudad:";
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpLabel.Location = new System.Drawing.Point(8, 191);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(143, 22);
            cpLabel.TabIndex = 14;
            cpLabel.Text = "Código Postal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(553, 315);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 22);
            label1.TabIndex = 17;
            label1.Text = "Guardar";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(157, 191);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(73, 22);
            correoLabel.TabIndex = 18;
            correoLabel.Text = "Correo";
            // 
            // rfcLabel
            // 
            rfcLabel.AutoSize = true;
            rfcLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rfcLabel.Location = new System.Drawing.Point(12, 248);
            rfcLabel.Name = "rfcLabel";
            rfcLabel.Size = new System.Drawing.Size(55, 22);
            rfcLabel.TabIndex = 20;
            rfcLabel.Text = "RFC:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id_cliente", true));
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(494, 34);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(142, 29);
            this.txt_cliente.TabIndex = 1;
            this.txt_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txt_Nombre
            // 
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.txt_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(12, 34);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(427, 29);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidoP", true));
            this.txt_apellidoP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoP.Location = new System.Drawing.Point(12, 91);
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(243, 29);
            this.txt_apellidoP.TabIndex = 5;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidoM", true));
            this.txt_apellidoM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoM.Location = new System.Drawing.Point(261, 91);
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(250, 29);
            this.txt_apellidoM.TabIndex = 7;
            // 
            // txt_direccion
            // 
            this.txt_direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txt_direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(12, 150);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(243, 29);
            this.txt_direccion.TabIndex = 9;
            // 
            // txt_colonia
            // 
            this.txt_colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "colonia", true));
            this.txt_colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_colonia.Location = new System.Drawing.Point(265, 153);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(246, 29);
            this.txt_colonia.TabIndex = 10;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ciudad", true));
            this.txt_ciudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(517, 153);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(137, 29);
            this.txt_ciudad.TabIndex = 11;
            // 
            // txt_cp
            // 
            this.txt_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cp", true));
            this.txt_cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cp.Location = new System.Drawing.Point(12, 216);
            this.txt_cp.MaxLength = 5;
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(139, 29);
            this.txt_cp.TabIndex = 12;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_Actualizar.Location = new System.Drawing.Point(556, 232);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(80, 80);
            this.btn_Actualizar.TabIndex = 16;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
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
            //this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // txt_correo
            // 
            this.txt_correo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.txt_correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(161, 216);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(378, 29);
            this.txt_correo.TabIndex = 13;
            // 
            // txt_rfc
            // 
            this.txt_rfc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "rfc", true));
            this.txt_rfc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.Location = new System.Drawing.Point(12, 273);
            this.txt_rfc.MaxLength = 15;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(180, 29);
            this.txt_rfc.TabIndex = 14;
            // 
            // frm_ClientesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 378);
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
            this.Controls.Add(apellidoMLabel);
            this.Controls.Add(this.txt_apellidoM);
            this.Controls.Add(apellidoPLabel);
            this.Controls.Add(this.txt_apellidoP);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.txt_cliente);
            this.Name = "frm_ClientesModificar";
            this.Text = "Clientes - Modificar";
            this.Load += new System.EventHandler(this.frm_ClientesModificar_Load);
            this.Enter += new System.EventHandler(this.frm_ClientesModificar_Enter);
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
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_rfc;
    }
}