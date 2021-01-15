
namespace G8M_TablePlanets
{
    partial class frm_tablePlanets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tablePlanets));
            this.swComboFK2 = new G8M_LibreriaControles.SWComboFK();
            this.swComboFK1 = new G8M_LibreriaControles.SWComboFK();
            this.swTextbox3 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox2 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox1 = new G8M_LibreriaControles.SWTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.swTextbox4 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox5 = new G8M_LibreriaControles.SWTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.swComboFK3 = new G8M_LibreriaControles.SWComboFK();
            this.SuspendLayout();
            // 
            // richtxt_dataset
            // 
            this.richtxt_dataset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richtxt_dataset.Size = new System.Drawing.Size(824, 251);
            // 
            // swComboFK2
            // 
            this.swComboFK2._Display_Member = "DescFiliations";
            this.swComboFK2._ForeignTable = "Filiations";
            this.swComboFK2._TableBind = "idFiliation";
            this.swComboFK2._Value_Member = "idFiliation";
            this.swComboFK2.FormattingEnabled = true;
            this.swComboFK2.Location = new System.Drawing.Point(380, 32);
            this.swComboFK2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swComboFK2.Name = "swComboFK2";
            this.swComboFK2.Size = new System.Drawing.Size(160, 24);
            this.swComboFK2.TabIndex = 31;
            // 
            // swComboFK1
            // 
            this.swComboFK1._Display_Member = "CodeSector";
            this.swComboFK1._ForeignTable = "Sectors";
            this.swComboFK1._TableBind = "idSector";
            this.swComboFK1._Value_Member = "idSector";
            this.swComboFK1.FormattingEnabled = true;
            this.swComboFK1.Location = new System.Drawing.Point(107, 110);
            this.swComboFK1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swComboFK1.Name = "swComboFK1";
            this.swComboFK1.Size = new System.Drawing.Size(160, 24);
            this.swComboFK1.TabIndex = 30;
            // 
            // swTextbox3
            // 
            this.swTextbox3._TableBind = "parsecs";
            this.swTextbox3.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox3.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox3.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox3.Location = new System.Drawing.Point(647, 34);
            this.swTextbox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.Size = new System.Drawing.Size(132, 22);
            this.swTextbox3.TabIndex = 29;
            // 
            // swTextbox2
            // 
            this.swTextbox2._TableBind = "DescPlanet";
            this.swTextbox2.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox2.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox2.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox2.Location = new System.Drawing.Point(107, 76);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(132, 22);
            this.swTextbox2.TabIndex = 28;
            // 
            // swTextbox1
            // 
            this.swTextbox1._TableBind = "CodePlanet";
            this.swTextbox1.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox1.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox1.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox1.Location = new System.Drawing.Point(105, 43);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(132, 22);
            this.swTextbox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(571, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Parsercs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Filiation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Longitud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(571, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Latitud:";
            // 
            // swTextbox4
            // 
            this.swTextbox4._TableBind = "long";
            this.swTextbox4.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox4.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox4.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox4.Location = new System.Drawing.Point(647, 74);
            this.swTextbox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swTextbox4.Name = "swTextbox4";
            this.swTextbox4.Size = new System.Drawing.Size(132, 22);
            this.swTextbox4.TabIndex = 34;
            // 
            // swTextbox5
            // 
            this.swTextbox5._TableBind = "lat";
            this.swTextbox5.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox5.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox5.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox5.Location = new System.Drawing.Point(647, 111);
            this.swTextbox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swTextbox5.Name = "swTextbox5";
            this.swTextbox5.Size = new System.Drawing.Size(132, 22);
            this.swTextbox5.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(312, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Natives:";
            // 
            // swComboFK3
            // 
            this.swComboFK3._Display_Member = "DescSpecie";
            this.swComboFK3._ForeignTable = "Species";
            this.swComboFK3._TableBind = "idNatives";
            this.swComboFK3._Value_Member = "idSpecie";
            this.swComboFK3.FormattingEnabled = true;
            this.swComboFK3.Location = new System.Drawing.Point(381, 74);
            this.swComboFK3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.swComboFK3.Name = "swComboFK3";
            this.swComboFK3.Size = new System.Drawing.Size(160, 24);
            this.swComboFK3.TabIndex = 37;
            // 
            // frm_tablePlanets
            // 
            this._nomTaula = "Planets";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 672);
            this.Controls.Add(this.swComboFK3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.swTextbox5);
            this.Controls.Add(this.swTextbox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_tablePlanets";
            this.Text = "frm_TablaPLanets";
            this.Load += new System.EventHandler(this.frm_tablePlanets_Load);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.swComboFK1, 0);
            this.Controls.SetChildIndex(this.swComboFK2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.swTextbox4, 0);
            this.Controls.SetChildIndex(this.swTextbox5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.swComboFK3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private G8M_LibreriaControles.SWComboFK swComboFK2;
        private G8M_LibreriaControles.SWComboFK swComboFK1;
        private G8M_LibreriaControles.SWTextbox swTextbox3;
        private G8M_LibreriaControles.SWTextbox swTextbox2;
        private G8M_LibreriaControles.SWTextbox swTextbox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private G8M_LibreriaControles.SWTextbox swTextbox4;
        private G8M_LibreriaControles.SWTextbox swTextbox5;
        private System.Windows.Forms.Label label8;
        private G8M_LibreriaControles.SWComboFK swComboFK3;
    }
}