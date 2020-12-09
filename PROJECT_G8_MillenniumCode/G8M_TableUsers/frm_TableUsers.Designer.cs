
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
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(248, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
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
			this.cbx_rank.Location = new System.Drawing.Point(290, 40);
			this.cbx_rank.Name = "cbx_rank";
			this.cbx_rank.Size = new System.Drawing.Size(121, 21);
			this.cbx_rank.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(45, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Password:";
			// 
			// txt_password
			// 
			this.txt_password._TableBind = "Password";
			this.txt_password.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
			this.txt_password.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_password.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_password.Location = new System.Drawing.Point(107, 67);
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(100, 20);
			this.txt_password.TabIndex = 18;
			this.txt_password.Tag = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(43, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Username:";
			// 
			// txt_username
			// 
			this.txt_username._TableBind = "UserName";
			this.txt_username.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
			this.txt_username.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
			this.txt_username.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
			this.txt_username.Location = new System.Drawing.Point(107, 41);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(100, 20);
			this.txt_username.TabIndex = 16;
			this.txt_username.Tag = "";
			// 
			// frm_tableUsers
			// 
			this._nomTaula = "Users";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 517);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbx_rank);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_username);
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
    }
}