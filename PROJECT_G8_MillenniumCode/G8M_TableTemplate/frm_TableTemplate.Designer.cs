namespace G8M_TableTemplate
{
    partial class frm_TableTemplate
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
            this.richtxt_dataset = new System.Windows.Forms.RichTextBox();
            this.dgv_BBDDdata = new System.Windows.Forms.DataGridView();
            this.btn_value = new System.Windows.Forms.Button();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.lbl_codi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BBDDdata)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxt_dataset
            // 
            this.richtxt_dataset.Location = new System.Drawing.Point(29, 352);
            this.richtxt_dataset.Margin = new System.Windows.Forms.Padding(4);
            this.richtxt_dataset.Name = "richtxt_dataset";
            this.richtxt_dataset.Size = new System.Drawing.Size(741, 205);
            this.richtxt_dataset.TabIndex = 13;
            this.richtxt_dataset.Text = "";
            // 
            // dgv_BBDDdata
            // 
            this.dgv_BBDDdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BBDDdata.Location = new System.Drawing.Point(29, 101);
            this.dgv_BBDDdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BBDDdata.Name = "dgv_BBDDdata";
            this.dgv_BBDDdata.RowHeadersWidth = 51;
            this.dgv_BBDDdata.Size = new System.Drawing.Size(743, 185);
            this.dgv_BBDDdata.TabIndex = 12;
            // 
            // btn_value
            // 
            this.btn_value.Location = new System.Drawing.Point(629, 293);
            this.btn_value.Margin = new System.Windows.Forms.Padding(4);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(143, 28);
            this.btn_value.TabIndex = 11;
            this.btn_value.Text = "Value DataSet";
            this.btn_value.UseVisualStyleBackColor = true;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.Location = new System.Drawing.Point(478, 293);
            this.btn_actualitzar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(143, 28);
            this.btn_actualitzar.TabIndex = 10;
            this.btn_actualitzar.Text = "Actualitzar";
            this.btn_actualitzar.UseVisualStyleBackColor = true;
            // 
            // lbl_codi
            // 
            this.lbl_codi.AutoSize = true;
            this.lbl_codi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codi.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codi.ForeColor = System.Drawing.Color.White;
            this.lbl_codi.Location = new System.Drawing.Point(61, -56);
            this.lbl_codi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codi.Name = "lbl_codi";
            this.lbl_codi.Size = new System.Drawing.Size(64, 20);
            this.lbl_codi.TabIndex = 8;
            this.lbl_codi.Text = "Codi:";
            // 
            // frm_TableTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 570);
            this.Controls.Add(this.richtxt_dataset);
            this.Controls.Add(this.dgv_BBDDdata);
            this.Controls.Add(this.btn_value);
            this.Controls.Add(this.btn_actualitzar);
            this.Controls.Add(this.lbl_codi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TableTemplate";
            this.Text = "frm_TableTemplate";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BBDDdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxt_dataset;
        private System.Windows.Forms.DataGridView dgv_BBDDdata;
        private System.Windows.Forms.Button btn_value;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Label lbl_codi;
    }
}