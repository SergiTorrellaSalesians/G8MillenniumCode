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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lowPanel = new System.Windows.Forms.Panel();
			this.formShowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.MenuPanel.Size = new System.Drawing.Size(149, 359);
			this.MenuPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(181, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "USUARI";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pictureBox1.Image = global::G8_MillenniumCode.Properties.Resources.output_onlinepngtools;
			this.pictureBox1.Location = new System.Drawing.Point(150, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// lowPanel
			// 
			this.lowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lowPanel.ForeColor = System.Drawing.Color.White;
			this.lowPanel.Location = new System.Drawing.Point(149, 379);
			this.lowPanel.Name = "lowPanel";
			this.lowPanel.Size = new System.Drawing.Size(316, 19);
			this.lowPanel.TabIndex = 6;
			// 
			// frm_PantallaPrincipal
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(465, 398);
			this.Controls.Add(this.lowPanel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MAIN";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.Controls.SetChildIndex(this.MenuPanel, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.lowPanel, 0);
			this.formShowPanel.ResumeLayout(false);
			this.formShowPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel lowPanel;
	}
}
