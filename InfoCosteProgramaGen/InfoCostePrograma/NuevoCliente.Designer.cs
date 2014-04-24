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
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.checkBox_Empresa = new System.Windows.Forms.CheckBox();
            this.textBox_NumCuenta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Location = new System.Drawing.Point(32, 223);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.button_CrearUsuario.TabIndex = 15;
            this.button_CrearUsuario.Text = "Crear";
            this.button_CrearUsuario.UseVisualStyleBackColor = true;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(131, 99);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(138, 20);
            this.textBox_Telefono.TabIndex = 14;
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(131, 72);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(138, 20);
            this.textBox_Direccion.TabIndex = 13;
            this.textBox_Direccion.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(131, 45);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(138, 20);
            this.textBox_Nombre.TabIndex = 12;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // label_Telefono
            // 
            this.label_Telefono.AutoSize = true;
            this.label_Telefono.Location = new System.Drawing.Point(61, 102);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(52, 13);
            this.label_Telefono.TabIndex = 11;
            this.label_Telefono.Text = "Teléfono:";
            this.label_Telefono.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Location = new System.Drawing.Point(58, 75);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(55, 13);
            this.label_Direccion.TabIndex = 10;
            this.label_Direccion.Text = "Dirección:";
            this.label_Direccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(66, 48);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(47, 13);
            this.label_Nombre.TabIndex = 9;
            this.label_Nombre.Text = "Nombre:";
            this.label_Nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(131, 125);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(138, 20);
            this.textBox_Email.TabIndex = 17;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(78, 128);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 16;
            this.label_Email.Text = "eMail:";
            // 
            // checkBox_Empresa
            // 
            this.checkBox_Empresa.AutoSize = true;
            this.checkBox_Empresa.Location = new System.Drawing.Point(131, 181);
            this.checkBox_Empresa.Name = "checkBox_Empresa";
            this.checkBox_Empresa.Size = new System.Drawing.Size(126, 17);
            this.checkBox_Empresa.TabIndex = 19;
            this.checkBox_Empresa.Text = "el cliente es Empresa";
            this.checkBox_Empresa.UseVisualStyleBackColor = true;
            this.checkBox_Empresa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_NumCuenta
            // 
            this.textBox_NumCuenta.Location = new System.Drawing.Point(131, 151);
            this.textBox_NumCuenta.Name = "textBox_NumCuenta";
            this.textBox_NumCuenta.Size = new System.Drawing.Size(138, 20);
            this.textBox_NumCuenta.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Numero de cuenta:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(131, 19);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(138, 20);
            this.textBox_ID.TabIndex = 24;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 283);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_NumCuenta);
            this.Controls.Add(this.checkBox_Empresa);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_CrearUsuario);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_Telefono);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_Nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.CheckBox checkBox_Empresa;
        private System.Windows.Forms.TextBox textBox_NumCuenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
    }
}