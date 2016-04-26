namespace Proyecto_Glacial.Ventas
{
    partial class frm_VentasAgregar
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
            this.rbt_Cliente = new System.Windows.Forms.RadioButton();
            this.rbt_SinRegistro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_SeleccionarCliente = new System.Windows.Forms.Button();
            this.vista_venta_lista_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial.glacial_almacenDataSet();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_Descuento = new System.Windows.Forms.Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.txt_DescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.pnl_Descuento = new System.Windows.Forms.Panel();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.vista_venta_lista_productosTableAdapter = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.vista_venta_lista_productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.dgv_ListaVenta = new System.Windows.Forms.DataGridView();
            this.clm_Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PrecioPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.pnl_Descuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_Cliente
            // 
            this.rbt_Cliente.AutoSize = true;
            this.rbt_Cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbt_Cliente.Location = new System.Drawing.Point(388, 90);
            this.rbt_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_Cliente.Name = "rbt_Cliente";
            this.rbt_Cliente.Size = new System.Drawing.Size(71, 22);
            this.rbt_Cliente.TabIndex = 0;
            this.rbt_Cliente.Text = "Socio";
            this.rbt_Cliente.UseVisualStyleBackColor = true;
            this.rbt_Cliente.CheckedChanged += new System.EventHandler(this.rbt_Cliente_CheckedChanged);
            // 
            // rbt_SinRegistro
            // 
            this.rbt_SinRegistro.AutoSize = true;
            this.rbt_SinRegistro.Checked = true;
            this.rbt_SinRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_SinRegistro.Location = new System.Drawing.Point(58, 100);
            this.rbt_SinRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_SinRegistro.Name = "rbt_SinRegistro";
            this.rbt_SinRegistro.Size = new System.Drawing.Size(82, 22);
            this.rbt_SinRegistro.TabIndex = 2;
            this.rbt_SinRegistro.TabStop = true;
            this.rbt_SinRegistro.Text = "Cliente";
            this.rbt_SinRegistro.UseVisualStyleBackColor = true;
            this.rbt_SinRegistro.CheckedChanged += new System.EventHandler(this.rbt_SinRegistro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo de comprador";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(168, 116);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(473, 26);
            this.txt_Cliente.TabIndex = 4;
            // 
            // btn_SeleccionarCliente
            // 
            this.btn_SeleccionarCliente.Enabled = false;
            this.btn_SeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_SeleccionarCliente.Location = new System.Drawing.Point(645, 116);
            this.btn_SeleccionarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SeleccionarCliente.Name = "btn_SeleccionarCliente";
            this.btn_SeleccionarCliente.Size = new System.Drawing.Size(27, 28);
            this.btn_SeleccionarCliente.TabIndex = 5;
            this.btn_SeleccionarCliente.Text = "...";
            this.btn_SeleccionarCliente.UseVisualStyleBackColor = true;
            this.btn_SeleccionarCliente.Click += new System.EventHandler(this.btn_SeleccionarCliente_Click);
            // 
            // vista_venta_lista_productosBindingSource
            // 
            this.vista_venta_lista_productosBindingSource.DataMember = "vista_venta_lista_productos";
            this.vista_venta_lista_productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(465, 512);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 30);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(112, 405);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(143, 26);
            this.txt_Subtotal.TabIndex = 12;
            this.txt_Subtotal.Text = "0.00";
            this.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.Location = new System.Drawing.Point(31, 408);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(75, 18);
            this.lbl_Subtotal.TabIndex = 13;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IVA.Location = new System.Drawing.Point(31, 439);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(51, 18);
            this.lbl_IVA.TabIndex = 15;
            this.lbl_IVA.Text = "I.V.A.";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IVA.Location = new System.Drawing.Point(112, 436);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.ReadOnly = true;
            this.txt_IVA.Size = new System.Drawing.Size(143, 26);
            this.txt_IVA.TabIndex = 14;
            this.txt_IVA.Text = "0.00";
            this.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(31, 471);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(48, 18);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(112, 468);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(143, 26);
            this.txt_Total.TabIndex = 16;
            this.txt_Total.Text = "0.00";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Descuento
            // 
            this.btn_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Descuento.Location = new System.Drawing.Point(61, 512);
            this.btn_Descuento.Name = "btn_Descuento";
            this.btn_Descuento.Size = new System.Drawing.Size(190, 30);
            this.btn_Descuento.TabIndex = 18;
            this.btn_Descuento.Text = "Aplicar Descuento";
            this.btn_Descuento.UseVisualStyleBackColor = true;
            this.btn_Descuento.Click += new System.EventHandler(this.btn_Descuento_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Enabled = false;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(21, 69);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(123, 18);
            this.lbl_Cantidad.TabIndex = 22;
            this.lbl_Cantidad.Text = "Descontado  $";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Enabled = false;
            this.txt_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descuento.Location = new System.Drawing.Point(147, 66);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.ReadOnly = true;
            this.txt_Descuento.Size = new System.Drawing.Size(132, 26);
            this.txt_Descuento.TabIndex = 21;
            this.txt_Descuento.Text = "0.00";
            this.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDecimas);
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentaje.Location = new System.Drawing.Point(21, 37);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(124, 18);
            this.lbl_Porcentaje.TabIndex = 20;
            this.lbl_Porcentaje.Text = "Porcentage  %";
            // 
            // txt_DescuentoPorcentaje
            // 
            this.txt_DescuentoPorcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescuentoPorcentaje.Location = new System.Drawing.Point(147, 34);
            this.txt_DescuentoPorcentaje.Name = "txt_DescuentoPorcentaje";
            this.txt_DescuentoPorcentaje.Size = new System.Drawing.Size(132, 26);
            this.txt_DescuentoPorcentaje.TabIndex = 19;
            this.txt_DescuentoPorcentaje.Text = "0.00";
            this.txt_DescuentoPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DescuentoPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDecimas);
            this.txt_DescuentoPorcentaje.Leave += new System.EventHandler(this.txt_DescuentoPorcentaje_Leave);
            // 
            // pnl_Descuento
            // 
            this.pnl_Descuento.Controls.Add(this.lbl_Descuento);
            this.pnl_Descuento.Controls.Add(this.lbl_Porcentaje);
            this.pnl_Descuento.Controls.Add(this.lbl_Cantidad);
            this.pnl_Descuento.Controls.Add(this.txt_DescuentoPorcentaje);
            this.pnl_Descuento.Controls.Add(this.txt_Descuento);
            this.pnl_Descuento.Location = new System.Drawing.Point(330, 405);
            this.pnl_Descuento.Name = "pnl_Descuento";
            this.pnl_Descuento.Size = new System.Drawing.Size(284, 94);
            this.pnl_Descuento.TabIndex = 23;
            this.pnl_Descuento.Visible = false;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(40, 3);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(183, 18);
            this.lbl_Descuento.TabIndex = 23;
            this.lbl_Descuento.Text = "Aplicar descuento en:";
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.Location = new System.Drawing.Point(603, 512);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(120, 30);
            this.btn_Finalizar.TabIndex = 24;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // vista_venta_lista_productosTableAdapter
            // 
            this.vista_venta_lista_productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.lista_material_comprasTableAdapter = null;
            this.tableAdapterManager.lista_material_ventasTableAdapter = null;
            this.tableAdapterManager.lista_proveedores_productosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedor_codigoTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // dgv_ListaVenta
            // 
            this.dgv_ListaVenta.AllowUserToAddRows = false;
            this.dgv_ListaVenta.AllowUserToDeleteRows = false;
            this.dgv_ListaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_ListaVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ListaVenta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Linea,
            this.clm_Codigo,
            this.clm_Descripcion,
            this.clm_Unidad,
            this.clm_Cantidad,
            this.clm_PrecioPieza,
            this.clm_Total});
            this.dgv_ListaVenta.Location = new System.Drawing.Point(12, 149);
            this.dgv_ListaVenta.MultiSelect = false;
            this.dgv_ListaVenta.Name = "dgv_ListaVenta";
            this.dgv_ListaVenta.ReadOnly = true;
            this.dgv_ListaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaVenta.Size = new System.Drawing.Size(712, 234);
            this.dgv_ListaVenta.TabIndex = 25;
            this.dgv_ListaVenta.Click += new System.EventHandler(this.dgv_ListaVenta_Click);
            // 
            // clm_Linea
            // 
            this.clm_Linea.HeaderText = "Línea";
            this.clm_Linea.Name = "clm_Linea";
            this.clm_Linea.ReadOnly = true;
            this.clm_Linea.Width = 60;
            // 
            // clm_Codigo
            // 
            this.clm_Codigo.HeaderText = "Código";
            this.clm_Codigo.Name = "clm_Codigo";
            this.clm_Codigo.ReadOnly = true;
            this.clm_Codigo.Width = 65;
            // 
            // clm_Descripcion
            // 
            this.clm_Descripcion.HeaderText = "Descripción";
            this.clm_Descripcion.Name = "clm_Descripcion";
            this.clm_Descripcion.ReadOnly = true;
            this.clm_Descripcion.Width = 88;
            // 
            // clm_Unidad
            // 
            this.clm_Unidad.HeaderText = "Unidad";
            this.clm_Unidad.Name = "clm_Unidad";
            this.clm_Unidad.ReadOnly = true;
            this.clm_Unidad.Width = 66;
            // 
            // clm_Cantidad
            // 
            this.clm_Cantidad.HeaderText = "Cantidad";
            this.clm_Cantidad.Name = "clm_Cantidad";
            this.clm_Cantidad.ReadOnly = true;
            this.clm_Cantidad.Width = 74;
            // 
            // clm_PrecioPieza
            // 
            this.clm_PrecioPieza.HeaderText = "Precio por unidad";
            this.clm_PrecioPieza.Name = "clm_PrecioPieza";
            this.clm_PrecioPieza.ReadOnly = true;
            this.clm_PrecioPieza.Width = 105;
            // 
            // clm_Total
            // 
            this.clm_Total.HeaderText = "Total";
            this.clm_Total.Name = "clm_Total";
            this.clm_Total.ReadOnly = true;
            this.clm_Total.Width = 56;
            // 
            // frm_VentasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 555);
            this.Controls.Add(this.dgv_ListaVenta);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.pnl_Descuento);
            this.Controls.Add(this.btn_Descuento);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_SeleccionarCliente);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbt_SinRegistro);
            this.Controls.Add(this.rbt_Cliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_VentasAgregar";
            this.Text = "Ventas - Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_VentasAgregar_FormClosing);
            this.Load += new System.EventHandler(this.frm_VentasAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_venta_lista_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.pnl_Descuento.ResumeLayout(false);
            this.pnl_Descuento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Cliente;
        private System.Windows.Forms.RadioButton rbt_SinRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_SeleccionarCliente;
        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource vista_venta_lista_productosBindingSource;
        private glacial_almacenDataSetTableAdapters.vista_venta_lista_productosTableAdapter vista_venta_lista_productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Descuento;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.TextBox txt_DescuentoPorcentaje;
        private System.Windows.Forms.Panel pnl_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.DataGridView dgv_ListaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PrecioPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Total;
    }
}