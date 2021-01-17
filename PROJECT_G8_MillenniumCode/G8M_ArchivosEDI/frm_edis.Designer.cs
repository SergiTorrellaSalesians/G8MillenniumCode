
namespace G8M_ArchivosEDI
{
    partial class frm_edis
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
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.btn_uploadfile = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_crystalreports = new System.Windows.Forms.Button();
            this.btn_showcrystalreports = new System.Windows.Forms.Button();
            this.tbx_codeOrders = new G8M_LibreriaControles.SWTextbox();
            this.lbl_codeORder = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EDI_to_crystalreports1 = new G8M_ArchivosEDI.EDI_to_crystalreports();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(12, 50);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(75, 23);
            this.btn_selectfile.TabIndex = 0;
            this.btn_selectfile.Text = "Seleccionar";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // btn_uploadfile
            // 
            this.btn_uploadfile.Location = new System.Drawing.Point(12, 79);
            this.btn_uploadfile.Name = "btn_uploadfile";
            this.btn_uploadfile.Size = new System.Drawing.Size(75, 23);
            this.btn_uploadfile.TabIndex = 1;
            this.btn_uploadfile.Text = "Subir Archivo";
            this.btn_uploadfile.UseVisualStyleBackColor = true;
            this.btn_uploadfile.Click += new System.EventHandler(this.btn_uploadfile_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(12, 108);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 23);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Descargar";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_crystalreports
            // 
            this.btn_crystalreports.Location = new System.Drawing.Point(12, 138);
            this.btn_crystalreports.Name = "btn_crystalreports";
            this.btn_crystalreports.Size = new System.Drawing.Size(75, 23);
            this.btn_crystalreports.TabIndex = 4;
            this.btn_crystalreports.Text = "Crear Reporte";
            this.btn_crystalreports.UseVisualStyleBackColor = true;
            this.btn_crystalreports.Click += new System.EventHandler(this.btn_crystalreports_Click);
            // 
            // btn_showcrystalreports
            // 
            this.btn_showcrystalreports.Location = new System.Drawing.Point(15, 234);
            this.btn_showcrystalreports.Name = "btn_showcrystalreports";
            this.btn_showcrystalreports.Size = new System.Drawing.Size(75, 23);
            this.btn_showcrystalreports.TabIndex = 5;
            this.btn_showcrystalreports.Text = "Mostrar";
            this.btn_showcrystalreports.UseVisualStyleBackColor = true;
            this.btn_showcrystalreports.Click += new System.EventHandler(this.btn_showcrystalreports_Click);
            // 
            // tbx_codeOrders
            // 
            this.tbx_codeOrders._TableBind = null;
            this.tbx_codeOrders.AllowEmptyField = G8M_LibreriaControles.SWTextbox.EmptyField.WithText;
            this.tbx_codeOrders.AllowEmptyText = G8M_LibreriaControles.SWTextbox.EmptyTextbox.Empty;
            this.tbx_codeOrders.InputTextType = G8M_LibreriaControles.SWTextbox.InputType.Text;
            this.tbx_codeOrders.Location = new System.Drawing.Point(15, 199);
            this.tbx_codeOrders.Name = "tbx_codeOrders";
            this.tbx_codeOrders.Size = new System.Drawing.Size(100, 20);
            this.tbx_codeOrders.TabIndex = 7;
            this.tbx_codeOrders.Text = "061243444000";
            // 
            // lbl_codeORder
            // 
            this.lbl_codeORder.AutoSize = true;
            this.lbl_codeORder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codeORder.ForeColor = System.Drawing.Color.White;
            this.lbl_codeORder.Location = new System.Drawing.Point(12, 174);
            this.lbl_codeORder.Name = "lbl_codeORder";
            this.lbl_codeORder.Size = new System.Drawing.Size(36, 13);
            this.lbl_codeORder.TabIndex = 25;
            this.lbl_codeORder.Text = "Order:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.EDI_to_crystalreports1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(725, 404);
            this.crystalReportViewer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(121, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 404);
            this.panel1.TabIndex = 26;
            // 
            // frm_edis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::G8M_ArchivosEDI.Properties.Resources.istockphoto_606667670_612x612;
            this.ClientSize = new System.Drawing.Size(858, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_codeORder);
            this.Controls.Add(this.tbx_codeOrders);
            this.Controls.Add(this.btn_showcrystalreports);
            this.Controls.Add(this.btn_crystalreports);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_uploadfile);
            this.Controls.Add(this.btn_selectfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_edis";
            this.Text = "frm_edis";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.Button btn_uploadfile;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_crystalreports;
        private System.Windows.Forms.Button btn_showcrystalreports;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private G8M_LibreriaControles.SWTextbox tbx_codeOrders;
        private EDI_to_crystalreports EDI_to_crystalreports1;
        private System.Windows.Forms.Label lbl_codeORder;
        private System.Windows.Forms.Panel panel1;
    }
}