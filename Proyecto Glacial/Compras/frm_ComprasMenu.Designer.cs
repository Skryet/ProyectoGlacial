namespace Proyecto_Glacial.Compras
{
    partial class frm_ComprasMenu
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
            this.pnl_barraEstado = new System.Windows.Forms.Panel();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.pnl_ContenidoCentro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_MenuIzquierdo = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.comprasTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.lista_material_comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_material_comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter();
            this.pnl_barraEstado.SuspendLayout();
            this.pnl_ContenidoCentro.SuspendLayout();
            this.pnl_MenuIzquierdo.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_barraEstado
            // 
            this.pnl_barraEstado.Controls.Add(this.lbl_Estado);
            this.pnl_barraEstado.Location = new System.Drawing.Point(5, 618);
            this.pnl_barraEstado.Name = "pnl_barraEstado";
            this.pnl_barraEstado.Size = new System.Drawing.Size(901, 38);
            this.pnl_barraEstado.TabIndex = 8;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(9, 8);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(108, 24);
            this.lbl_Estado.TabIndex = 0;
            this.lbl_Estado.Text = "Estado....";
            // 
            // pnl_ContenidoCentro
            // 
            this.pnl_ContenidoCentro.Controls.Add(this.label1);
            this.pnl_ContenidoCentro.Location = new System.Drawing.Point(192, 91);
            this.pnl_ContenidoCentro.Name = "pnl_ContenidoCentro";
            this.pnl_ContenidoCentro.Size = new System.Drawing.Size(714, 523);
            this.pnl_ContenidoCentro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 185);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú de Compras\r\n\r\nSistema de Administración\r\n\r\nGlacial\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_MenuIzquierdo
            // 
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Agregar);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Eliminar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Eliminar);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Agregar);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_BuscarTodo);
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Buscar);
            this.pnl_MenuIzquierdo.Location = new System.Drawing.Point(5, 91);
            this.pnl_MenuIzquierdo.Name = "pnl_MenuIzquierdo";
            this.pnl_MenuIzquierdo.Size = new System.Drawing.Size(181, 523);
            this.pnl_MenuIzquierdo.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddIconBlue_02_1;
            this.btn_Agregar.Location = new System.Drawing.Point(47, 194);
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
            this.lbl_Eliminar.Location = new System.Drawing.Point(46, 401);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(85, 22);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteProductRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(47, 318);
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
            this.lbl_Agregar.Location = new System.Drawing.Point(45, 277);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(86, 22);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.GraphsGreen;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(47, 64);
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
            this.lbl_Buscar.Location = new System.Drawing.Point(43, 147);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(80, 22);
            this.lbl_Buscar.TabIndex = 0;
            this.lbl_Buscar.Text = "Informe";
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lbl_Clientes);
            this.pnl_Header.Location = new System.Drawing.Point(5, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(901, 80);
            this.pnl_Header.TabIndex = 5;
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(371, 16);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(182, 43);
            this.lbl_Clientes.TabIndex = 0;
            this.lbl_Clientes.Text = "Compras";
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "compras";
            this.comprasBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = this.comprasTableAdapter;            
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // lista_material_comprasBindingSource
            // 
            this.lista_material_comprasBindingSource.DataMember = "lista_material_compras";
            this.lista_material_comprasBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // lista_material_comprasTableAdapter
            // 
            this.lista_material_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ComprasMenu
            // 
            this.ClientSize = new System.Drawing.Size(918, 661);
            this.Controls.Add(this.pnl_barraEstado);
            this.Controls.Add(this.pnl_ContenidoCentro);
            this.Controls.Add(this.pnl_MenuIzquierdo);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_ComprasMenu";
            this.Text = "Menú de Compras";
            this.Load += new System.EventHandler(this.frm_ComprasMenu_Load);
            this.pnl_barraEstado.ResumeLayout(false);
            this.pnl_barraEstado.PerformLayout();
            this.pnl_ContenidoCentro.ResumeLayout(false);
            this.pnl_ContenidoCentro.PerformLayout();
            this.pnl_MenuIzquierdo.ResumeLayout(false);
            this.pnl_MenuIzquierdo.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_material_comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_barraEstado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Panel pnl_ContenidoCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_MenuIzquierdo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Clientes;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.comprasTableAdapter comprasTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lista_material_comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.lista_material_comprasTableAdapter lista_material_comprasTableAdapter;
    }
}