namespace G8M_FormValidacio
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.img_wrong = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmr_timerControl = new System.Windows.Forms.Timer(this.components);
            this.img_correct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_correct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // img_wrong
            // 
            this.img_wrong.Image = global::G8M_FormValidacio.Properties.Resources.cross;
            this.img_wrong.Location = new System.Drawing.Point(261, 87);
            this.img_wrong.Name = "img_wrong";
            this.img_wrong.Size = new System.Drawing.Size(50, 50);
            this.img_wrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_wrong.TabIndex = 1;
            this.img_wrong.TabStop = false;
            this.img_wrong.Visible = false;
            this.img_wrong.Validated += new System.EventHandler(this.pictureBox1_Validated);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 17);
            this.progressBar1.TabIndex = 2;
            // 
            // tmr_timerControl
            // 
            this.tmr_timerControl.Interval = 1000;
            this.tmr_timerControl.Tick += new System.EventHandler(this.tmr_timerControl_Tick);
            // 
            // img_correct
            // 
            this.img_correct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_correct.Image = ((System.Drawing.Image)(resources.GetObject("img_correct.Image")));
            this.img_correct.Location = new System.Drawing.Point(261, 87);
            this.img_correct.Name = "img_correct";
            this.img_correct.Size = new System.Drawing.Size(50, 50);
            this.img_correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_correct.TabIndex = 3;
            this.img_correct.TabStop = false;
            this.img_correct.Visible = false;
            this.img_correct.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 222);
            this.Controls.Add(this.img_correct);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.img_wrong);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.TopBar_Title = "Warning";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.img_wrong, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.img_correct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.img_wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_wrong;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmr_timerControl;
        private System.Windows.Forms.PictureBox img_correct;
    }
}
