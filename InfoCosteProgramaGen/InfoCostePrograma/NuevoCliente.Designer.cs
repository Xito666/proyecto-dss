namespace InfoCostePrograma
{
    partial class NuevoCliente
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
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Location = new System.Drawing.Point(119, 186);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.button_CrearUsuario.TabIndex = 15;
            this.button_CrearUsuario.Text = "Crear";
            this.button_CrearUsuario.UseVisualStyleBackColor = true;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(119, 110);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 14;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(119, 83);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 13;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(119, 56);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 12;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // label_Telefono
            // 
            this.label_Telefono.AutoSize = true;
            this.label_Telefono.Location = new System.Drawing.Point(15, 113);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(52, 13);
            this.label_Telefono.TabIndex = 11;
            this.label_Telefono.Text = "Teléfono:";
            this.label_Telefono.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Location = new System.Drawing.Point(15, 86);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(55, 13);
            this.label_Direccion.TabIndex = 10;
            this.label_Direccion.Text = "Dirección:";
            this.label_Direccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insertar Nuevo Cliente ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(15, 59);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(47, 13);
            this.label_Nombre.TabIndex = 9;
            this.label_Nombre.Text = "Nombre:";
            this.label_Nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(15, 139);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 16;
            this.label_Email.Text = "eMail:";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_CrearUsuario);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Telefono);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Email;
    }
}