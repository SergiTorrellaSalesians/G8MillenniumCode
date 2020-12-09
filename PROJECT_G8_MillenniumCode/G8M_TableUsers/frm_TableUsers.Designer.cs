
namespace G8M_TableUsers
{
    partial class frm_tableUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_rank = new G8M_LibreriaControles.SWComboFK();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new G8M_LibreriaControles.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new G8M_LibreriaControles.SWTextbox();
            this.swComboFK4 = new G8M_LibreriaControles.SWComboFK();
            this.swComboFK3 = new G8M_LibreriaControles.SWComboFK();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richtxt_dataset
            // 
            this.richtxt_dataset.Margin = new System.Windows.Forms.Padding(5);
            this.richtxt_dataset.Size = new System.Drawing.Size(824, 251);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rank:";
            // 
            // cbx_rank
            // 
            this.cbx_rank._Display_Member = "DescRank";
            this.cbx_rank._ForeignTable = "UserRanks";
            this.cbx_rank._TableBind = "idUserRank";
            this.cbx_rank._Value_Member = "idUserRank";
            this.cbx_rank.FormattingEnabled = true;
            this.cbx_rank.Location = new System.Drawing.Point(387, 49);
            this.cbx_rank.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_rank.Name = "cbx_rank";
            this.cbx_rank.Size = new System.Drawing.Size(160, 24);
            this.cbx_rank.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password._TableBind = "Password";
            this.txt_password.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.txt_password.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.txt_password.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.txt_password.Location = new System.Drawing.Point(143, 82);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(132, 22);
            this.txt_password.TabIndex = 18;
            this.txt_password.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username._TableBind = "UserName";
            this.txt_username.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.txt_username.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.txt_username.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.txt_username.Location = new System.Drawing.Point(143, 50);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(132, 22);
            this.txt_username.TabIndex = 16;
            this.txt_username.Tag = "";
            // 
            // swComboFK4
            // 
            this.swComboFK4._Display_Member = "DescSpecie";
            this.swComboFK4._ForeignTable = "Species";
            this.swComboFK4._TableBind = "idSpecie";
            this.swComboFK4._Value_Member = "idSpecie";
            this.swComboFK4.FormattingEnabled = true;
            this.swComboFK4.Location = new System.Drawing.Point(644, 77);
            this.swComboFK4.Name = "swComboFK4";
            this.swComboFK4.Size = new System.Drawing.Size(139, 24);
            this.swComboFK4.TabIndex = 33;
            // 
            // swComboFK3
            // 
            this.swComboFK3._Display_Member = "DescPlanet";
            this.swComboFK3._ForeignTable = "Planets";
            this.swComboFK3._TableBind = "idPlanet";
            this.swComboFK3._Value_Member = "idPlanet";
            this.swComboFK3.FormattingEnabled = true;
            this.swComboFK3.Location = new System.Drawing.Point(644, 46);
            this.swComboFK3.Name = "swComboFK3";
            this.swComboFK3.Size = new System.Drawing.Size(139, 24);
            this.swComboFK3.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(567, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "idPlanets:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(567, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "idSpecies:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frm_tableUsers
            // 
            this._nomTaula = "Users";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 672);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.swComboFK4);
            this.Controls.Add(this.swComboFK3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_rank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_tableUsers";
            this.Text = "frm_TableUsers";
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.txt_username, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbx_rank, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.swComboFK3, 0);
            this.Controls.SetChildIndex(this.swComboFK4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private G8M_LibreriaControles.SWComboFK cbx_rank;
        private System.Windows.Forms.Label label2;
        private G8M_LibreriaControles.SWTextbox txt_password;
        private System.Windows.Forms.Label label1;
        private G8M_LibreriaControles.SWTextbox txt_username;
        private G8M_LibreriaControles.SWComboFK swComboFK4;
        private G8M_LibreriaControles.SWComboFK swComboFK3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}