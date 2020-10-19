namespace G8M_FormBase
{
    partial class frm_Template
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
			this.topbar = new System.Windows.Forms.Panel();
			this.btn_topbarExit = new System.Windows.Forms.Button();
			this.btn_topbarMinimize = new System.Windows.Forms.Button();
			this.txt_topbarTitle = new System.Windows.Forms.Label();
			this.topbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// topbar
			// 
			this.topbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.topbar.Controls.Add(this.btn_topbarExit);
			this.topbar.Controls.Add(this.btn_topbarMinimize);
			this.topbar.Controls.Add(this.txt_topbarTitle);
			this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
			this.topbar.Location = new System.Drawing.Point(0, 0);
			this.topbar.Name = "topbar";
			this.topbar.Size = new System.Drawing.Size(336, 39);
			this.topbar.TabIndex = 0;
			this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
			this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
			this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
			// 
			// btn_topbarExit
			// 
			this.btn_topbarExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_topbarExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_topbarExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_topbarExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_topbarExit.ForeColor = System.Drawing.Color.White;
			this.btn_topbarExit.Location = new System.Drawing.Point(291, -4);
			this.btn_topbarExit.Name = "btn_topbarExit";
			this.btn_topbarExit.Size = new System.Drawing.Size(45, 45);
			this.btn_topbarExit.TabIndex = 0;
			this.btn_topbarExit.TabStop = false;
			this.btn_topbarExit.Text = "x";
			this.btn_topbarExit.UseVisualStyleBackColor = true;
			this.btn_topbarExit.Click += new System.EventHandler(this.btn_topbarExit_Click);
			// 
			// btn_topbarMinimize
			// 
			this.btn_topbarMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_topbarMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_topbarMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_topbarMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_topbarMinimize.ForeColor = System.Drawing.Color.White;
			this.btn_topbarMinimize.Location = new System.Drawing.Point(250, -4);
			this.btn_topbarMinimize.Name = "btn_topbarMinimize";
			this.btn_topbarMinimize.Size = new System.Drawing.Size(45, 48);
			this.btn_topbarMinimize.TabIndex = 0;
			this.btn_topbarMinimize.TabStop = false;
			this.btn_topbarMinimize.Text = "—";
			this.btn_topbarMinimize.UseVisualStyleBackColor = true;
			this.btn_topbarMinimize.Click += new System.EventHandler(this.btn_topbarMinimize_Click);
			// 
			// txt_topbarTitle
			// 
			this.txt_topbarTitle.AutoSize = true;
			this.txt_topbarTitle.Font = new System.Drawing.Font("SimSun-ExtB", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_topbarTitle.ForeColor = System.Drawing.Color.Yellow;
			this.txt_topbarTitle.Location = new System.Drawing.Point(10, 8);
			this.txt_topbarTitle.Name = "txt_topbarTitle";
			this.txt_topbarTitle.Size = new System.Drawing.Size(62, 24);
			this.txt_topbarTitle.TabIndex = 1;
			this.txt_topbarTitle.Text = "DEMO";
			// 
			// frm_Template
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::G8M_FormBase.Properties.Resources.istockphoto_606667670_612x612;
			this.ClientSize = new System.Drawing.Size(336, 252);
			this.ControlBox = false;
			this.Controls.Add(this.topbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_Template";
			this.Text = "frm_formbase";
			this.Load += new System.EventHandler(this.frm_Template_Load);
			this.topbar.ResumeLayout(false);
			this.topbar.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel topbar;
		private System.Windows.Forms.Label txt_topbarTitle;
		private System.Windows.Forms.Button btn_topbarMinimize;
		private System.Windows.Forms.Button btn_topbarExit;
	}
}