namespace Proyecto_Glacial.Ventas
{
    partial class frm_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ventas));
            this.pnl_BarraEstado = new System.Windows.Forms.Panel();
            this.lbl_MenuActual = new System.Windows.Forms.Label();
            this.pnl_Contenido = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Catalogo = new System.Windows.Forms.Label();
            this.lbl_PoductoEliminar = new System.Windows.Forms.Label();
            this.lbl_NuevaVenta = new System.Windows.Forms.Label();
            this.btn_NuevaVenta = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.lbl_Ver = new System.Windows.Forms.Label();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.pnl_Encabezado = new System.Windows.Forms.Panel();
            this.pnl_BarraEstado.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BarraEstado
            // 
            this.pnl_BarraEstado.Controls.Add(this.lbl_MenuActual);
            this.pnl_BarraEstado.Location = new System.Drawing.Point(6, 691);
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            this.pnl_BarraEstado.Size = new System.Drawing.Size(1341, 34);
            this.pnl_BarraEstado.TabIndex = 8;
            // 
            // lbl_MenuActual
            // 
            this.lbl_MenuActual.AutoSize = true;
            this.lbl_MenuActual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MenuActual.Location = new System.Drawing.Point(549, 9);
            this.lbl_MenuActual.Name = "lbl_MenuActual";
            this.lbl_MenuActual.Size = new System.Drawing.Size(266, 15);
            this.lbl_MenuActual.TabIndex = 0;
            this.lbl_MenuActual.Text = "Sistema de Gestion de Almacen - Ventas";
            // 
            // pnl_Contenido
            // 
            this.pnl_Contenido.Location = new System.Drawing.Point(184, 92);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(1163, 594);
            this.pnl_Contenido.TabIndex = 7;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.lbl_Catalogo);
            this.pnl_Menu.Controls.Add(this.lbl_PoductoEliminar);
            this.pnl_Menu.Controls.Add(this.lbl_NuevaVenta);
            this.pnl_Menu.Controls.Add(this.btn_NuevaVenta);
            this.pnl_Menu.Controls.Add(this.btn_Eliminar);
            this.pnl_Menu.Controls.Add(this.btn_Agregar);
            this.pnl_Menu.Controls.Add(this.lbl_Eliminar);
            this.pnl_Menu.Controls.Add(this.lbl_Ver);
            this.pnl_Menu.Location = new System.Drawing.Point(4, 92);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(174, 593);
            this.pnl_Menu.TabIndex = 6;
            // 
            // lbl_Catalogo
            // 
            this.lbl_Catalogo.AutoSize = true;
            this.lbl_Catalogo.Enabled = false;
            this.lbl_Catalogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Catalogo.Location = new System.Drawing.Point(42, 332);
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(92, 22);
            this.lbl_Catalogo.TabIndex = 14;
            this.lbl_Catalogo.Text = "Catalogo";
            this.lbl_Catalogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PoductoEliminar
            // 
            this.lbl_PoductoEliminar.AutoSize = true;
            this.lbl_PoductoEliminar.Enabled = false;
            this.lbl_PoductoEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PoductoEliminar.Location = new System.Drawing.Point(42, 488);
            this.lbl_PoductoEliminar.Name = "lbl_PoductoEliminar";
            this.lbl_PoductoEliminar.Size = new System.Drawing.Size(93, 22);
            this.lbl_PoductoEliminar.TabIndex = 12;
            this.lbl_PoductoEliminar.Text = "producto";
            // 
            // lbl_NuevaVenta
            // 
            this.lbl_NuevaVenta.AutoSize = true;
            this.lbl_NuevaVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaVenta.Location = new System.Drawing.Point(51, 161);
            this.lbl_NuevaVenta.Name = "lbl_NuevaVenta";
            this.lbl_NuevaVenta.Size = new System.Drawing.Size(73, 22);
            this.lbl_NuevaVenta.TabIndex = 11;
            this.lbl_NuevaVenta.Text = "Ventas";
            // 
            // btn_NuevaVenta
            // 
            this.btn_NuevaVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_NuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevaVenta.Image")));
            this.btn_NuevaVenta.Location = new System.Drawing.Point(49, 85);
            this.btn_NuevaVenta.Name = "btn_NuevaVenta";
            this.btn_NuevaVenta.Size = new System.Drawing.Size(75, 75);
            this.btn_NuevaVenta.TabIndex = 10;
            this.btn_NuevaVenta.UseVisualStyleBackColor = false;
            this.btn_NuevaVenta.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(49, 389);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 75);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Agregar.Enabled = false;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.Location = new System.Drawing.Point(49, 234);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 75);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Enabled = false;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(46, 467);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(85, 22);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // lbl_Ver
            // 
            this.lbl_Ver.AutoSize = true;
            this.lbl_Ver.Enabled = false;
            this.lbl_Ver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ver.Location = new System.Drawing.Point(66, 310);
            this.lbl_Ver.Name = "lbl_Ver";
            this.lbl_Ver.Size = new System.Drawing.Size(42, 22);
            this.lbl_Ver.TabIndex = 1;
            this.lbl_Ver.Text = "Ver";
            this.lbl_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ventas.Location = new System.Drawing.Point(626, 18);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(135, 40);
            this.lbl_Ventas.TabIndex = 0;
            this.lbl_Ventas.Text = "Ventas";
            // 
            // pnl_Encabezado
            // 
            this.pnl_Encabezado.Controls.Add(this.lbl_Ventas);
            this.pnl_Encabezado.Location = new System.Drawing.Point(4, 5);
            this.pnl_Encabezado.Name = "pnl_Encabezado";
            this.pnl_Encabezado.Size = new System.Drawing.Size(1343, 80);
            this.pnl_Encabezado.TabIndex = 5;
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnl_BarraEstado);
            this.Controls.Add(this.pnl_Contenido);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Encabezado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Ventas";
            this.Text = "SGA - Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ventas_FormClosing);
            this.pnl_BarraEstado.ResumeLayout(false);
            this.pnl_BarraEstado.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_Encabezado.ResumeLayout(false);
            this.pnl_Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BarraEstado;
        private System.Windows.Forms.Label lbl_MenuActual;
        private System.Windows.Forms.Panel pnl_Contenido;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_NuevaVenta;
        private System.Windows.Forms.Button btn_NuevaVenta;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Label lbl_Ver;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Panel pnl_Encabezado;
        private System.Windows.Forms.Label lbl_PoductoEliminar;
        private System.Windows.Forms.Label lbl_Catalogo;
    }
}