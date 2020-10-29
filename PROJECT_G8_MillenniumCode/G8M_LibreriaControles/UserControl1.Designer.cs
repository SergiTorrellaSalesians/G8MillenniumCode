namespace G8M_LibreriaControles
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_codi = new System.Windows.Forms.TextBox();
            this.txt_descripcio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_codi
            // 
            this.txt_codi.Location = new System.Drawing.Point(6, 3);
            this.txt_codi.Name = "txt_codi";
            this.txt_codi.Size = new System.Drawing.Size(45, 22);
            this.txt_codi.TabIndex = 0;
            this.txt_codi.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // txt_descripcio
            // 
            this.txt_descripcio.Enabled = false;
            this.txt_descripcio.Location = new System.Drawing.Point(57, 3);
            this.txt_descripcio.Name = "txt_descripcio";
            this.txt_descripcio.Size = new System.Drawing.Size(226, 22);
            this.txt_descripcio.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_descripcio);
            this.Controls.Add(this.txt_codi);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(286, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codi;
        private System.Windows.Forms.TextBox txt_descripcio;
    }
}
