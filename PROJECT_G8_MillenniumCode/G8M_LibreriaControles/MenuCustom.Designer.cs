namespace G8M_LibreriaControles
{
	partial class MenuCustom
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
			this.MenuPanel = new System.Windows.Forms.Panel();
			this.newLogo = new System.Windows.Forms.PictureBox();
			this.MenuPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.newLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuPanel
			// 
			this.MenuPanel.AutoScroll = true;
			this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
			this.MenuPanel.Controls.Add(this.newLogo);
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 0);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(149, 287);
			this.MenuPanel.TabIndex = 5;
			// 
			// newLogo
			// 
			this.newLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.newLogo.Image = global::G8M_LibreriaControles.Properties.Resources.Reverse_LOGO;
			this.newLogo.Location = new System.Drawing.Point(0, 0);
			this.newLogo.Name = "newLogo";
			this.newLogo.Size = new System.Drawing.Size(149, 50);
			this.newLogo.TabIndex = 0;
			this.newLogo.TabStop = false;
			// 
			// MenuCustom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MenuPanel);
			this.Name = "MenuCustom";
			this.Size = new System.Drawing.Size(173, 287);
			this.MenuPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.newLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MenuPanel;
		private System.Windows.Forms.PictureBox newLogo;
	}
}
