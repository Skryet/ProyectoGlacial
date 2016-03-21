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
            this.pnl_BarraEstado = new System.Windows.Forms.Panel();
            this.lbl_MenuActual = new System.Windows.Forms.Label();
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
            this.pnl_BarraEstado.Location = new System.Drawing.Point(10, 766);
            this.pnl_BarraEstado.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            this.pnl_BarraEstado.Size = new System.Drawing.Size(1163, 42);
            this.pnl_BarraEstado.TabIndex = 8;
            // 
            // lbl_MenuActual
            // 
            this.lbl_MenuActual.AutoSize = true;
            this.lbl_MenuActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_MenuActual.Location = new System.Drawing.Point(412, 11);
            this.lbl_MenuActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MenuActual.Name = "lbl_MenuActual";
            this.lbl_MenuActual.Size = new System.Drawing.Size(317, 20);
            this.lbl_MenuActual.TabIndex = 0;
            this.lbl_MenuActual.Text = "Sistema de Gestion de Almacen - Ventas";
            // 
            // pnl_Contenido
            // 
            this.pnl_Contenido.Location = new System.Drawing.Point(246, 113);
            this.pnl_Contenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(927, 644);
            this.pnl_Contenido.TabIndex = 7;
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
            this.pnl_Menu.Location = new System.Drawing.Point(6, 113);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(232, 644);
            this.pnl_Menu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(63, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Catalogo";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray;
            this.btn_Buscar.Location = new System.Drawing.Point(65, 16);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(100, 92);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Image = global::Proyecto_Glacial.Properties.Resources.ModifyButtonBlue;
            this.btn_Modificar.Location = new System.Drawing.Point(63, 485);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(100, 92);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::Proyecto_Glacial.Properties.Resources.DeleteButtonRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(65, 327);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 92);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Agregar.Image = global::Proyecto_Glacial.Properties.Resources.AddButtonBlue;
            this.btn_Agregar.Location = new System.Drawing.Point(65, 170);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 92);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // lbl_Modificar
            // 
            this.lbl_Modificar.AutoSize = true;
            this.lbl_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Modificar.Location = new System.Drawing.Point(57, 578);
            this.lbl_Modificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Modificar.Name = "lbl_Modificar";
            this.lbl_Modificar.Size = new System.Drawing.Size(112, 29);
            this.lbl_Modificar.TabIndex = 3;
            this.lbl_Modificar.Text = "Modificar";
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Eliminar.Location = new System.Drawing.Point(67, 421);
            this.lbl_Eliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(101, 29);
            this.lbl_Eliminar.TabIndex = 2;
            this.lbl_Eliminar.Text = "Eliminar";
            // 
            // lbl_Agregar
            // 
            this.lbl_Agregar.AutoSize = true;
            this.lbl_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Agregar.Location = new System.Drawing.Point(68, 263);
            this.lbl_Agregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Agregar.Name = "lbl_Agregar";
            this.lbl_Agregar.Size = new System.Drawing.Size(99, 29);
            this.lbl_Agregar.TabIndex = 1;
            this.lbl_Agregar.Text = "Agregar";
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ventas.Location = new System.Drawing.Point(488, 22);
            this.lbl_Ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(158, 52);
            this.lbl_Ventas.TabIndex = 0;
            this.lbl_Ventas.Text = "Ventas";
            // 
            // pnl_Encabezado
            // 
            this.pnl_Encabezado.Controls.Add(this.lbl_Ventas);
            this.pnl_Encabezado.Location = new System.Drawing.Point(6, 6);
            this.pnl_Encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Encabezado.Name = "pnl_Encabezado";
            this.pnl_Encabezado.Size = new System.Drawing.Size(1167, 98);
            this.pnl_Encabezado.TabIndex = 5;
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.pnl_BarraEstado);
            this.Controls.Add(this.pnl_Contenido);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Encabezado);
            this.Name = "frm_Ventas";
            this.Text = "SGA - Ventas";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Modificar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Label lbl_Agregar;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Panel pnl_Encabezado;
    }
}