namespace G8M_LibreriaControles
{
    partial class SWComboFK
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
			this.cbx_combofk = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cbx_combofk
			// 
			this.cbx_combofk.FormattingEnabled = true;
			this.cbx_combofk.Location = new System.Drawing.Point(0, 0);
			this.cbx_combofk.Name = "cbx_combofk";
			this.cbx_combofk.Size = new System.Drawing.Size(121, 21);
			this.cbx_combofk.TabIndex = 0;
			this.cbx_combofk.SelectedIndexChanged += new System.EventHandler(this.cbx_combofk_SelectedIndexChanged);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_combofk;
    }
}
