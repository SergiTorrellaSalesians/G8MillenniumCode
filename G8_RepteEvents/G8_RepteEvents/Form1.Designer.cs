namespace G8_RepteEvents
{
    partial class FRM_esdeveniment
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
            this.LBL_usuari = new System.Windows.Forms.Label();
            this.LBL_departament = new System.Windows.Forms.Label();
            this.LBL_bestreta_setmanal = new System.Windows.Forms.Label();
            this.LBL_despesa_setmanal = new System.Windows.Forms.Label();
            this.LBL_total_liquidacio = new System.Windows.Forms.Label();
            this.TXB_codi = new System.Windows.Forms.TextBox();
            this.TXB_codiusuari = new System.Windows.Forms.TextBox();
            this.TBX_departament = new System.Windows.Forms.TextBox();
            this.TBX_bestreta = new System.Windows.Forms.TextBox();
            this.TBX_despesa = new System.Windows.Forms.TextBox();
            this.TBX_total = new System.Windows.Forms.TextBox();
            this.BTN_calcul_liquidacio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_usuari
            // 
            this.LBL_usuari.AutoSize = true;
            this.LBL_usuari.Location = new System.Drawing.Point(66, 64);
            this.LBL_usuari.Name = "LBL_usuari";
            this.LBL_usuari.Size = new System.Drawing.Size(37, 13);
            this.LBL_usuari.TabIndex = 0;
            this.LBL_usuari.Text = "Usuari";
            this.LBL_usuari.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_departament
            // 
            this.LBL_departament.AutoSize = true;
            this.LBL_departament.Location = new System.Drawing.Point(35, 93);
            this.LBL_departament.Name = "LBL_departament";
            this.LBL_departament.Size = new System.Drawing.Size(68, 13);
            this.LBL_departament.TabIndex = 1;
            this.LBL_departament.Text = "Departament";
            this.LBL_departament.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBL_bestreta_setmanal
            // 
            this.LBL_bestreta_setmanal.AutoSize = true;
            this.LBL_bestreta_setmanal.Location = new System.Drawing.Point(12, 134);
            this.LBL_bestreta_setmanal.Name = "LBL_bestreta_setmanal";
            this.LBL_bestreta_setmanal.Size = new System.Drawing.Size(91, 13);
            this.LBL_bestreta_setmanal.TabIndex = 2;
            this.LBL_bestreta_setmanal.Text = "Bestreta setmanal";
            this.LBL_bestreta_setmanal.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBL_despesa_setmanal
            // 
            this.LBL_despesa_setmanal.AutoSize = true;
            this.LBL_despesa_setmanal.Location = new System.Drawing.Point(9, 161);
            this.LBL_despesa_setmanal.Name = "LBL_despesa_setmanal";
            this.LBL_despesa_setmanal.Size = new System.Drawing.Size(94, 13);
            this.LBL_despesa_setmanal.TabIndex = 3;
            this.LBL_despesa_setmanal.Text = "Despesa setmanal";
            this.LBL_despesa_setmanal.Click += new System.EventHandler(this.label4_Click);
            // 
            // LBL_total_liquidacio
            // 
            this.LBL_total_liquidacio.AutoSize = true;
            this.LBL_total_liquidacio.Location = new System.Drawing.Point(21, 190);
            this.LBL_total_liquidacio.Name = "LBL_total_liquidacio";
            this.LBL_total_liquidacio.Size = new System.Drawing.Size(82, 13);
            this.LBL_total_liquidacio.TabIndex = 4;
            this.LBL_total_liquidacio.Text = "Total Liquidació";
            // 
            // TXB_codi
            // 
            this.TXB_codi.Location = new System.Drawing.Point(109, 61);
            this.TXB_codi.Multiline = true;
            this.TXB_codi.Name = "TXB_codi";
            this.TXB_codi.Size = new System.Drawing.Size(70, 20);
            this.TXB_codi.TabIndex = 5;
            this.TXB_codi.TextChanged += new System.EventHandler(this.TXB_codi_TextChanged);
            this.TXB_codi.Leave += new System.EventHandler(this.TXB_codi_Leave_1);
            // 
            // TXB_codiusuari
            // 
            this.TXB_codiusuari.Location = new System.Drawing.Point(186, 61);
            this.TXB_codiusuari.Name = "TXB_codiusuari";
            this.TXB_codiusuari.Size = new System.Drawing.Size(100, 20);
            this.TXB_codiusuari.TabIndex = 6;
            // 
            // TBX_departament
            // 
            this.TBX_departament.Location = new System.Drawing.Point(109, 90);
            this.TBX_departament.Name = "TBX_departament";
            this.TBX_departament.Size = new System.Drawing.Size(177, 20);
            this.TBX_departament.TabIndex = 7;
            // 
            // TBX_bestreta
            // 
            this.TBX_bestreta.Location = new System.Drawing.Point(110, 131);
            this.TBX_bestreta.Name = "TBX_bestreta";
            this.TBX_bestreta.Size = new System.Drawing.Size(69, 20);
            this.TBX_bestreta.TabIndex = 8;
            // 
            // TBX_despesa
            // 
            this.TBX_despesa.Location = new System.Drawing.Point(110, 158);
            this.TBX_despesa.Name = "TBX_despesa";
            this.TBX_despesa.Size = new System.Drawing.Size(69, 20);
            this.TBX_despesa.TabIndex = 9;
            // 
            // TBX_total
            // 
            this.TBX_total.Location = new System.Drawing.Point(110, 190);
            this.TBX_total.Name = "TBX_total";
            this.TBX_total.ReadOnly = true;
            this.TBX_total.Size = new System.Drawing.Size(69, 20);
            this.TBX_total.TabIndex = 10;
            this.TBX_total.TextChanged += new System.EventHandler(this.TBX_total_TextChanged);
            // 
            // BTN_calcul_liquidacio
            // 
            this.BTN_calcul_liquidacio.Location = new System.Drawing.Point(186, 156);
            this.BTN_calcul_liquidacio.Name = "BTN_calcul_liquidacio";
            this.BTN_calcul_liquidacio.Size = new System.Drawing.Size(100, 23);
            this.BTN_calcul_liquidacio.TabIndex = 11;
            this.BTN_calcul_liquidacio.Text = "Calcular liquidació";
            this.BTN_calcul_liquidacio.UseVisualStyleBackColor = true;
            this.BTN_calcul_liquidacio.Click += new System.EventHandler(this.BTN_calcul_liquidacio_Click);
            // 
            // FRM_esdeveniment
            // 
            this.ClientSize = new System.Drawing.Size(334, 252);
            this.Controls.Add(this.BTN_calcul_liquidacio);
            this.Controls.Add(this.TBX_total);
            this.Controls.Add(this.TBX_despesa);
            this.Controls.Add(this.TBX_bestreta);
            this.Controls.Add(this.TBX_departament);
            this.Controls.Add(this.TXB_codiusuari);
            this.Controls.Add(this.TXB_codi);
            this.Controls.Add(this.LBL_total_liquidacio);
            this.Controls.Add(this.LBL_despesa_setmanal);
            this.Controls.Add(this.LBL_bestreta_setmanal);
            this.Controls.Add(this.LBL_departament);
            this.Controls.Add(this.LBL_usuari);
            this.Name = "FRM_esdeveniment";
            this.Text = "Esdeveniments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_dept;
        private System.Windows.Forms.Label LBL_bestretasetmanal;
        private System.Windows.Forms.Label LBL_despesasetmanal;
        private System.Windows.Forms.Label LBL_usuari;
        private System.Windows.Forms.Label LBL_departament;
        private System.Windows.Forms.Label LBL_bestreta_setmanal;
        private System.Windows.Forms.Label LBL_despesa_setmanal;
        private System.Windows.Forms.Label LBL_total_liquidacio;
        private System.Windows.Forms.TextBox TXB_codi;
        private System.Windows.Forms.TextBox TXB_codiusuari;
        private System.Windows.Forms.TextBox TBX_departament;
        private System.Windows.Forms.TextBox TBX_bestreta;
        private System.Windows.Forms.TextBox TBX_despesa;
        private System.Windows.Forms.TextBox TBX_total;
        private System.Windows.Forms.Button BTN_calcul_liquidacio;
    }
}

