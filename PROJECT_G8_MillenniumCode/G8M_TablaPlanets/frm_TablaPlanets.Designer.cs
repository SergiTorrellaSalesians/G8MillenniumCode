
namespace G8M_TablaPlanets
{
    partial class frm_TablaPlanets
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
            this.swComboFK3 = new G8M_LibreriaControles.SWComboFK();
            this.swComboFK4 = new G8M_LibreriaControles.SWComboFK();
            this.swTextbox4 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox5 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox6 = new G8M_LibreriaControles.SWTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swComboFK3
            // 
            this.swComboFK3._Display_Member = "DescFiliations";
            this.swComboFK3._ForeignTable = "Filiations";
            this.swComboFK3._TableBind = "idFiliation";
            this.swComboFK3._Value_Member = "idFiliation";
            this.swComboFK3.FormattingEnabled = true;
            this.swComboFK3.Location = new System.Drawing.Point(357, 33);
            this.swComboFK3.Name = "swComboFK3";
            this.swComboFK3.Size = new System.Drawing.Size(121, 21);
            this.swComboFK3.TabIndex = 41;
            // 
            // swComboFK4
            // 
            this.swComboFK4._Display_Member = "CodeSector";
            this.swComboFK4._ForeignTable = "Sectors";
            this.swComboFK4._TableBind = "idSector";
            this.swComboFK4._Value_Member = "idSector";
            this.swComboFK4.FormattingEnabled = true;
            this.swComboFK4.Location = new System.Drawing.Point(96, 97);
            this.swComboFK4.Name = "swComboFK4";
            this.swComboFK4.Size = new System.Drawing.Size(121, 21);
            this.swComboFK4.TabIndex = 40;
            // 
            // swTextbox4
            // 
            this.swTextbox4._TableBind = "parsecs";
            this.swTextbox4.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox4.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox4.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox4.Location = new System.Drawing.Point(360, 67);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(100, 20);
            this.swTextbox4.TabIndex = 39;
            // 
            // swTextbox5
            // 
            this.swTextbox5._TableBind = "DescPlanet";
            this.swTextbox5.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox5.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox5.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox5.Location = new System.Drawing.Point(88, 69);
            this.swTextbox5.Name = "swTextbox5";
            this.swTextbox5.Size = new System.Drawing.Size(100, 20);
            this.swTextbox5.TabIndex = 38;
            // 
            // swTextbox6
            // 
            this.swTextbox6._TableBind = "CodePlanet";
            this.swTextbox6.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox6.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox6.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox6.Location = new System.Drawing.Point(87, 42);
            this.swTextbox6.Name = "swTextbox6";
            this.swTextbox6.Size = new System.Drawing.Size(100, 20);
            this.swTextbox6.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(305, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Parsercs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(305, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Filiation:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sector:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(49, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nom:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(49, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Codi:";
            // 
            // frm_TablaPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.swComboFK3);
            this.Controls.Add(this.swComboFK4);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.swTextbox5);
            this.Controls.Add(this.swTextbox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frm_TablaPlanets";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.swTextbox6, 0);
            this.Controls.SetChildIndex(this.swTextbox5, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.swComboFK4, 0);
            this.Controls.SetChildIndex(this.swComboFK3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private G8M_LibreriaControles.SWComboFK swComboFK3;
        private G8M_LibreriaControles.SWComboFK swComboFK4;
        private G8M_LibreriaControles.SWTextbox swTextbox4;
        private G8M_LibreriaControles.SWTextbox swTextbox5;
        private G8M_LibreriaControles.SWTextbox swTextbox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

