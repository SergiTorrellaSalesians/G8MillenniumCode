
namespace G8_RepteEntityFramework
{
    partial class frm_contactsystem
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
            this.dtg_contactsystem = new System.Windows.Forms.DataGridView();
            this.tbx_idsystem = new System.Windows.Forms.TextBox();
            this.tbx_description = new System.Windows.Forms.TextBox();
            this.tbx_idcontact = new System.Windows.Forms.TextBox();
            this.tbx_systemvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_newproduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_contactsystem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_contactsystem
            // 
            this.dtg_contactsystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_contactsystem.Location = new System.Drawing.Point(76, 185);
            this.dtg_contactsystem.Name = "dtg_contactsystem";
            this.dtg_contactsystem.Size = new System.Drawing.Size(586, 200);
            this.dtg_contactsystem.TabIndex = 0;
            // 
            // tbx_idsystem
            // 
            this.tbx_idsystem.Location = new System.Drawing.Point(144, 47);
            this.tbx_idsystem.Name = "tbx_idsystem";
            this.tbx_idsystem.Size = new System.Drawing.Size(100, 20);
            this.tbx_idsystem.TabIndex = 1;
            this.tbx_idsystem.Tag = "idSystem";
            // 
            // tbx_description
            // 
            this.tbx_description.Location = new System.Drawing.Point(369, 44);
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(100, 20);
            this.tbx_description.TabIndex = 2;
            this.tbx_description.Tag = "Description";
            // 
            // tbx_idcontact
            // 
            this.tbx_idcontact.Location = new System.Drawing.Point(144, 99);
            this.tbx_idcontact.Name = "tbx_idcontact";
            this.tbx_idcontact.Size = new System.Drawing.Size(100, 20);
            this.tbx_idcontact.TabIndex = 3;
            this.tbx_idcontact.Tag = "idContact";
            // 
            // tbx_systemvalue
            // 
            this.tbx_systemvalue.Location = new System.Drawing.Point(369, 99);
            this.tbx_systemvalue.Name = "tbx_systemvalue";
            this.tbx_systemvalue.Size = new System.Drawing.Size(100, 20);
            this.tbx_systemvalue.TabIndex = 4;
            this.tbx_systemvalue.Tag = "SystemValue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "idSystem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "idContact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SystemValue";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(587, 406);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_newproduct
            // 
            this.btn_newproduct.Location = new System.Drawing.Point(477, 406);
            this.btn_newproduct.Name = "btn_newproduct";
            this.btn_newproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_newproduct.TabIndex = 9;
            this.btn_newproduct.Text = "New product";
            this.btn_newproduct.UseVisualStyleBackColor = true;
            this.btn_newproduct.Click += new System.EventHandler(this.btn_newproduct_Click);
            // 
            // frm_contactsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_newproduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_systemvalue);
            this.Controls.Add(this.tbx_idcontact);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.tbx_idsystem);
            this.Controls.Add(this.dtg_contactsystem);
            this.Name = "frm_contactsystem";
            this.Text = "frm_contactsystem";
            this.Load += new System.EventHandler(this.frm_contactsystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_contactsystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_contactsystem;
        private System.Windows.Forms.TextBox tbx_idsystem;
        private System.Windows.Forms.TextBox tbx_description;
        private System.Windows.Forms.TextBox tbx_idcontact;
        private System.Windows.Forms.TextBox tbx_systemvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_newproduct;
    }
}