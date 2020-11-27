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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MenuPanel = new G8M_LibreriaControles.MenuCustom();
			this.formShowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// formShowPanel
			// 
			this.formShowPanel.AutoSize = true;
			this.formShowPanel.BackColor = System.Drawing.Color.Transparent;
			this.formShowPanel.Controls.Add(this.pictureBox2);
			this.formShowPanel.Controls.Add(this.pictureBox1);
			this.formShowPanel.Location = new System.Drawing.Point(155, 39);
			this.formShowPanel.Name = "formShowPanel";
			this.formShowPanel.Size = new System.Drawing.Size(646, 387);
			this.formShowPanel.TabIndex = 3;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.noms;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(405, 227);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(226, 157);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.Reverse_LOGO;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(11, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(418, 360);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MenuPanel
			// 
			this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 39);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(149, 362);
			this.MenuPanel.TabIndex = 0;
			// 
			// frm_PantallaPrincipal
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(798, 401);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MAIN";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.Controls.SetChildIndex(this.MenuPanel, 0);
			this.formShowPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
		private G8M_LibreriaControles.MenuCustom MenuPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
