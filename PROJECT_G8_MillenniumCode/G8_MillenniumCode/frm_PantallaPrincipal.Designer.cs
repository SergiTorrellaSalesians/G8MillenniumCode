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
			this.lowPanel = new System.Windows.Forms.Panel();
			this.txt_topuser = new System.Windows.Forms.Label();
			this.pic_user = new System.Windows.Forms.PictureBox();
			this.lowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
			this.SuspendLayout();
			// 
			// formShowPanel
			// 
			this.formShowPanel.AutoSize = true;
			this.formShowPanel.BackColor = System.Drawing.Color.Transparent;
			this.formShowPanel.Location = new System.Drawing.Point(152, 39);
			this.formShowPanel.Name = "formShowPanel";
			this.formShowPanel.Size = new System.Drawing.Size(449, 338);
			this.formShowPanel.TabIndex = 3;
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
			// lowPanel
			// 
			this.lowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lowPanel.Controls.Add(this.txt_topuser);
			this.lowPanel.Controls.Add(this.pic_user);
			this.lowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lowPanel.ForeColor = System.Drawing.Color.White;
			this.lowPanel.Location = new System.Drawing.Point(149, 379);
			this.lowPanel.Name = "lowPanel";
			this.lowPanel.Size = new System.Drawing.Size(452, 19);
			this.lowPanel.TabIndex = 6;
			// 
			// txt_topuser
			// 
			this.txt_topuser.AutoSize = true;
			this.txt_topuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txt_topuser.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_topuser.ForeColor = System.Drawing.Color.White;
			this.txt_topuser.Location = new System.Drawing.Point(21, 1);
			this.txt_topuser.Name = "txt_topuser";
			this.txt_topuser.Size = new System.Drawing.Size(62, 16);
			this.txt_topuser.TabIndex = 7;
			this.txt_topuser.Text = "USUARI";
			this.txt_topuser.Click += new System.EventHandler(this.txt_topuser_Click);
			// 
			// pic_user
			// 
			this.pic_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pic_user.Image = global::G8_MillenniumCode.Properties.Resources.Blank_profile;
			this.pic_user.Location = new System.Drawing.Point(-1, 0);
			this.pic_user.Name = "pic_user";
			this.pic_user.Size = new System.Drawing.Size(21, 19);
			this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_user.TabIndex = 8;
			this.pic_user.TabStop = false;
			this.pic_user.Click += new System.EventHandler(this.pic_user_Click);
			// 
			// frm_PantallaPrincipal
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(601, 398);
			this.Controls.Add(this.lowPanel);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MILLENNIUM CODE";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.Controls.SetChildIndex(this.MenuPanel, 0);
			this.Controls.SetChildIndex(this.lowPanel, 0);
			this.lowPanel.ResumeLayout(false);
			this.lowPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
		private G8M_LibreriaControles.MenuCustom MenuPanel;
		private System.Windows.Forms.Panel lowPanel;
		private System.Windows.Forms.PictureBox pic_user;
		private System.Windows.Forms.Label txt_topuser;
	}
}
