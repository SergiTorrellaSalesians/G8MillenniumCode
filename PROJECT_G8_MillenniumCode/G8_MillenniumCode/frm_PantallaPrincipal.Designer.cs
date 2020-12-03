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
			this.txt_idUserRank = new System.Windows.Forms.Label();
			this.txt_userName = new System.Windows.Forms.Label();
			this.txt_codeUser = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.MenuPanel = new G8M_LibreriaControles.MenuCustom();
			this.formShowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// formShowPanel
			// 
			this.formShowPanel.AutoSize = true;
			this.formShowPanel.BackColor = System.Drawing.Color.Transparent;
			this.formShowPanel.Controls.Add(this.txt_idUserRank);
			this.formShowPanel.Controls.Add(this.txt_userName);
			this.formShowPanel.Controls.Add(this.txt_codeUser);
			this.formShowPanel.Controls.Add(this.pictureBox2);
			this.formShowPanel.Location = new System.Drawing.Point(155, 39);
			this.formShowPanel.Name = "formShowPanel";
			this.formShowPanel.Size = new System.Drawing.Size(308, 334);
			this.formShowPanel.TabIndex = 3;
			// 
			// txt_idUserRank
			// 
			this.txt_idUserRank.AutoSize = true;
			this.txt_idUserRank.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_idUserRank.ForeColor = System.Drawing.Color.Yellow;
			this.txt_idUserRank.Location = new System.Drawing.Point(14, 56);
			this.txt_idUserRank.Name = "txt_idUserRank";
			this.txt_idUserRank.Size = new System.Drawing.Size(70, 21);
			this.txt_idUserRank.TabIndex = 9;
			this.txt_idUserRank.Text = "RANK:";
			// 
			// txt_userName
			// 
			this.txt_userName.AutoSize = true;
			this.txt_userName.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_userName.ForeColor = System.Drawing.Color.Yellow;
			this.txt_userName.Location = new System.Drawing.Point(14, 35);
			this.txt_userName.Name = "txt_userName";
			this.txt_userName.Size = new System.Drawing.Size(70, 21);
			this.txt_userName.TabIndex = 8;
			this.txt_userName.Text = "USER:";
			// 
			// txt_codeUser
			// 
			this.txt_codeUser.AutoSize = true;
			this.txt_codeUser.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_codeUser.ForeColor = System.Drawing.Color.Yellow;
			this.txt_codeUser.Location = new System.Drawing.Point(14, 14);
			this.txt_codeUser.Name = "txt_codeUser";
			this.txt_codeUser.Size = new System.Drawing.Size(82, 21);
			this.txt_codeUser.TabIndex = 6;
			this.txt_codeUser.Text = "CODE: ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.noms;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(131, 260);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(174, 71);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// MenuPanel
			// 
			this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 39);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(149, 333);
			this.MenuPanel.TabIndex = 0;
			// 
			// frm_PantallaPrincipal
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(465, 372);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MAIN";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.Controls.SetChildIndex(this.MenuPanel, 0);
			this.formShowPanel.ResumeLayout(false);
			this.formShowPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
		private G8M_LibreriaControles.MenuCustom MenuPanel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label txt_codeUser;
		private System.Windows.Forms.Label txt_userName;
		private System.Windows.Forms.Label txt_idUserRank;
	}
}
