﻿namespace Proyecto_Glacial.Proveedores
{
    partial class frm_ProveedorModificar
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
            System.Windows.Forms.Label lbl_RFC;
            System.Windows.Forms.Label lbl_Cp;
            System.Windows.Forms.Label lbl_email;
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Guardar = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.txt_Colonia = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.proveedoresTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedoresTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Cancelar = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_Colonia = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_Telefono = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_RFC = new System.Windows.Forms.Label();
            lbl_Cp = new System.Windows.Forms.Label();
            lbl_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Estado.Location = new System.Drawing.Point(85, 243);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(64, 18);
            lbl_Estado.TabIndex = 21;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_Colonia
            // 
            lbl_Colonia.AutoSize = true;
            lbl_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Colonia.Location = new System.Drawing.Point(85, 196);
            lbl_Colonia.Name = "lbl_Colonia";
            lbl_Colonia.Size = new System.Drawing.Size(68, 18);
            lbl_Colonia.TabIndex = 19;
            lbl_Colonia.Text = "Colonia";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Direccion.Location = new System.Drawing.Point(85, 151);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new System.Drawing.Size(85, 18);
            lbl_Direccion.TabIndex = 17;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Telefono.Location = new System.Drawing.Point(85, 106);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new System.Drawing.Size(77, 18);
            lbl_Telefono.TabIndex = 15;
            lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Nombre.Location = new System.Drawing.Point(85, 61);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(71, 18);
            lbl_Nombre.TabIndex = 13;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_RFC
            // 
            lbl_RFC.AutoSize = true;
            lbl_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_RFC.Location = new System.Drawing.Point(85, 382);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new System.Drawing.Size(57, 18);
            lbl_RFC.TabIndex = 37;
            lbl_RFC.Text = "R.F.C.";
            // 
            // lbl_Cp
            // 
            lbl_Cp.AutoSize = true;
            lbl_Cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_Cp.Location = new System.Drawing.Point(85, 337);
            lbl_Cp.Name = "lbl_Cp";
            lbl_Cp.Size = new System.Drawing.Size(41, 18);
            lbl_Cp.TabIndex = 35;
            lbl_Cp.Text = "C.P.";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            lbl_email.Location = new System.Drawing.Point(85, 291);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new System.Drawing.Size(51, 18);
            lbl_email.TabIndex = 34;
            lbl_email.Text = "Email";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::Proyecto_Glacial.Properties.Resources.diskette;
            this.btn_Guardar.Location = new System.Drawing.Point(995, 431);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 75);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Guardar
            // 
            this.lbl_Guardar.AutoSize = true;
            this.lbl_Guardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Guardar.Location = new System.Drawing.Point(950, 507);
            this.lbl_Guardar.Name = "lbl_Guardar";
            this.lbl_Guardar.Size = new System.Drawing.Size(168, 22);
            this.lbl_Guardar.TabIndex = 23;
            this.lbl_Guardar.Text = "Guardar cambios";
            // 
            // txt_Estado
            // 
            this.txt_Estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "estado", true));
            this.txt_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(182, 240);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(231, 26);
            this.txt_Estado.TabIndex = 22;
            this.txt_Estado.TextChanged += new System.EventHandler(this.despintarTexto);
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
            // txt_Colonia
            // 
            this.txt_Colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "colonia", true));
            this.txt_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Colonia.Location = new System.Drawing.Point(182, 193);
            this.txt_Colonia.Name = "txt_Colonia";
            this.txt_Colonia.Size = new System.Drawing.Size(356, 26);
            this.txt_Colonia.TabIndex = 20;
            this.txt_Colonia.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "direccion", true));
            this.txt_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(182, 148);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(347, 26);
            this.txt_Direccion.TabIndex = 18;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "telefono", true));
            this.txt_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(182, 103);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(169, 26);
            this.txt_Telefono.TabIndex = 16;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.despintarTexto);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "nombre", true));
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(182, 58);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(355, 26);
            this.txt_Nombre.TabIndex = 14;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.despintarTexto);
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
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::Proyecto_Glacial.Properties.Resources.remove_button;
            this.btn_Cancelar.Location = new System.Drawing.Point(851, 431);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancelar.TabIndex = 28;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.AutoSize = true;
            this.lbl_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Cancelar.Location = new System.Drawing.Point(845, 507);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(92, 22);
            this.lbl_Cancelar.TabIndex = 27;
            this.lbl_Cancelar.Text = "Cancelar";
            // 
            // txt_RFC
            // 
            this.txt_RFC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "rfc", true));
            this.txt_RFC.Enabled = false;
            this.txt_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_RFC.Location = new System.Drawing.Point(182, 379);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(231, 26);
            this.txt_RFC.TabIndex = 39;
            // 
            // txt_cp
            // 
            this.txt_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "cp", true));
            this.txt_cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_cp.Location = new System.Drawing.Point(182, 334);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 26);
            this.txt_cp.TabIndex = 38;
            // 
            // txt_Email
            // 
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "correo", true));
            this.txt_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Email.Location = new System.Drawing.Point(182, 288);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(306, 26);
            this.txt_Email.TabIndex = 36;
            // 
            // frm_ProveedorModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 554);
            this.Controls.Add(lbl_RFC);
            this.Controls.Add(this.txt_RFC);
            this.Controls.Add(lbl_Cp);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(lbl_email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_Guardar);
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
            this.Name = "frm_ProveedorModificar";
            this.Text = "Proveedor - Modificar";
            this.Load += new System.EventHandler(this.frm_ProveedorModificar_Load);
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
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Guardar;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Colonia;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Cancelar;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_Email;
    }
}