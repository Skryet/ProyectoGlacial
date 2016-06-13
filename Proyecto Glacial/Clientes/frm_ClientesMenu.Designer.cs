namespace Proyecto_Glacial
{
    partial class frm_ClientesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ClientesMenu));
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_MenuIzquierdo = new System.Windows.Forms.Panel();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.pnl_ContenidoCentro = new System.Windows.Forms.Panel();
            this.pnl_barraEstado = new System.Windows.Forms.Panel();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Creditos = new System.Windows.Forms.Label();
            this.btn_Creditos = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.clientesTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.pnl_Header.SuspendLayout();
            this.pnl_MenuIzquierdo.SuspendLayout();
            this.pnl_barraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(544, 18);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(165, 43);
            this.lbl_Clientes.TabIndex = 0;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lbl_Clientes);
            this.pnl_Header.Location = new System.Drawing.Point(4, 6);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1353, 80);
            this.pnl_Header.TabIndex = 1;
            // 
            // pnl_MenuIzquierdo
            // 
            this.pnl_MenuIzquierdo.Controls.Add(this.lbl_Creditos);
            this.pnl_MenuIzquierdo.Controls.Add(this.btn_Creditos);
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
            this.pnl_MenuIzquierdo.Size = new System.Drawing.Size(181, 578);
            this.pnl_MenuIzquierdo.TabIndex = 2;
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modificar.Location = new System.Drawing.Point(44, 435);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(95, 22);
            this.lbl_Modificar.TabIndex = 3;
            this.lbl_Modificar.Text = "Modificar";
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(48, 320);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(85, 22);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar.Location = new System.Drawing.Point(47, 202);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(86, 22);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(45, 90);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(92, 22);
            this.lbl_Buscar.TabIndex = 0;
            this.lbl_Buscar.Text = "Catálogo";
            // 
            // pnl_ContenidoCentro
            // 
            this.pnl_ContenidoCentro.Location = new System.Drawing.Point(191, 93);
            this.pnl_ContenidoCentro.Name = "pnl_ContenidoCentro";
            this.pnl_ContenidoCentro.Size = new System.Drawing.Size(1166, 523);
            this.pnl_ContenidoCentro.TabIndex = 3;
            // 
            // pnl_barraEstado
            // 
            this.pnl_barraEstado.Controls.Add(this.lbl_Estado);
            this.pnl_barraEstado.Location = new System.Drawing.Point(191, 620);
            this.pnl_barraEstado.Name = "pnl_barraEstado";
            this.pnl_barraEstado.Size = new System.Drawing.Size(981, 51);
            this.pnl_barraEstado.TabIndex = 4;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(18, 14);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(108, 24);
            this.lbl_Estado.TabIndex = 0;
            this.lbl_Estado.Text = "Estado....";
            // 
            // lbl_Creditos
            // 
            this.lbl_Creditos.AutoSize = true;
            this.lbl_Creditos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Creditos.Location = new System.Drawing.Point(45, 547);
            this.lbl_Creditos.Name = "lbl_Creditos";
            this.lbl_Creditos.Size = new System.Drawing.Size(88, 22);
            this.lbl_Creditos.TabIndex = 8;
            this.lbl_Creditos.Text = "Creditos";
            // 
            // btn_Creditos
            // 
            this.btn_Creditos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Creditos.Image")));
            this.btn_Creditos.Location = new System.Drawing.Point(48, 464);
            this.btn_Creditos.Name = "btn_Creditos";
            this.btn_Creditos.Size = new System.Drawing.Size(80, 80);
            this.btn_Creditos.TabIndex = 9;
            this.btn_Creditos.UseVisualStyleBackColor = true;
            this.btn_Creditos.Click += new System.EventHandler(this.btn_Creditos_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Image = global::Proyecto_Glacial.Properties.Resources.ModifyButtonBlue;
            this.btn_Modificar.Location = new System.Drawing.Point(49, 352);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(80, 80);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            this.btn_Agregar.Location = new System.Drawing.Point(49, 122);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(80, 80);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(49, 237);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(80, 80);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonAllGray;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(49, 7);
            this.btn_BuscarTodo.Name = "btn_BuscarTodo";
            this.btn_BuscarTodo.Size = new System.Drawing.Size(80, 80);
            this.btn_BuscarTodo.TabIndex = 5;
            this.btn_BuscarTodo.UseVisualStyleBackColor = true;
            this.btn_BuscarTodo.Click += new System.EventHandler(this.btn_Buscar_Click);
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
            // frm_ClientesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 678);
            this.Controls.Add(this.pnl_barraEstado);
            this.Controls.Add(this.pnl_ContenidoCentro);
            this.Controls.Add(this.pnl_MenuIzquierdo);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_ClientesMenu";
            this.Text = "Menu Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ClientesMenu_FormClosed);
            this.Load += new System.EventHandler(this.frm_ClientesMenu_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_MenuIzquierdo.ResumeLayout(false);
            this.pnl_MenuIzquierdo.PerformLayout();
            this.pnl_barraEstado.ResumeLayout(false);
            this.pnl_barraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_MenuIzquierdo;
        private System.Windows.Forms.Panel pnl_ContenidoCentro;
        private System.Windows.Forms.Panel pnl_barraEstado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_Estado;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private glacial_almacenDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lbl_Creditos;
        private System.Windows.Forms.Button btn_Creditos;
    }
}