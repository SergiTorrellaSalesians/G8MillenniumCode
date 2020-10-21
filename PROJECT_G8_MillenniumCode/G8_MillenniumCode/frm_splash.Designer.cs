namespace G8_MillenniumCode
{
    partial class frm_splash
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
			this.components = new System.ComponentModel.Container();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.pbx_logo = new System.Windows.Forms.PictureBox();
			this.lbl_loading = new System.Windows.Forms.Label();
			this.tmr_timer_splash = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
			this.progressBar1.Location = new System.Drawing.Point(196, 301);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(395, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 0;
			// 
			// pbx_logo
			// 
			this.pbx_logo.BackColor = System.Drawing.Color.Transparent;
			this.pbx_logo.Image = global::G8_MillenniumCode.Properties.Resources.Reverse_LOGO;
			this.pbx_logo.Location = new System.Drawing.Point(245, 27);
			this.pbx_logo.Name = "pbx_logo";
			this.pbx_logo.Size = new System.Drawing.Size(298, 244);
			this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_logo.TabIndex = 1;
			this.pbx_logo.TabStop = false;
			// 
			// lbl_loading
			// 
			this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
			this.lbl_loading.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_loading.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_loading.Location = new System.Drawing.Point(245, 274);
			this.lbl_loading.Name = "lbl_loading";
			this.lbl_loading.Size = new System.Drawing.Size(298, 24);
			this.lbl_loading.TabIndex = 2;
			this.lbl_loading.Text = "Loading...";
			this.lbl_loading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tmr_timer_splash
			// 
			this.tmr_timer_splash.Interval = 1000;
			this.tmr_timer_splash.Tick += new System.EventHandler(this.tmr_timer_splash_Tick);
			// 
			// frm_splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
			this.BackgroundImage = global::G8_MillenniumCode.Properties.Resources.istockphoto_606667670_612x612;
			this.ClientSize = new System.Drawing.Size(800, 375);
			this.Controls.Add(this.lbl_loading);
			this.Controls.Add(this.pbx_logo);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "z";
			this.Load += new System.EventHandler(this.frm_splash_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Timer tmr_timer_splash;
    }
}