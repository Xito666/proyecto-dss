﻿namespace InfoCostePrograma
{
    partial class Proveedor
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(129, 99);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(138, 20);
            this.textBox_Email.TabIndex = 41;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(76, 102);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 40;
            this.label_Email.Text = "eMail:";
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Location = new System.Drawing.Point(30, 202);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.button_CrearUsuario.TabIndex = 39;
            this.button_CrearUsuario.Text = "Modificar";
            this.button_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(129, 61);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(138, 20);
            this.textBox_Direccion.TabIndex = 38;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(129, 24);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(138, 20);
            this.textBox_Nombre.TabIndex = 37;
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Location = new System.Drawing.Point(56, 64);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(55, 13);
            this.label_Direccion.TabIndex = 36;
            this.label_Direccion.Text = "Dirección:";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(64, 27);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(47, 13);
            this.label_Nombre.TabIndex = 35;
            this.label_Nombre.Text = "Nombre:";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_CrearUsuario);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_Nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proveedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_Nombre;

    }
}