namespace Proyecto_Glacial.Inventario
{
    partial class frm_InventarioMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_MenuIzquierdo = new System.Windows.Forms.Panel();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.pnl_ContenidoCentro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_barraEstado = new System.Windows.Forms.Panel();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.proveedor_codigoTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter();
            this.proveedor_codigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pnl_MenuIzquierdo.SuspendLayout();
            this.pnl_ContenidoCentro.SuspendLayout();
            this.pnl_barraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Nombre de Inventario*\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_MenuIzquierdo
            // 
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Modificar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Modificar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Agregar);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Eliminar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Eliminar);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Agregar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_BuscarTodo);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Buscar);
            this.pnl_MenuIzquierdo.Location = new System.Drawing.Point(4, 93);
            this.pnl_MenuIzquierdo.Name = "pnl_MenuIzquierdo";
            this.pnl_MenuIzquierdo.Size = new System.Drawing.Size(181, 523);
            this.pnl_MenuIzquierdo.TabIndex = 3;
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modificar.Location = new System.Drawing.Point(44, 471);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(95, 22);
            this.lbl_Modificar.TabIndex = 3;
            this.lbl_Modificar.Text = "Modificar";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Image = global::Proyecto_Glacial.Properties.Resources.ModifyButtonBlue;
            this.btn_Modificar.Location = new System.Drawing.Point(49, 388);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(80, 80);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            this.btn_Agregar.Location = new System.Drawing.Point(49, 144);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(80, 80);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(48, 351);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(85, 22);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(49, 268);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(80, 80);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar.Location = new System.Drawing.Point(47, 227);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(86, 22);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonAllGray;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(49, 14);
            this.btn_BuscarTodo.Name = "btn_BuscarTodo";
            this.btn_BuscarTodo.Size = new System.Drawing.Size(80, 80);
            this.btn_BuscarTodo.TabIndex = 5;
            this.btn_BuscarTodo.UseVisualStyleBackColor = true;
            this.btn_BuscarTodo.Click += new System.EventHandler(this.btn_BuscarTodo_Click);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(45, 97);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(92, 22);
            this.lbl_Buscar.TabIndex = 0;
            this.lbl_Buscar.Text = "Catálogo";
            // 
            // pnl_ContenidoCentro
            // 
            this.pnl_ContenidoCentro.AutoSize = true;
            this.pnl_ContenidoCentro.Controls.Add(this.label1);
            this.pnl_ContenidoCentro.Location = new System.Drawing.Point(191, 93);
            this.pnl_ContenidoCentro.Name = "pnl_ContenidoCentro";
            this.pnl_ContenidoCentro.Size = new System.Drawing.Size(981, 523);
            this.pnl_ContenidoCentro.TabIndex = 4;
            this.pnl_ContenidoCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ContenidoCentro_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 185);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú de Inventario\r\n\r\nSistema de Administración\r\n\r\nGlacial\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_barraEstado
            // 
            this.pnl_barraEstado.Controls.Add(this.lbl_Estado);
            this.pnl_barraEstado.Location = new System.Drawing.Point(4, 622);
            this.pnl_barraEstado.Name = "pnl_barraEstado";
            this.pnl_barraEstado.Size = new System.Drawing.Size(1168, 38);
            this.pnl_barraEstado.TabIndex = 5;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(3, 7);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(108, 24);
            this.lbl_Estado.TabIndex = 0;
            this.lbl_Estado.Text = "Estado....";
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.proveedor_codigoTableAdapter = this.proveedor_codigoTableAdapter;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // proveedor_codigoTableAdapter
            // 
            this.proveedor_codigoTableAdapter.ClearBeforeFill = true;
            // 
            // proveedor_codigoBindingSource
            // 
            this.proveedor_codigoBindingSource.DataMember = "proveedor_codigo";
            this.proveedor_codigoBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // frm_InventarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.pnl_barraEstado);
            this.Controls.Add(this.pnl_ContenidoCentro);
            this.Controls.Add(this.pnl_MenuIzquierdo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_InventarioMenu";
            this.Text = "Menú Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_InventarioMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_MenuIzquierdo.ResumeLayout(false);
            this.pnl_MenuIzquierdo.PerformLayout();
            this.pnl_ContenidoCentro.ResumeLayout(false);
            this.pnl_ContenidoCentro.PerformLayout();
            this.pnl_barraEstado.ResumeLayout(false);
            this.pnl_barraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_codigoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_MenuIzquierdo;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Panel pnl_ContenidoCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_barraEstado;
        private System.Windows.Forms.Label lbl_Estado;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private glacial_almacenDataSetTableAdapters.proveedor_codigoTableAdapter proveedor_codigoTableAdapter;
        private System.Windows.Forms.BindingSource proveedor_codigoBindingSource;
        private System.Windows.Forms.Label label2;
    }
}