namespace G8_RepteEntityFramework
{
	partial class frm_repte
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
            this.components = new System.ComponentModel.Container();
            this.tbx_idcontact = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_birthdate = new System.Windows.Forms.TextBox();
            this.dtg_newcontacts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_newproduct = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.secureCoreDataSet = new G8_RepteEntityFramework.SecureCoreDataSet();
            this.newContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newContactTableAdapter = new G8_RepteEntityFramework.SecureCoreDataSetTableAdapters.NewContactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_newcontacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_idcontact
            // 
            this.tbx_idcontact.Location = new System.Drawing.Point(122, 39);
            this.tbx_idcontact.Name = "tbx_idcontact";
            this.tbx_idcontact.Size = new System.Drawing.Size(100, 20);
            this.tbx_idcontact.TabIndex = 0;
            this.tbx_idcontact.Tag = "idContact";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(122, 65);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 1;
            this.tbx_name.Tag = "Name";
            // 
            // tbx_birthdate
            // 
            this.tbx_birthdate.Location = new System.Drawing.Point(122, 91);
            this.tbx_birthdate.Name = "tbx_birthdate";
            this.tbx_birthdate.Size = new System.Drawing.Size(100, 20);
            this.tbx_birthdate.TabIndex = 2;
            this.tbx_birthdate.Tag = "BirthDate";
            // 
            // dtg_newcontacts
            // 
            this.dtg_newcontacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_newcontacts.Location = new System.Drawing.Point(56, 133);
            this.dtg_newcontacts.Name = "dtg_newcontacts";
            this.dtg_newcontacts.Size = new System.Drawing.Size(557, 253);
            this.dtg_newcontacts.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "idcontact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "birthdate";
            // 
            // btn_newproduct
            // 
            this.btn_newproduct.Location = new System.Drawing.Point(434, 402);
            this.btn_newproduct.Name = "btn_newproduct";
            this.btn_newproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_newproduct.TabIndex = 7;
            this.btn_newproduct.Text = "New product";
            this.btn_newproduct.UseVisualStyleBackColor = true;
            this.btn_newproduct.Click += new System.EventHandler(this.btn_newproduct_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(538, 402);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // secureCoreDataSet
            // 
            this.secureCoreDataSet.DataSetName = "SecureCoreDataSet";
            this.secureCoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newContactBindingSource
            // 
            this.newContactBindingSource.DataMember = "NewContact";
            this.newContactBindingSource.DataSource = this.secureCoreDataSet;
            // 
            // newContactTableAdapter
            // 
            this.newContactTableAdapter.ClearBeforeFill = true;
            // 
            // frm_repte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_newproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_newcontacts);
            this.Controls.Add(this.tbx_birthdate);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_idcontact);
            this.Name = "frm_repte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_repte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_newcontacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newContactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox tbx_idcontact;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_birthdate;
        private System.Windows.Forms.DataGridView dtg_newcontacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_newproduct;
        private System.Windows.Forms.Button btn_update;
        private SecureCoreDataSet secureCoreDataSet;
        private System.Windows.Forms.BindingSource newContactBindingSource;
        private SecureCoreDataSetTableAdapters.NewContactTableAdapter newContactTableAdapter;
    }
}

