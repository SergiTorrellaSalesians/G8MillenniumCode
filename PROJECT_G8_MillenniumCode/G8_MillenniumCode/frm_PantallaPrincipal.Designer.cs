namespace G8_MillenniumCode
{
	partial class frm_PantallaPrincipal
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

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.formShowPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new G8M_LibreriaControles.MenuCustom();
            this.SuspendLayout();
            // 
            // formShowPanel
            // 
            this.formShowPanel.AutoSize = true;
            this.formShowPanel.BackColor = System.Drawing.Color.Transparent;
            this.formShowPanel.Location = new System.Drawing.Point(169, 39);
            this.formShowPanel.Name = "formShowPanel";
            this.formShowPanel.Size = new System.Drawing.Size(629, 325);
            this.formShowPanel.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 39);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(149, 325);
            this.MenuPanel.TabIndex = 0;
            // 
            // frm_PantallaPrincipal
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 364);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.formShowPanel);
            this.Name = "frm_PantallaPrincipal";
            this.TopBar_Title = "MAIN";
            this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
            this.Controls.SetChildIndex(this.formShowPanel, 0);
            this.Controls.SetChildIndex(this.MenuPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
		private G8M_LibreriaControles.MenuCustom MenuPanel;
	}
}
