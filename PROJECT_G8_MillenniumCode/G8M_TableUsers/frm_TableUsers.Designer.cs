
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_username = new G8M_LibreriaControles.SWTextbox();
            this.tbx_code = new G8M_LibreriaControles.SWTextbox();
            this.tbx_login = new G8M_LibreriaControles.SWTextbox();
            this.tbx_password = new G8M_LibreriaControles.SWTextbox();
            this.SuspendLayout();
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.Click += new System.EventHandler(this.btn_actualitzar_Click);
            // 
            // btn_value
            // 
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Login:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(238, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rank:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(241, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Planet:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(238, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Specie:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(445, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Photo:";
            // 
            // tbx_username
            // 
            this.tbx_username._TableBind = null;
            this.tbx_username.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_username.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_username.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_username.Location = new System.Drawing.Point(92, 18);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(100, 20);
            this.tbx_username.TabIndex = 33;
            this.tbx_username.Tag = "UserName";
            // 
            // tbx_code
            // 
            this.tbx_code._TableBind = null;
            this.tbx_code.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_code.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_code.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_code.Location = new System.Drawing.Point(69, 48);
            this.tbx_code.Name = "tbx_code";
            this.tbx_code.Size = new System.Drawing.Size(100, 20);
            this.tbx_code.TabIndex = 34;
            this.tbx_code.Tag = "CodeUser";
            // 
            // tbx_login
            // 
            this.tbx_login._TableBind = null;
            this.tbx_login.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_login.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_login.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_login.Location = new System.Drawing.Point(71, 79);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(100, 20);
            this.tbx_login.TabIndex = 35;
            this.tbx_login.Tag = "Login";
            // 
            // tbx_password
            // 
            this.tbx_password._TableBind = null;
            this.tbx_password.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_password.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_password.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_password.Location = new System.Drawing.Point(92, 110);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(100, 20);
            this.tbx_password.TabIndex = 36;
            this.tbx_password.Tag = "Password";
            // 
            // frm_tableUsers
            // 
            this._nomTaula = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 517);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_login);
            this.Controls.Add(this.tbx_code);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_tableUsers";
            this.Text = "frm_TableUsers";
            this.Load += new System.EventHandler(this.frm_tableUsers_Load);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_value, 0);
            this.Controls.SetChildIndex(this.richtxt_dataset, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbx_username, 0);
            this.Controls.SetChildIndex(this.tbx_code, 0);
            this.Controls.SetChildIndex(this.tbx_login, 0);
            this.Controls.SetChildIndex(this.tbx_password, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private G8M_LibreriaControles.SWComboFK swComboFK4;
        private G8M_LibreriaControles.SWComboFK swComboFK3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private G8M_LibreriaControles.SWTextbox tbx_username;
        private G8M_LibreriaControles.SWTextbox tbx_code;
        private G8M_LibreriaControles.SWTextbox tbx_login;
        private G8M_LibreriaControles.SWTextbox tbx_password;
    }
}