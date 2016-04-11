namespace Proyecto_Glacial.Compras
{
    partial class frm_ComprasBuscar
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
            this.comprasDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.comprasTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.comprasTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comprasDataGridView
            // 
            this.comprasDataGridView.AutoGenerateColumns = false;
            this.comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.comprasDataGridView.DataSource = this.comprasBindingSource;
            this.comprasDataGridView.Location = new System.Drawing.Point(12, 141);
            this.comprasDataGridView.MultiSelect = false;
            this.comprasDataGridView.Name = "comprasDataGridView";
            this.comprasDataGridView.ReadOnly = true;
            this.comprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comprasDataGridView.Size = new System.Drawing.Size(567, 220);
            this.comprasDataGridView.TabIndex = 1;
            this.comprasDataGridView.Click += new System.EventHandler(this.comprasDataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rango de Fechas:";
            // 
            // date_inicio
            // 
            this.date_inicio.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_inicio.Location = new System.Drawing.Point(25, 72);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(200, 26);
            this.date_inicio.TabIndex = 3;
            this.date_inicio.ValueChanged += new System.EventHandler(this.date_inicio_ValueChanged);
            // 
            // date_fin
            // 
            this.date_fin.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fin.Location = new System.Drawing.Point(273, 72);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(200, 26);
            this.date_fin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 43);
            this.label2.TabIndex = 33;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 44);
            this.label3.TabIndex = 37;
            this.label3.Text = "Buscar \r\nTodo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(513, 95);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(75, 22);
            this.lbl_Buscar.TabIndex = 35;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 44);
            this.label4.TabIndex = 39;
            this.label4.Text = "Detalles de la\r\ncompra";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_Glacial.Properties.Resources.business;
            this.button1.Location = new System.Drawing.Point(611, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonAllGray;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(611, 14);
            this.btn_BuscarTodo.Name = "btn_BuscarTodo";
            this.btn_BuscarTodo.Size = new System.Drawing.Size(80, 80);
            this.btn_BuscarTodo.TabIndex = 36;
            this.btn_BuscarTodo.UseVisualStyleBackColor = true;
            this.btn_BuscarTodo.Click += new System.EventHandler(this.btn_BuscarTodo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            this.btn_Buscar.Location = new System.Drawing.Point(508, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 80);
            this.btn_Buscar.TabIndex = 34;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_compra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de Compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_pago";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo de Pago";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "autorizacion";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Autorización";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.tableAdapterManager.empresaTableAdapter = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // frm_ComprasBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_BuscarTodo);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_fin);
            this.Controls.Add(this.date_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comprasDataGridView);
            this.Name = "frm_ComprasBuscar";
            this.Text = "Informe de Compras";
            this.Activated += new System.EventHandler(this.frm_ComprasBuscar_Activated);
            this.Load += new System.EventHandler(this.frm_ComprasBuscar_Load);
            this.Enter += new System.EventHandler(this.frm_ComprasBuscar_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private glacial_almacenDataSetTableAdapters.comprasTableAdapter comprasTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView comprasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}