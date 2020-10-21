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
			this.SuspendLayout();
			// 
			// formShowPanel
			// 
			this.formShowPanel.BackColor = System.Drawing.Color.Transparent;
			this.formShowPanel.Location = new System.Drawing.Point(167, 50);
			this.formShowPanel.Name = "formShowPanel";
			this.formShowPanel.Size = new System.Drawing.Size(619, 304);
			this.formShowPanel.TabIndex = 3;
			// 
			// frm_PantallaPrincipal
			// 
			this.ClientSize = new System.Drawing.Size(798, 366);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MAIN";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
	}
}
