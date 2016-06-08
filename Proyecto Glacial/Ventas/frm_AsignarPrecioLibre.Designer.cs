namespace Proyecto_Glacial.Ventas
{
    partial class frm_AsignarPrecioLibre
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
            this.txt_PrecioLibre = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Poducto = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PrecioLibre
            // 
            this.txt_PrecioLibre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_PrecioLibre.Location = new System.Drawing.Point(63, 65);
            this.txt_PrecioLibre.Name = "txt_PrecioLibre";
            this.txt_PrecioLibre.Size = new System.Drawing.Size(204, 26);
            this.txt_PrecioLibre.TabIndex = 0;
            this.txt_PrecioLibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PrecioLibre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioLibre_KeyPress);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Precio.Location = new System.Drawing.Point(16, 20);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(305, 18);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "Establezca el precio que desea dar al";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_Aceptar.Location = new System.Drawing.Point(67, 102);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(94, 32);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Poducto
            // 
            this.lbl_Poducto.AutoSize = true;
            this.lbl_Poducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_Poducto.Location = new System.Drawing.Point(82, 42);
            this.lbl_Poducto.Name = "lbl_Poducto";
            this.lbl_Poducto.Size = new System.Drawing.Size(81, 18);
            this.lbl_Poducto.TabIndex = 3;
            this.lbl_Poducto.Text = "producto";
            this.lbl_Poducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_Cancelar.Location = new System.Drawing.Point(167, 102);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_AsignarPrecioLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 149);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Poducto);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_PrecioLibre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AsignarPrecioLibre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AsignarPrecioLibre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PrecioLibre;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Poducto;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}