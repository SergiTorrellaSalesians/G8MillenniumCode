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
            this.swTextbox = new G8M_LibreriaControles.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox
            // 
            this.swTextbox._TableBind = "Planet";
            this.swTextbox.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox.Location = new System.Drawing.Point(291, 185);
            this.swTextbox.Name = "swTextbox";
            this.swTextbox.Size = new System.Drawing.Size(100, 22);
            this.swTextbox.TabIndex = 10;
            // 
            // frm_TablaPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 625);
            this.Controls.Add(this.swTextbox);
            this.Name = "frm_TablaPlanets";
            this.Text = "frm_TablaPlanets";
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.swTextbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private G8M_LibreriaControles.SWTextbox swTextbox;
    }
}