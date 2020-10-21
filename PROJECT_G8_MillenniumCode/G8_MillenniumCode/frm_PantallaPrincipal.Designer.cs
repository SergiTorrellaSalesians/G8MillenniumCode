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
			this.MenuPanel = new System.Windows.Forms.Panel();
			this.btn_access = new System.Windows.Forms.Button();
			this.btn_Jobs = new System.Windows.Forms.Button();
			this.btn_Users = new System.Windows.Forms.Button();
			this.btn_HomeMenu = new System.Windows.Forms.Button();
			this.logoImage = new System.Windows.Forms.PictureBox();
			this.MenuPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
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
			// MenuPanel
			// 
			this.MenuPanel.AutoScroll = true;
			this.MenuPanel.BackColor = System.Drawing.Color.Yellow;
			this.MenuPanel.Controls.Add(this.logoImage);
			this.MenuPanel.Controls.Add(this.btn_access);
			this.MenuPanel.Controls.Add(this.btn_Jobs);
			this.MenuPanel.Controls.Add(this.btn_Users);
			this.MenuPanel.Controls.Add(this.btn_HomeMenu);
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 39);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(161, 327);
			this.MenuPanel.TabIndex = 4;
			// 
			// btn_access
			// 
			this.btn_access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_access.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_access.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_access.ForeColor = System.Drawing.Color.White;
			this.btn_access.Location = new System.Drawing.Point(0, 291);
			this.btn_access.Name = "btn_access";
			this.btn_access.Size = new System.Drawing.Size(140, 65);
			this.btn_access.TabIndex = 4;
			this.btn_access.Text = "ACCESS";
			this.btn_access.UseVisualStyleBackColor = false;
			// 
			// btn_Jobs
			// 
			this.btn_Jobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_Jobs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Jobs.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Jobs.ForeColor = System.Drawing.Color.White;
			this.btn_Jobs.Location = new System.Drawing.Point(0, 223);
			this.btn_Jobs.Name = "btn_Jobs";
			this.btn_Jobs.Size = new System.Drawing.Size(140, 65);
			this.btn_Jobs.TabIndex = 3;
			this.btn_Jobs.Text = "JOBS";
			this.btn_Jobs.UseVisualStyleBackColor = false;
			// 
			// btn_Users
			// 
			this.btn_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Users.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Users.ForeColor = System.Drawing.Color.White;
			this.btn_Users.Location = new System.Drawing.Point(0, 155);
			this.btn_Users.Name = "btn_Users";
			this.btn_Users.Size = new System.Drawing.Size(140, 65);
			this.btn_Users.TabIndex = 2;
			this.btn_Users.Text = "USERS";
			this.btn_Users.UseVisualStyleBackColor = false;
			// 
			// btn_HomeMenu
			// 
			this.btn_HomeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_HomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_HomeMenu.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_HomeMenu.ForeColor = System.Drawing.Color.White;
			this.btn_HomeMenu.Location = new System.Drawing.Point(0, 87);
			this.btn_HomeMenu.Name = "btn_HomeMenu";
			this.btn_HomeMenu.Size = new System.Drawing.Size(140, 65);
			this.btn_HomeMenu.TabIndex = 1;
			this.btn_HomeMenu.Text = "HOME MENU";
			this.btn_HomeMenu.UseVisualStyleBackColor = false;
			// 
			// logoImage
			// 
			this.logoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.logoImage.Image = global::G8_MillenniumCode.Properties.Resources.Reverse_LOGO;
			this.logoImage.Location = new System.Drawing.Point(0, 3);
			this.logoImage.Name = "logoImage";
			this.logoImage.Size = new System.Drawing.Size(140, 81);
			this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImage.TabIndex = 5;
			this.logoImage.TabStop = false;
			// 
			// frm_PantallaPrincipal
			// 
			this.ClientSize = new System.Drawing.Size(798, 366);
			this.Controls.Add(this.MenuPanel);
			this.Controls.Add(this.formShowPanel);
			this.Name = "frm_PantallaPrincipal";
			this.TopBar_Title = "MAIN";
			this.Load += new System.EventHandler(this.frm_PantallaPrincipal_Load);
			this.Controls.SetChildIndex(this.formShowPanel, 0);
			this.Controls.SetChildIndex(this.MenuPanel, 0);
			this.MenuPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel formShowPanel;
		private System.Windows.Forms.Panel MenuPanel;
		private System.Windows.Forms.PictureBox logoImage;
		private System.Windows.Forms.Button btn_access;
		private System.Windows.Forms.Button btn_Jobs;
		private System.Windows.Forms.Button btn_Users;
		private System.Windows.Forms.Button btn_HomeMenu;
	}
}
