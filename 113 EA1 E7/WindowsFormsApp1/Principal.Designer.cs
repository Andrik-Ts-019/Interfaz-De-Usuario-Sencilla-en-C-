namespace WindowsFormsApp1
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAlfabeto = new System.Windows.Forms.Label();
            this.CadenaVerificar = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.PictureBox();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonLimpiar = new System.Windows.Forms.PictureBox();
            this.imgCondicion1 = new System.Windows.Forms.PictureBox();
            this.imgCondicion2 = new System.Windows.Forms.PictureBox();
            this.imgCondicion3 = new System.Windows.Forms.PictureBox();
            this.imgCondicion5 = new System.Windows.Forms.PictureBox();
            this.imgCondicion4 = new System.Windows.Forms.PictureBox();
            this.tablaCondiciones = new System.Windows.Forms.PictureBox();
            this.labelCondicion1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(164, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // labelAlfabeto
            // 
            this.labelAlfabeto.AutoSize = true;
            this.labelAlfabeto.BackColor = System.Drawing.Color.Transparent;
            this.labelAlfabeto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlfabeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlfabeto.Location = new System.Drawing.Point(93, 159);
            this.labelAlfabeto.Name = "labelAlfabeto";
            this.labelAlfabeto.Size = new System.Drawing.Size(66, 19);
            this.labelAlfabeto.TabIndex = 3;
            this.labelAlfabeto.Text = "alfabeto";
            // 
            // CadenaVerificar
            // 
            this.CadenaVerificar.Location = new System.Drawing.Point(108, 232);
            this.CadenaVerificar.Name = "CadenaVerificar";
            this.CadenaVerificar.Size = new System.Drawing.Size(244, 20);
            this.CadenaVerificar.TabIndex = 4;
            this.CadenaVerificar.TextChanged += new System.EventHandler(this.boxText);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Cerrar2;
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Location = new System.Drawing.Point(677, 10);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(44, 32);
            this.botonSalir.TabIndex = 8;
            this.botonSalir.TabStop = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseLeave += new System.EventHandler(this.botonSalir_MouseLeave);
            this.botonSalir.MouseHover += new System.EventHandler(this.botonSalir_MouseHover);
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.botonMinimizar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Minimizar;
            this.botonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonMinimizar.Location = new System.Drawing.Point(614, 10);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(44, 11);
            this.botonMinimizar.TabIndex = 10;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            this.botonMinimizar.MouseLeave += new System.EventHandler(this.botonMinimizar_MouseLeave);
            this.botonMinimizar.MouseHover += new System.EventHandler(this.botonMinimizar_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonAccion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(358, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.botonLimpiar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonLimpiar;
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonLimpiar.Location = new System.Drawing.Point(152, 258);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(139, 40);
            this.botonLimpiar.TabIndex = 12;
            this.botonLimpiar.TabStop = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            this.botonLimpiar.MouseLeave += new System.EventHandler(this.botonLimpiar_MouseLeave);
            this.botonLimpiar.MouseHover += new System.EventHandler(this.botonLimpiar_MouseHover);
            // 
            // imgCondicion1
            // 
            this.imgCondicion1.BackColor = System.Drawing.Color.Transparent;
            this.imgCondicion1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.palomitaexpandida1;
            this.imgCondicion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCondicion1.Location = new System.Drawing.Point(429, 204);
            this.imgCondicion1.Name = "imgCondicion1";
            this.imgCondicion1.Size = new System.Drawing.Size(21, 21);
            this.imgCondicion1.TabIndex = 14;
            this.imgCondicion1.TabStop = false;
            // 
            // imgCondicion2
            // 
            this.imgCondicion2.BackColor = System.Drawing.Color.Transparent;
            this.imgCondicion2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.palomitaexpandida1;
            this.imgCondicion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCondicion2.Location = new System.Drawing.Point(429, 234);
            this.imgCondicion2.Name = "imgCondicion2";
            this.imgCondicion2.Size = new System.Drawing.Size(21, 21);
            this.imgCondicion2.TabIndex = 15;
            this.imgCondicion2.TabStop = false;
            // 
            // imgCondicion3
            // 
            this.imgCondicion3.BackColor = System.Drawing.Color.Transparent;
            this.imgCondicion3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.palomitaexpandida1;
            this.imgCondicion3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCondicion3.Location = new System.Drawing.Point(429, 263);
            this.imgCondicion3.Name = "imgCondicion3";
            this.imgCondicion3.Size = new System.Drawing.Size(21, 21);
            this.imgCondicion3.TabIndex = 16;
            this.imgCondicion3.TabStop = false;
            // 
            // imgCondicion5
            // 
            this.imgCondicion5.BackColor = System.Drawing.Color.Transparent;
            this.imgCondicion5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.palomitaexpandida1;
            this.imgCondicion5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCondicion5.Location = new System.Drawing.Point(429, 320);
            this.imgCondicion5.Name = "imgCondicion5";
            this.imgCondicion5.Size = new System.Drawing.Size(21, 21);
            this.imgCondicion5.TabIndex = 17;
            this.imgCondicion5.TabStop = false;
            // 
            // imgCondicion4
            // 
            this.imgCondicion4.BackColor = System.Drawing.Color.Transparent;
            this.imgCondicion4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.palomitaexpandida1;
            this.imgCondicion4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCondicion4.Location = new System.Drawing.Point(429, 292);
            this.imgCondicion4.Name = "imgCondicion4";
            this.imgCondicion4.Size = new System.Drawing.Size(21, 21);
            this.imgCondicion4.TabIndex = 18;
            this.imgCondicion4.TabStop = false;
            // 
            // tablaCondiciones
            // 
            this.tablaCondiciones.BackColor = System.Drawing.Color.Transparent;
            this.tablaCondiciones.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Tabla;
            this.tablaCondiciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablaCondiciones.Location = new System.Drawing.Point(420, 198);
            this.tablaCondiciones.Name = "tablaCondiciones";
            this.tablaCondiciones.Size = new System.Drawing.Size(238, 149);
            this.tablaCondiciones.TabIndex = 13;
            this.tablaCondiciones.TabStop = false;
            // 
            // labelCondicion1
            // 
            this.labelCondicion1.AutoSize = true;
            this.labelCondicion1.BackColor = System.Drawing.Color.Transparent;
            this.labelCondicion1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCondicion1.Location = new System.Drawing.Point(458, 202);
            this.labelCondicion1.Name = "labelCondicion1";
            this.labelCondicion1.Size = new System.Drawing.Size(156, 13);
            this.labelCondicion1.TabIndex = 19;
            this.labelCondicion1.Text = "Empieza con un número que se";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(459, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "encuentra en el alfabeto.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(459, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Letras y dígitos válidos en el alfabeto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(460, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Iniciales en forma consecutiva.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(459, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Termina con:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(461, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "sufijo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(460, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "No acepta puntos seguidos";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.principal_interfazusuario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 464);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCondicion1);
            this.Controls.Add(this.imgCondicion4);
            this.Controls.Add(this.imgCondicion5);
            this.Controls.Add(this.imgCondicion3);
            this.Controls.Add(this.imgCondicion2);
            this.Controls.Add(this.imgCondicion1);
            this.Controls.Add(this.tablaCondiciones);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.CadenaVerificar);
            this.Controls.Add(this.labelAlfabeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "113 EA1E7";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.principal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.principal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.principal_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.botonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCondicion4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAlfabeto;
        private System.Windows.Forms.TextBox CadenaVerificar;
        private System.Windows.Forms.PictureBox botonSalir;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox botonLimpiar;
        private System.Windows.Forms.PictureBox imgCondicion1;
        private System.Windows.Forms.PictureBox imgCondicion2;
        private System.Windows.Forms.PictureBox imgCondicion3;
        private System.Windows.Forms.PictureBox imgCondicion5;
        private System.Windows.Forms.PictureBox imgCondicion4;
        private System.Windows.Forms.PictureBox tablaCondiciones;
        private System.Windows.Forms.Label labelCondicion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

