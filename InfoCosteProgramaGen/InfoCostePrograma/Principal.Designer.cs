namespace InfoCostePrograma
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_IdentificadoComo = new System.Windows.Forms.Label();
            this.label_Identificado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva Venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_IdentificadoComo
            // 
            this.label_IdentificadoComo.AutoSize = true;
            this.label_IdentificadoComo.BackColor = System.Drawing.Color.Transparent;
            this.label_IdentificadoComo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_IdentificadoComo.Location = new System.Drawing.Point(25, 21);
            this.label_IdentificadoComo.Name = "label_IdentificadoComo";
            this.label_IdentificadoComo.Size = new System.Drawing.Size(49, 13);
            this.label_IdentificadoComo.TabIndex = 2;
            this.label_IdentificadoComo.Text = "Usuario: ";
            // 
            // label_Identificado
            // 
            this.label_Identificado.AutoSize = true;
            this.label_Identificado.BackColor = System.Drawing.Color.Transparent;
            this.label_Identificado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Identificado.Location = new System.Drawing.Point(80, 21);
            this.label_Identificado.Name = "label_Identificado";
            this.label_Identificado.Size = new System.Drawing.Size(84, 13);
            this.label_Identificado.TabIndex = 3;
            this.label_Identificado.Text = "Ragnar Lodbrok";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::InfoCostePrograma.Properties.Resources.principal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 157);
            this.panel1.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Image = global::InfoCostePrograma.Properties.Resources.cliente1;
            this.button6.Location = new System.Drawing.Point(19, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 105);
            this.button6.TabIndex = 8;
            this.button6.Text = "Trabajadores";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Image = global::InfoCostePrograma.Properties.Resources.Herramientas;
            this.button3.Location = new System.Drawing.Point(673, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 105);
            this.button3.TabIndex = 5;
            this.button3.Text = "Herramientas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::InfoCostePrograma.Properties.Resources.Ventas1;
            this.button5.Location = new System.Drawing.Point(455, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 105);
            this.button5.TabIndex = 7;
            this.button5.Text = "Ventas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::InfoCostePrograma.Properties.Resources.Productos;
            this.button8.Location = new System.Drawing.Point(346, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 105);
            this.button8.TabIndex = 10;
            this.button8.Text = "Productos";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::InfoCostePrograma.Properties.Resources.Trabajadores;
            this.button7.Location = new System.Drawing.Point(128, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 105);
            this.button7.TabIndex = 9;
            this.button7.Text = "Clientes";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Image = global::InfoCostePrograma.Properties.Resources.Compras1;
            this.button2.Location = new System.Drawing.Point(564, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 105);
            this.button2.TabIndex = 4;
            this.button2.Text = "Compras";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::InfoCostePrograma.Properties.Resources.Proveedores;
            this.button4.Location = new System.Drawing.Point(237, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 105);
            this.button4.TabIndex = 6;
            this.button4.Text = "Proveedores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 357);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::InfoCostePrograma.Properties.Resources.principal;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label_IdentificadoComo);
            this.panel3.Controls.Add(this.label_Identificado);
            this.panel3.Location = new System.Drawing.Point(0, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 51);
            this.panel3.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoCoste Dashboard";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_IdentificadoComo;
        private System.Windows.Forms.Label label_Identificado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

