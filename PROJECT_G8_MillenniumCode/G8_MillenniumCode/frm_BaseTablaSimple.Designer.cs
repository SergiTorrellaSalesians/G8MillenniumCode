namespace G8_MillenniumCode
{
	partial class frm_BaseTablaSimple
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
			this.lbl_codi = new System.Windows.Forms.Label();
			this.lbl_agencia = new System.Windows.Forms.Label();
			this.txt_agencia = new G8M_LibreriaControles.SWTextbox();
			this.txt_codi = new G8M_LibreriaControles.SWTextbox();
			this.SuspendLayout();
			// 
			// lbl_codi
			// 
			this.lbl_codi.AutoSize = true;
			this.lbl_codi.BackColor = System.Drawing.Color.Transparent;
			this.lbl_codi.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codi.ForeColor = System.Drawing.Color.White;
			this.lbl_codi.Location = new System.Drawing.Point(45, 26);
			this.lbl_codi.Name = "lbl_codi";
			this.lbl_codi.Size = new System.Drawing.Size(53, 16);
			this.lbl_codi.TabIndex = 2;
			this.lbl_codi.Text = "Codi:";
			// 
			// lbl_agencia
			// 
			this.lbl_agencia.AutoSize = true;
			this.lbl_agencia.BackColor = System.Drawing.Color.Transparent;
			this.lbl_agencia.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_agencia.ForeColor = System.Drawing.Color.White;
			this.lbl_agencia.Location = new System.Drawing.Point(18, 62);
			this.lbl_agencia.Name = "lbl_agencia";
			this.lbl_agencia.Size = new System.Drawing.Size(80, 16);
			this.lbl_agencia.TabIndex = 3;
			this.lbl_agencia.Text = "Agencia:";
			// 
			// txt_agencia
			// 
			this.txt_agencia.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_agencia.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_agencia.Location = new System.Drawing.Point(104, 62);
			this.txt_agencia.Name = "txt_agencia";
			this.txt_agencia.Size = new System.Drawing.Size(100, 20);
			this.txt_agencia.TabIndex = 1;
			this.txt_agencia.Tag = "descAgency";
			// 
			// txt_codi
			// 
			this.txt_codi.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_codi.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_codi.Location = new System.Drawing.Point(104, 26);
			this.txt_codi.Name = "txt_codi";
			this.txt_codi.Size = new System.Drawing.Size(100, 20);
			this.txt_codi.TabIndex = 0;
			// 
			// frm_BaseTablaSimple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.istockphoto_606667670_612x612;
			this.ClientSize = new System.Drawing.Size(643, 517);
			this.Controls.Add(this.lbl_agencia);
			this.Controls.Add(this.lbl_codi);
			this.Controls.Add(this.txt_agencia);
			this.Controls.Add(this.txt_codi);
			this.Name = "frm_BaseTablaSimple";
			this.Text = "frm_AccesoBBDD";
			this.Load += new System.EventHandler(this.frm_BaseTablaSimple_Load);
			this.Controls.SetChildIndex(this.btn_actualitzar, 0);
			this.Controls.SetChildIndex(this.btn_value, 0);
			this.Controls.SetChildIndex(this.richtxt_dataset, 0);
			this.Controls.SetChildIndex(this.txt_codi, 0);
			this.Controls.SetChildIndex(this.txt_agencia, 0);
			this.Controls.SetChildIndex(this.lbl_codi, 0);
			this.Controls.SetChildIndex(this.lbl_agencia, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private G8M_LibreriaControles.SWTextbox txt_codi;
		private G8M_LibreriaControles.SWTextbox txt_agencia;
		private System.Windows.Forms.Label lbl_codi;
		private System.Windows.Forms.Label lbl_agencia;
	}
}