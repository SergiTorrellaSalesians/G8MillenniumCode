
namespace G8M_TablaSpecies
{
    partial class frm_TablaSpecies
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
            this.tbx_desSpecie = new G8M_LibreriaControles.SWTextbox();
            this.tbx_codispecie = new G8M_LibreriaControles.SWTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_desSpecie
            // 
            this.tbx_desSpecie._TableBind = "DescSpecie";
            this.tbx_desSpecie.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_desSpecie.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_desSpecie.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_desSpecie.Location = new System.Drawing.Point(118, 71);
            this.tbx_desSpecie.Name = "tbx_desSpecie";
            this.tbx_desSpecie.Size = new System.Drawing.Size(100, 20);
            this.tbx_desSpecie.TabIndex = 19;
            // 
            // tbx_codispecie
            // 
            this.tbx_codispecie._TableBind = "CodeSpecie";
            this.tbx_codispecie.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_codispecie.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_codispecie.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_codispecie.Location = new System.Drawing.Point(118, 41);
            this.tbx_codispecie.Name = "tbx_codispecie";
            this.tbx_codispecie.Size = new System.Drawing.Size(100, 20);
            this.tbx_codispecie.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Species:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codi:";
            // 
            // frm_TablaSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.tbx_desSpecie);
            this.Controls.Add(this.tbx_codispecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_TablaSpecies";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbx_codispecie, 0);
            this.Controls.SetChildIndex(this.tbx_desSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private G8M_LibreriaControles.SWTextbox tbx_desSpecie;
        private G8M_LibreriaControles.SWTextbox tbx_codispecie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

