namespace G8M_PantallaBuscador
{
	partial class frm_buscador
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
            this.btn_generaredi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generaredi
            // 
            this.btn_generaredi.Location = new System.Drawing.Point(319, 201);
            this.btn_generaredi.Name = "btn_generaredi";
            this.btn_generaredi.Size = new System.Drawing.Size(75, 23);
            this.btn_generaredi.TabIndex = 0;
            this.btn_generaredi.Text = "Generar EDI";
            this.btn_generaredi.UseVisualStyleBackColor = true;
            // 
            // frm_buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::G8M_PantallaBuscador.Properties.Resources.istockphoto_606667670_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generaredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_buscador";
            this.Text = "frm_buscador";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btn_generaredi;
    }
}