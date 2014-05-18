namespace InfoCostePrograma
{
    partial class NuevoParte
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
            this.textboxcliente = new System.Windows.Forms.TextBox();
            this.textboxequipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxdescripcion = new System.Windows.Forms.TextBox();
            this.buscarcliente = new System.Windows.Forms.Button();
            this.textboxresponsable2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textboxcliente
            // 
            this.textboxcliente.Location = new System.Drawing.Point(98, 33);
            this.textboxcliente.Name = "textboxcliente";
            this.textboxcliente.Size = new System.Drawing.Size(100, 20);
            this.textboxcliente.TabIndex = 0;
            // 
            // textboxequipo
            // 
            this.textboxequipo.Location = new System.Drawing.Point(98, 85);
            this.textboxequipo.Name = "textboxequipo";
            this.textboxequipo.Size = new System.Drawing.Size(100, 20);
            this.textboxequipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Responsable:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxdescripcion
            // 
            this.textboxdescripcion.Location = new System.Drawing.Point(12, 132);
            this.textboxdescripcion.Multiline = true;
            this.textboxdescripcion.Name = "textboxdescripcion";
            this.textboxdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxdescripcion.Size = new System.Drawing.Size(211, 59);
            this.textboxdescripcion.TabIndex = 3;
            // 
            // buscarcliente
            // 
            this.buscarcliente.Image = global::InfoCostePrograma.Properties.Resources.ico_buscar;
            this.buscarcliente.Location = new System.Drawing.Point(204, 33);
            this.buscarcliente.Name = "buscarcliente";
            this.buscarcliente.Size = new System.Drawing.Size(28, 20);
            this.buscarcliente.TabIndex = 9;
            this.buscarcliente.UseVisualStyleBackColor = true;
            this.buscarcliente.Click += new System.EventHandler(this.buscarcliente_Click);
            // 
            // textboxresponsable2
            // 
            this.textboxresponsable2.FormattingEnabled = true;
            this.textboxresponsable2.Location = new System.Drawing.Point(98, 60);
            this.textboxresponsable2.Name = "textboxresponsable2";
            this.textboxresponsable2.Size = new System.Drawing.Size(100, 21);
            this.textboxresponsable2.TabIndex = 10;
            // 
            // NuevoParte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 228);
            this.Controls.Add(this.textboxresponsable2);
            this.Controls.Add(this.buscarcliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxdescripcion);
            this.Controls.Add(this.textboxequipo);
            this.Controls.Add(this.textboxcliente);
            this.Name = "NuevoParte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Parte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxcliente;
        private System.Windows.Forms.TextBox textboxequipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxdescripcion;
        private System.Windows.Forms.Button buscarcliente;
        private System.Windows.Forms.ComboBox textboxresponsable2;

    }
}