
namespace G8M_TableUserCategories
{
    partial class frm_TableUserCategories
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
            this.swComboFK1 = new G8M_LibreriaControles.SWComboFK();
            this.swTextbox1 = new G8M_LibreriaControles.SWTextbox();
            this.swTextbox2 = new G8M_LibreriaControles.SWTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Access level:";
            // 
            // swComboFK1
            // 
            this.swComboFK1._Display_Member = "CodeCategory";
            this.swComboFK1._ForeignTable = "UserCategories";
            this.swComboFK1._TableBind = "idUserCategory";
            this.swComboFK1._Value_Member = "idUserCategory";
            this.swComboFK1.FormattingEnabled = true;
            this.swComboFK1.Location = new System.Drawing.Point(106, 70);
            this.swComboFK1.Name = "swComboFK1";
            this.swComboFK1.Size = new System.Drawing.Size(121, 21);
            this.swComboFK1.TabIndex = 21;
            // 
            // swTextbox1
            // 
            this.swTextbox1._TableBind = "DescCategory";
            this.swTextbox1.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox1.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox1.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox1.Location = new System.Drawing.Point(107, 37);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 22;
            // 
            // swTextbox2
            // 
            this.swTextbox2._TableBind = "AccessLevel";
            this.swTextbox2.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.swTextbox2.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.swTextbox2.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.swTextbox2.Location = new System.Drawing.Point(324, 37);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(100, 20);
            this.swTextbox2.TabIndex = 23;
            // 
            // frm_TableUserCategories
            // 
            this._nomTaula = "UserCategories";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swComboFK1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_TableUserCategories";
            this.Text = "frm_TableUserCategories";
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.swComboFK1, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private G8M_LibreriaControles.SWComboFK swComboFK1;
        private G8M_LibreriaControles.SWTextbox swTextbox1;
        private G8M_LibreriaControles.SWTextbox swTextbox2;
    }
}