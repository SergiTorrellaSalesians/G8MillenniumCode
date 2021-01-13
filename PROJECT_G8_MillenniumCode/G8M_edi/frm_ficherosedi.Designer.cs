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
            this.txbSelectedFile = new System.Windows.Forms.TextBox();
            this.dtgFiles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generaredi
            // 
            this.btn_generaredi.Location = new System.Drawing.Point(169, 202);
            this.btn_generaredi.Name = "btn_generaredi";
            this.btn_generaredi.Size = new System.Drawing.Size(75, 23);
            this.btn_generaredi.TabIndex = 1;
            this.btn_generaredi.Text = "Generar EDI";
            this.btn_generaredi.UseVisualStyleBackColor = true;
            this.btn_generaredi.Click += new System.EventHandler(this.btn_generaredi_Click);
            // 
            // txbSelectedFile
            // 
            this.txbSelectedFile.Location = new System.Drawing.Point(116, 153);
            this.txbSelectedFile.Margin = new System.Windows.Forms.Padding(2);
            this.txbSelectedFile.Name = "txbSelectedFile";
            this.txbSelectedFile.Size = new System.Drawing.Size(171, 20);
            this.txbSelectedFile.TabIndex = 4;
            // 
            // dtgFiles
            // 
            this.dtgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiles.Location = new System.Drawing.Point(341, 86);
            this.dtgFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFiles.Name = "dtgFiles";
            this.dtgFiles.RowHeadersWidth = 51;
            this.dtgFiles.RowTemplate.Height = 24;
            this.dtgFiles.Size = new System.Drawing.Size(180, 202);
            this.dtgFiles.TabIndex = 5;
            // 
            // frm_buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(658, 393);
            this.Controls.Add(this.dtgFiles);
            this.Controls.Add(this.txbSelectedFile);
            this.Controls.Add(this.btn_generaredi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_buscador";
            this.Text = "frm_buscador";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button btn_generaredi;
        private System.Windows.Forms.TextBox txbSelectedFile;
        private System.Windows.Forms.DataGridView dtgFiles;
    }
}