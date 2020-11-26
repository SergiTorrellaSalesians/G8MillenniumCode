namespace G8M_FormBase
{
	partial class frm_InsideTemplate
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
			this.btn_actualitzar = new System.Windows.Forms.Button();
			this.dtg_BBDDdata = new System.Windows.Forms.DataGridView();
			this.btn_value = new System.Windows.Forms.Button();
			this.richtxt_dataset = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtg_BBDDdata)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_actualitzar
			// 
			this.btn_actualitzar.Location = new System.Drawing.Point(411, 309);
			this.btn_actualitzar.Name = "btn_actualitzar";
			this.btn_actualitzar.Size = new System.Drawing.Size(107, 23);
			this.btn_actualitzar.TabIndex = 5;
			this.btn_actualitzar.Text = "Actualitzar";
			this.btn_actualitzar.UseVisualStyleBackColor = true;
			// 
			// dtg_BBDDdata
			// 
			this.dtg_BBDDdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtg_BBDDdata.BackgroundColor = System.Drawing.Color.Black;
			this.dtg_BBDDdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_BBDDdata.GridColor = System.Drawing.Color.Yellow;
			this.dtg_BBDDdata.Location = new System.Drawing.Point(12, 150);
			this.dtg_BBDDdata.Name = "dtg_BBDDdata";
			this.dtg_BBDDdata.Size = new System.Drawing.Size(619, 150);
			this.dtg_BBDDdata.TabIndex = 7;
			// 
			// btn_value
			// 
			this.btn_value.Location = new System.Drawing.Point(524, 309);
			this.btn_value.Name = "btn_value";
			this.btn_value.Size = new System.Drawing.Size(107, 23);
			this.btn_value.TabIndex = 8;
			this.btn_value.Text = "Value DataSet";
			this.btn_value.UseVisualStyleBackColor = true;
			// 
			// richtxt_dataset
			// 
			this.richtxt_dataset.Location = new System.Drawing.Point(12, 338);
			this.richtxt_dataset.Name = "richtxt_dataset";
			this.richtxt_dataset.Size = new System.Drawing.Size(619, 167);
			this.richtxt_dataset.TabIndex = 9;
			this.richtxt_dataset.Text = "";
			// 
			// frm_InsideTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = global::G8M_FormBase.Properties.Resources.istockphoto_606667670_612x612;
			this.ClientSize = new System.Drawing.Size(643, 517);
			this.Controls.Add(this.richtxt_dataset);
			this.Controls.Add(this.btn_value);
			this.Controls.Add(this.dtg_BBDDdata);
			this.Controls.Add(this.btn_actualitzar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_InsideTemplate";
			this.Text = "frm_InsideTemplate";
			this.Load += new System.EventHandler(this.frm_InsideTemplate_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtg_BBDDdata)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Button btn_actualitzar;
		public System.Windows.Forms.DataGridView dtg_BBDDdata;
		public System.Windows.Forms.Button btn_value;
		public System.Windows.Forms.RichTextBox richtxt_dataset;
	}
}