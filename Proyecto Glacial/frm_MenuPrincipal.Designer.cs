namespace Proyecto_Glacial
{
    partial class frm_MenuPrincipal
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
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(409, 204);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_Clientes);
            this.Name = "frm_MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes;
    }
}

