namespace G8M_LibreriaFormsTablas
{
	partial class frm_TablaAgencies
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
			this.txt_codi = new G8M_LibreriaControles.SWTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_agency = new G8M_LibreriaControles.SWTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_codi
			// 
			this.txt_codi.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_codi.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_codi.Location = new System.Drawing.Point(79, 24);
			this.txt_codi.Name = "txt_codi";
			this.txt_codi.Size = new System.Drawing.Size(100, 20);
			this.txt_codi.TabIndex = 10;
			this.txt_codi.Tag = "CodeAgency";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(42, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Codi:";
			// 
			// txt_agency
			// 
			this.txt_agency.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_agency.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_agency.Location = new System.Drawing.Point(79, 50);
			this.txt_agency.Name = "txt_agency";
			this.txt_agency.Size = new System.Drawing.Size(100, 20);
			this.txt_agency.TabIndex = 12;
			this.txt_agency.Tag = "DescAgency";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(27, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Agency:";
			// 
			// frm_TablaAgencies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 518);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_agency);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_codi);
			this.Name = "frm_TablaAgencies";
			this.Text = "frm_TablaAgencies";
			this.Controls.SetChildIndex(this.btn_actualitzar, 0);
			this.Controls.SetChildIndex(this.btn_value, 0);
			this.Controls.SetChildIndex(this.richtxt_dataset, 0);
			this.Controls.SetChildIndex(this.txt_codi, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt_agency, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private G8M_LibreriaControles.SWTextbox txt_codi;
		private System.Windows.Forms.Label label1;
		private G8M_LibreriaControles.SWTextbox txt_agency;
		private System.Windows.Forms.Label label2;
	}
}