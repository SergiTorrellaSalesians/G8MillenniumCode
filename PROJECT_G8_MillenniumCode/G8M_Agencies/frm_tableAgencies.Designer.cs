
namespace G8M_TableAgencies
{
    partial class frm_tableAgencies
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_agency = new G8M_LibreriaControles.SWTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_codi = new G8M_LibreriaControles.SWTextbox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(50, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Agency:";
			// 
			// txt_agency
			// 
			this.txt_agency._TableBind = "DescAgency";
			this.txt_agency.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
			this.txt_agency.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_agency.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_agency.Location = new System.Drawing.Point(102, 65);
			this.txt_agency.Name = "txt_agency";
			this.txt_agency.Size = new System.Drawing.Size(100, 20);
			this.txt_agency.TabIndex = 16;
			this.txt_agency.Tag = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(65, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Codi:";
			// 
			// txt_codi
			// 
			this.txt_codi._TableBind = "CodeAgency";
			this.txt_codi.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
			this.txt_codi.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_codi.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_codi.Location = new System.Drawing.Point(102, 39);
			this.txt_codi.Name = "txt_codi";
			this.txt_codi.Size = new System.Drawing.Size(100, 20);
			this.txt_codi.TabIndex = 14;
			this.txt_codi.Tag = "";
			// 
			// frm_tableAgencies
			// 
			this._nomTaula = "Agencies";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 508);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_agency);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_codi);
			this.Name = "frm_tableAgencies";
			this.Text = "frm_tablaAgencies";
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

        private System.Windows.Forms.Label label2;
        private G8M_LibreriaControles.SWTextbox txt_agency;
        private System.Windows.Forms.Label label1;
        private G8M_LibreriaControles.SWTextbox txt_codi;
    }
}