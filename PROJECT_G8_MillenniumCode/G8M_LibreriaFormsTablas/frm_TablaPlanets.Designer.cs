namespace G8M_LibreriaFormsTablas
{
    partial class frm_TablaPlanets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swTextbox1 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox2 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox3 = new G8M_LibreriaControles.SWTextbox();
            this.swComboFK1 = new G8M_LibreriaControles.SWComboFK();
            this.swComboFK2 = new G8M_LibreriaControles.SWComboFK();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(291, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filiation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(291, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Parsercs";
            // 
            // swTextbox1
            // 
            this.swTextbox1._TableBind = "CodePlanet";
            this.swTextbox1.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox1.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox1.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox1.Location = new System.Drawing.Point(73, 33);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 17;
            // 
            // swTextbox2
            // 
            this.swTextbox2._TableBind = "DescPlanet";
            this.swTextbox2.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox2.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox2.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox2.Location = new System.Drawing.Point(74, 60);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 18;
            // 
            // swTextbox3
            // 
            this.swTextbox3._TableBind = "parsecs";
            this.swTextbox3.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox3.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox3.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox3.Location = new System.Drawing.Point(346, 58);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(100, 20);
            this.swTextbox3.TabIndex = 19;
            // 
            // swComboFK1
            // 
            this.swComboFK1._Display_Member = "CodeSector";
            this.swComboFK1._ForeignTable = "Sectors";
            this.swComboFK1._TableBind = "idSector";
            this.swComboFK1._Value_Member = "idSector";
            this.swComboFK1.FormattingEnabled = true;
            this.swComboFK1.Location = new System.Drawing.Point(82, 88);
            this.swComboFK1.Name = "swComboFK1";
            this.swComboFK1.Size = new System.Drawing.Size(121, 21);
            this.swComboFK1.TabIndex = 20;
            // 
            // swComboFK2
            // 
            this.swComboFK2._Display_Member = "DescFiliations";
            this.swComboFK2._ForeignTable = "Filiations";
            this.swComboFK2._TableBind = "idFiliation";
            this.swComboFK2._Value_Member = "idFiliation";
            this.swComboFK2.FormattingEnabled = true;
            this.swComboFK2.Location = new System.Drawing.Point(343, 24);
            this.swComboFK2.Name = "swComboFK2";
            this.swComboFK2.Size = new System.Drawing.Size(121, 21);
            this.swComboFK2.TabIndex = 21;
            // 
            // frm_TablaPlanets
            // 
            this._nomTaula = "Planets";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.swComboFK2);
            this.Controls.Add(this.swComboFK1);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_TablaPlanets";
            this.Text = "frm_TablaPlanets";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.swComboFK1, 0);
            this.Controls.SetChildIndex(this.swComboFK2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private G8M_LibreriaControles.SWTextbox swTextbox1;
        private G8M_LibreriaControles.SWTextbox swTextbox2;
        private G8M_LibreriaControles.SWTextbox swTextbox3;
        private G8M_LibreriaControles.SWComboFK swComboFK1;
        private G8M_LibreriaControles.SWComboFK swComboFK2;
    }
}