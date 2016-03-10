namespace Proyecto_Glacial
{
    partial class frm_Proveedores
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
            this.lbl_Provedores = new System.Windows.Forms.Label();
            this.pnl_Encabezado = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.pnl_Contenido = new System.Windows.Forms.Panel();
            this.pnl_BarraEstado = new System.Windows.Forms.Panel();
            this.lbl_MenuActual = new System.Windows.Forms.Label();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.proveedoresTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedoresTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.pnl_Encabezado.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Provedores
            // 
            this.lbl_Provedores.AutoSize = true;
            this.lbl_Provedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Provedores.Location = new System.Drawing.Point(299, 18);
            this.lbl_Provedores.Name = "lbl_Provedores";
            this.lbl_Provedores.Size = new System.Drawing.Size(235, 40);
            this.lbl_Provedores.TabIndex = 0;
            this.lbl_Provedores.Text = "Proveedores";
            // 
            // pnl_Encabezado
            // 
            this.pnl_Encabezado.Controls.Add(this.lbl_Provedores);
            this.pnl_Encabezado.Location = new System.Drawing.Point(4, 6);
            this.pnl_Encabezado.Name = "pnl_Encabezado";
            this.pnl_Encabezado.Size = new System.Drawing.Size(875, 80);
            this.pnl_Encabezado.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.label1);
            this.pnl_Menu.Controls.Add(this.btn_Buscar);
            this.pnl_Menu.Controls.Add(this.btn_Modificar);
            this.pnl_Menu.Controls.Add(this.btn_Eliminar);
            this.pnl_Menu.Controls.Add(this.btn_Agregar);
            this.pnl_Menu.Controls.Add(this.lbl_Modificar);
            this.pnl_Menu.Controls.Add(this.lbl_Eliminar);
            this.pnl_Menu.Controls.Add(this.lbl_Agregar);
            this.pnl_Menu.Location = new System.Drawing.Point(4, 93);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(174, 523);
            this.pnl_Menu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Catalogo";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            this.btn_Buscar.Location = new System.Drawing.Point(49, 13);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 75);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::Proyecto_Glacial.Properties.Resources.ModifyButtonBlue;
            this.btn_Modificar.Location = new System.Drawing.Point(47, 394);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 75);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(49, 266);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 75);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            this.btn_Agregar.Location = new System.Drawing.Point(49, 138);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 75);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Modificar.Location = new System.Drawing.Point(37, 470);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(95, 22);
            this.lbl_Modificar.TabIndex = 3;
            this.lbl_Modificar.Text = "Modificar";
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Eliminar.Location = new System.Drawing.Point(43, 342);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(85, 22);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lbl_Agregar.Location = new System.Drawing.Point(44, 214);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(86, 22);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // pnl_Contenido
            // 
            this.pnl_Contenido.Location = new System.Drawing.Point(184, 93);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(695, 523);
            this.pnl_Contenido.TabIndex = 3;
            // 
            // pnl_BarraEstado
            // 
            this.pnl_BarraEstado.Controls.Add(this.lbl_MenuActual);
            this.pnl_BarraEstado.Location = new System.Drawing.Point(7, 623);
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            this.pnl_BarraEstado.Size = new System.Drawing.Size(872, 34);
            this.pnl_BarraEstado.TabIndex = 4;
            // 
            // lbl_MenuActual
            // 
            this.lbl_MenuActual.AutoSize = true;
            this.lbl_MenuActual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbl_MenuActual.Location = new System.Drawing.Point(298, 9);
            this.lbl_MenuActual.Name = "lbl_MenuActual";
            this.lbl_MenuActual.Size = new System.Drawing.Size(290, 16);
            this.lbl_MenuActual.TabIndex = 0;
            this.lbl_MenuActual.Text = "Sistema de Gestion de Almacen - Clientes";
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
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.pnl_BarraEstado);
            this.Controls.Add(this.pnl_Contenido);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Encabezado);
            this.Name = "frm_Proveedores";
            this.Text = "SGA - Proveedores";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            this.pnl_Encabezado.ResumeLayout(false);
            this.pnl_Encabezado.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_BarraEstado.ResumeLayout(false);
            this.pnl_BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Provedores;
        private System.Windows.Forms.Panel pnl_Encabezado;
        private System.Windows.Forms.Panel pnl_Menu;        
        private System.Windows.Forms.Panel pnl_Contenido;
        private System.Windows.Forms.Panel pnl_BarraEstado;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Label lbl_MenuActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private glacial_almacenDataSetTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}