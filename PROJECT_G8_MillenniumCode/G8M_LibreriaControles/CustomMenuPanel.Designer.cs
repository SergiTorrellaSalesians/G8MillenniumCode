namespace G8M_LibreriaControles
{
	partial class CustomMenuPanel
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
			this.logoImage = new System.Windows.Forms.PictureBox();
			this.MenuPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuPanel
			// 
			this.MenuPanel.BackColor = System.Drawing.Color.Yellow;
			this.MenuPanel.Controls.Add(this.logoImage);
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 0);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(161, 414);
			this.MenuPanel.TabIndex = 5;
			// 
			// logoImage
			// 
			this.logoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.logoImage.Image = global::G8M_LibreriaControles.Properties.Resources.Reverse_LOGO;
			this.logoImage.Location = new System.Drawing.Point(0, 3);
			this.logoImage.Name = "logoImage";
			this.logoImage.Size = new System.Drawing.Size(140, 81);
			this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImage.TabIndex = 5;
			this.logoImage.TabStop = false;
			// 
			// CustomMenuPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MenuPanel);
			this.Name = "CustomMenuPanel";
			this.Size = new System.Drawing.Size(663, 414);
			this.MenuPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MenuPanel;
		private System.Windows.Forms.PictureBox logoImage;
	}
}
