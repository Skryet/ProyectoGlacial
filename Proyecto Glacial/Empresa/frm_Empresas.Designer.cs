namespace Proyecto_Glacial.Empresa
{
    partial class frm_Empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Empresas));
            this.pnl_Contenido = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Modificar = new System.Windows.Forms.Label();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.lbl_Agregar = new System.Windows.Forms.Label();
            this.pnl_Encabezado = new System.Windows.Forms.Panel();
            this.lbl_Provedores = new System.Windows.Forms.Label();
            this.pnl_BarraEstado = new System.Windows.Forms.Panel();
            this.lbl_MenuActual = new System.Windows.Forms.Label();
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.empresaTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Encabezado.SuspendLayout();
            this.pnl_BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Contenido
            // 
            resources.ApplyResources(this.pnl_Contenido, "pnl_Contenido");
            this.pnl_Contenido.Name = "pnl_Contenido";
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
            resources.ApplyResources(this.pnl_Menu, "pnl_Menu");
            this.pnl_Menu.Name = "pnl_Menu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            resources.ApplyResources(this.btn_Buscar, "btn_Buscar");
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Modificar
            // 
            resources.ApplyResources(this.btn_Modificar, "btn_Modificar");
            this.btn_Modificar.Image = global::Proyecto_Glacial.Properties.Resources.ModifyButtonBlue;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            resources.ApplyResources(this.btn_Eliminar, "btn_Eliminar");
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            resources.ApplyResources(this.btn_Agregar, "btn_Agregar");
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Modificar
            // 
            resources.ApplyResources(this.lbl_Modificar, "lbl_Modificar");
            this.lbl_Modificar.Name = "lbl_Modificar";
            // 
            // lbl_Eliminar
            // 
            resources.ApplyResources(this.lbl_Eliminar, "lbl_Eliminar");
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            // 
            // lbl_Agregar
            // 
            resources.ApplyResources(this.lbl_Agregar, "lbl_Agregar");
            this.lbl_Agregar.Name = "lbl_Agregar";
            // 
            // pnl_Encabezado
            // 
            this.pnl_Encabezado.Controls.Add(this.lbl_Provedores);
            resources.ApplyResources(this.pnl_Encabezado, "pnl_Encabezado");
            this.pnl_Encabezado.Name = "pnl_Encabezado";
            // 
            // lbl_Provedores
            // 
            resources.ApplyResources(this.lbl_Provedores, "lbl_Provedores");
            this.lbl_Provedores.Name = "lbl_Provedores";
            // 
            // pnl_BarraEstado
            // 
            this.pnl_BarraEstado.Controls.Add(this.lbl_MenuActual);
            resources.ApplyResources(this.pnl_BarraEstado, "pnl_BarraEstado");
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            // 
            // lbl_MenuActual
            // 
            resources.ApplyResources(this.lbl_MenuActual, "lbl_MenuActual");
            this.lbl_MenuActual.Name = "lbl_MenuActual";
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "empresa";
            this.empresaBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.empresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            //this.tableAdapterManager.material_comprasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_Empresas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Contenido);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Encabezado);
            this.Controls.Add(this.pnl_BarraEstado);
            this.Name = "frm_Empresas";
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_Encabezado.ResumeLayout(false);
            this.pnl_Encabezado.PerformLayout();
            this.pnl_BarraEstado.ResumeLayout(false);
            this.pnl_BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Contenido;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Panel pnl_Encabezado;
        private System.Windows.Forms.Label lbl_Provedores;
        private System.Windows.Forms.Panel pnl_BarraEstado;
        private System.Windows.Forms.Label lbl_MenuActual;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private glacial_almacenDataSetTableAdapters.empresaTableAdapter empresaTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}