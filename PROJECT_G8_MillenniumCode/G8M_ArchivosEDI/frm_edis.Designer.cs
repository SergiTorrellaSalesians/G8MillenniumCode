
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(49, 59);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(75, 23);
            this.btn_selectfile.TabIndex = 0;
            this.btn_selectfile.Text = "Seleccionar";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // btn_uploadfile
            // 
            this.btn_uploadfile.Location = new System.Drawing.Point(49, 106);
            this.btn_uploadfile.Name = "btn_uploadfile";
            this.btn_uploadfile.Size = new System.Drawing.Size(75, 23);
            this.btn_uploadfile.TabIndex = 1;
            this.btn_uploadfile.Text = "Subir Archivo";
            this.btn_uploadfile.UseVisualStyleBackColor = true;
            this.btn_uploadfile.Click += new System.EventHandler(this.btn_uploadfile_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(49, 156);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 23);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "Descargar";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(158, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(495, 253);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // frm_edis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 292);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_uploadfile);
            this.Controls.Add(this.btn_selectfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_edis";
            this.Text = "frm_edis";
            this.Load += new System.EventHandler(this.frm_edis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.Button btn_uploadfile;
        private System.Windows.Forms.Button btn_download;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}