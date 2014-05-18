namespace InfoCostePrograma
{
    partial class Login
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
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Pass = new System.Windows.Forms.Label();
            this.label_Errores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.boton_Login = new System.Windows.Forms.Button();
            this.boton_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::InfoCostePrograma.Properties.Resources.logo2;
            this.pictureBox_Logo.Location = new System.Drawing.Point(44, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(265, 166);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_Nombre.ForeColor = System.Drawing.Color.White;
            this.label_Nombre.Location = new System.Drawing.Point(63, 208);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(46, 13);
            this.label_Nombre.TabIndex = 5;
            this.label_Nombre.Text = "Usuario:";
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.BackColor = System.Drawing.Color.Transparent;
            this.label_Pass.ForeColor = System.Drawing.Color.White;
            this.label_Pass.Location = new System.Drawing.Point(45, 242);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(64, 13);
            this.label_Pass.TabIndex = 6;
            this.label_Pass.Text = "Contraseña:";
            // 
            // label_Errores
            // 
            this.label_Errores.AutoSize = true;
            this.label_Errores.BackColor = System.Drawing.Color.Transparent;
            this.label_Errores.Location = new System.Drawing.Point(12, 312);
            this.label_Errores.Name = "label_Errores";
            this.label_Errores.Size = new System.Drawing.Size(35, 13);
            this.label_Errores.TabIndex = 7;
            this.label_Errores.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.boton_Login);
            this.panel1.Controls.Add(this.textBox_Pass);
            this.panel1.Controls.Add(this.textBox_Nombre);
            this.panel1.Controls.Add(this.pictureBox_Logo);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 307);
            this.panel1.TabIndex = 8;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(132, 176);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(155, 20);
            this.textBox_Nombre.TabIndex = 1;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(132, 210);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(155, 20);
            this.textBox_Pass.TabIndex = 2;
            // 
            // boton_Login
            // 
            this.boton_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_Login.ForeColor = System.Drawing.Color.White;
            this.boton_Login.Location = new System.Drawing.Point(65, 254);
            this.boton_Login.Name = "boton_Login";
            this.boton_Login.Size = new System.Drawing.Size(222, 23);
            this.boton_Login.TabIndex = 3;
            this.boton_Login.Text = "Acceder";
            this.boton_Login.UseVisualStyleBackColor = true;
            this.boton_Login.Click += new System.EventHandler(this.boton_Login_Click);
            // 
            // boton_Cerrar
            // 
            this.boton_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.boton_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_Cerrar.ForeColor = System.Drawing.Color.White;
            this.boton_Cerrar.Location = new System.Drawing.Point(328, 5);
            this.boton_Cerrar.Name = "boton_Cerrar";
            this.boton_Cerrar.Size = new System.Drawing.Size(20, 20);
            this.boton_Cerrar.TabIndex = 9;
            this.boton_Cerrar.Text = "X";
            this.boton_Cerrar.UseVisualStyleBackColor = false;
            this.boton_Cerrar.Click += new System.EventHandler(this.boton_Cerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::InfoCostePrograma.Properties.Resources.principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 337);
            this.Controls.Add(this.boton_Cerrar);
            this.Controls.Add(this.label_Errores);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.Label label_Errores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button boton_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button boton_Cerrar;
    }
}