namespace G8_MillenniumCode
{
	partial class frm_AccesoBBDD
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
			this.components = new System.ComponentModel.Container();
			this.lbl_codi = new System.Windows.Forms.Label();
			this.lbl_agencia = new System.Windows.Forms.Label();
			this.txt_agencia = new G8M_LibreriaControles.SWTextbox();
			this.txt_codi = new G8M_LibreriaControles.SWTextbox();
			this.btn_actualitzar = new System.Windows.Forms.Button();
			this.btn_value = new System.Windows.Forms.Button();
			this.dgv_BBDDdata = new System.Windows.Forms.DataGridView();
			this.secureCoreDataSet = new G8_MillenniumCode.SecureCoreDataSet();
			this.secureCoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.richtxt_dataset = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_BBDDdata)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSetBindingSource)).BeginInit();
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
			// btn_actualitzar
			// 
			this.btn_actualitzar.Location = new System.Drawing.Point(349, 269);
			this.btn_actualitzar.Name = "btn_actualitzar";
			this.btn_actualitzar.Size = new System.Drawing.Size(107, 23);
			this.btn_actualitzar.TabIndex = 4;
			this.btn_actualitzar.Text = "Actualitzar";
			this.btn_actualitzar.UseVisualStyleBackColor = true;
			// 
			// btn_value
			// 
			this.btn_value.Location = new System.Drawing.Point(462, 269);
			this.btn_value.Name = "btn_value";
			this.btn_value.Size = new System.Drawing.Size(107, 23);
			this.btn_value.TabIndex = 5;
			this.btn_value.Text = "Value DataSet";
			this.btn_value.UseVisualStyleBackColor = true;
			// 
			// dgv_BBDDdata
			// 
			this.dgv_BBDDdata.AutoGenerateColumns = false;
			this.dgv_BBDDdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_BBDDdata.DataSource = this.secureCoreDataSetBindingSource;
			this.dgv_BBDDdata.Location = new System.Drawing.Point(12, 113);
			this.dgv_BBDDdata.Name = "dgv_BBDDdata";
			this.dgv_BBDDdata.Size = new System.Drawing.Size(557, 150);
			this.dgv_BBDDdata.TabIndex = 6;
			// 
			// secureCoreDataSet
			// 
			this.secureCoreDataSet.DataSetName = "SecureCoreDataSet";
			this.secureCoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// secureCoreDataSetBindingSource
			// 
			this.secureCoreDataSetBindingSource.DataSource = this.secureCoreDataSet;
			this.secureCoreDataSetBindingSource.Position = 0;
			// 
			// richtxt_dataset
			// 
			this.richtxt_dataset.Location = new System.Drawing.Point(12, 317);
			this.richtxt_dataset.Name = "richtxt_dataset";
			this.richtxt_dataset.Size = new System.Drawing.Size(557, 167);
			this.richtxt_dataset.TabIndex = 7;
			this.richtxt_dataset.Text = "";
			// 
			// frm_AccesoBBDD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.istockphoto_606667670_612x612;
			this.ClientSize = new System.Drawing.Size(596, 496);
			this.Controls.Add(this.richtxt_dataset);
			this.Controls.Add(this.dgv_BBDDdata);
			this.Controls.Add(this.btn_value);
			this.Controls.Add(this.btn_actualitzar);
			this.Controls.Add(this.lbl_agencia);
			this.Controls.Add(this.lbl_codi);
			this.Controls.Add(this.txt_agencia);
			this.Controls.Add(this.txt_codi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_AccesoBBDD";
			this.Text = "frm_AccesoBBDD";
			((System.ComponentModel.ISupportInitialize)(this.dgv_BBDDdata)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private G8M_LibreriaControles.SWTextbox txt_codi;
		private G8M_LibreriaControles.SWTextbox txt_agencia;
		private System.Windows.Forms.Label lbl_codi;
		private System.Windows.Forms.Label lbl_agencia;
		private System.Windows.Forms.Button btn_actualitzar;
		private System.Windows.Forms.Button btn_value;
		private System.Windows.Forms.DataGridView dgv_BBDDdata;
		private System.Windows.Forms.BindingSource secureCoreDataSetBindingSource;
		private SecureCoreDataSet secureCoreDataSet;
		private System.Windows.Forms.RichTextBox richtxt_dataset;
	}
}