namespace WindowsFormsApp1
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.versionado = new System.Windows.Forms.Label();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // versionado
            // 
            this.versionado.AutoSize = true;
            this.versionado.ForeColor = System.Drawing.Color.Navy;
            this.versionado.Location = new System.Drawing.Point(393, 25);
            this.versionado.Name = "versionado";
            this.versionado.Size = new System.Drawing.Size(41, 13);
            this.versionado.TabIndex = 0;
            this.versionado.Text = "V 1.0.0";
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Interval = 3000;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.splash_screen3_pequeño;
            this.ClientSize = new System.Drawing.Size(456, 187);
            this.Controls.Add(this.versionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.splashScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splashScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splashScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splashScreen_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionado;
        private System.Windows.Forms.Timer timerSplashScreen;
    }
}