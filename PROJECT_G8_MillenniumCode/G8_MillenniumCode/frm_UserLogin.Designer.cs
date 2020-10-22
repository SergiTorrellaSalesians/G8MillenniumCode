namespace G8_MillenniumCode
{
	partial class frm_UserLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_username = new System.Windows.Forms.Label();
			this.lbl_password = new System.Windows.Forms.Label();
			this.tbx_username = new System.Windows.Forms.TextBox();
			this.tbx_password = new System.Windows.Forms.TextBox();
			this.tbn_validaciousuari = new System.Windows.Forms.Button();
			this.lbl_msg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.BackColor = System.Drawing.Color.Transparent;
			this.lbl_username.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_username.ForeColor = System.Drawing.Color.Yellow;
			this.lbl_username.Location = new System.Drawing.Point(221, 114);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(75, 24);
			this.lbl_username.TabIndex = 2;
			this.lbl_username.Text = "User:";
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.BackColor = System.Drawing.Color.Transparent;
			this.lbl_password.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_password.ForeColor = System.Drawing.Color.Yellow;
			this.lbl_password.Location = new System.Drawing.Point(169, 155);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(127, 24);
			this.lbl_password.TabIndex = 3;
			this.lbl_password.Text = "Password:";
			// 
			// tbx_username
			// 
			this.tbx_username.Location = new System.Drawing.Point(302, 118);
			this.tbx_username.Name = "tbx_username";
			this.tbx_username.Size = new System.Drawing.Size(153, 20);
			this.tbx_username.TabIndex = 4;
			this.tbx_username.TextChanged += new System.EventHandler(this.tbx_username_TextChanged);
			// 
			// tbx_password
			// 
			this.tbx_password.Location = new System.Drawing.Point(302, 159);
			this.tbx_password.Name = "tbx_password";
			this.tbx_password.PasswordChar = '*';
			this.tbx_password.Size = new System.Drawing.Size(153, 20);
			this.tbx_password.TabIndex = 5;
			this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
			// 
			// tbn_validaciousuari
			// 
			this.tbn_validaciousuari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbn_validaciousuari.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbn_validaciousuari.ForeColor = System.Drawing.Color.Yellow;
			this.tbn_validaciousuari.Location = new System.Drawing.Point(327, 201);
			this.tbn_validaciousuari.Name = "tbn_validaciousuari";
			this.tbn_validaciousuari.Size = new System.Drawing.Size(103, 33);
			this.tbn_validaciousuari.TabIndex = 6;
			this.tbn_validaciousuari.Text = "Login";
			this.tbn_validaciousuari.UseVisualStyleBackColor = true;
			this.tbn_validaciousuari.Click += new System.EventHandler(this.tbn_validaciousuari_Click);
			// 
			// lbl_msg
			// 
			this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
			this.lbl_msg.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_msg.ForeColor = System.Drawing.Color.White;
			this.lbl_msg.Location = new System.Drawing.Point(12, 257);
			this.lbl_msg.Name = "lbl_msg";
			this.lbl_msg.Size = new System.Drawing.Size(644, 55);
			this.lbl_msg.TabIndex = 7;
			this.lbl_msg.Text = "Contrasenya incorrecta";
			this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frm_UserLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 321);
			this.Controls.Add(this.lbl_msg);
			this.Controls.Add(this.tbn_validaciousuari);
			this.Controls.Add(this.tbx_password);
			this.Controls.Add(this.tbx_username);
			this.Controls.Add(this.lbl_password);
			this.Controls.Add(this.lbl_username);
			this.Name = "frm_UserLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_base";
			this.TopBar_Title = "LOGIN";
			this.Load += new System.EventHandler(this.frm_UserLogin_Load);
			this.Controls.SetChildIndex(this.lbl_username, 0);
			this.Controls.SetChildIndex(this.lbl_password, 0);
			this.Controls.SetChildIndex(this.tbx_username, 0);
			this.Controls.SetChildIndex(this.tbx_password, 0);
			this.Controls.SetChildIndex(this.tbn_validaciousuari, 0);
			this.Controls.SetChildIndex(this.lbl_msg, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_username;
		private System.Windows.Forms.Label lbl_password;
		private System.Windows.Forms.TextBox tbx_username;
		private System.Windows.Forms.TextBox tbx_password;
		private System.Windows.Forms.Button tbn_validaciousuari;
		private System.Windows.Forms.Label lbl_msg;
	}
}