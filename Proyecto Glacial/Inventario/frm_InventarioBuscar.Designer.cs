namespace Proyecto_Glacial.Inventario
{
    partial class frm_InventarioBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_SelccionarTipo = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_BuscarTodo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar \r\nTodo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(499, 145);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(75, 22);
            this.lbl_Buscar.TabIndex = 23;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // cmb_SelccionarTipo
            // 
            this.cmb_SelccionarTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SelccionarTipo.FormattingEnabled = true;
            this.cmb_SelccionarTipo.Items.AddRange(new object[] {
            "Número de Cliente",
            "Apellido Paterno"});
            this.cmb_SelccionarTipo.Location = new System.Drawing.Point(12, 101);
            this.cmb_SelccionarTipo.Name = "cmb_SelccionarTipo";
            this.cmb_SelccionarTipo.Size = new System.Drawing.Size(194, 30);
            this.cmb_SelccionarTipo.TabIndex = 21;
            this.cmb_SelccionarTipo.Text = "Seleccione";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(212, 102);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(276, 29);
            this.txt_Buscar.TabIndex = 19;
            // 
            // btn_BuscarTodo
            // 
            this.btn_BuscarTodo.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonAllGray;
            this.btn_BuscarTodo.Location = new System.Drawing.Point(588, 62);
            this.btn_BuscarTodo.Name = "btn_BuscarTodo";
            this.btn_BuscarTodo.Size = new System.Drawing.Size(80, 80);
            this.btn_BuscarTodo.TabIndex = 24;
            this.btn_BuscarTodo.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = global::Proyecto_Glacial.Properties.Resources.SearchButtonGray_02_;
            this.btn_Buscar.Location = new System.Drawing.Point(494, 62);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(80, 80);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // frm_InventarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarTodo);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cmb_SelccionarTipo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Name = "frm_InventarioBuscar";
            this.Text = "Inventario Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BuscarTodo;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cmb_SelccionarTipo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
    }
}