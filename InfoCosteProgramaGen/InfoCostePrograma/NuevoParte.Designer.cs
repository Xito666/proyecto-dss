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
            this.textboxresponsable = new System.Windows.Forms.TextBox();
            this.textboxequipo = new System.Windows.Forms.TextBox();
            this.textboxdescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxcliente
            // 
            this.textboxcliente.Location = new System.Drawing.Point(123, 34);
            this.textboxcliente.Name = "textboxcliente";
            this.textboxcliente.Size = new System.Drawing.Size(100, 20);
            this.textboxcliente.TabIndex = 0;
            // 
            // textboxresponsable
            // 
            this.textboxresponsable.Location = new System.Drawing.Point(123, 60);
            this.textboxresponsable.Name = "textboxresponsable";
            this.textboxresponsable.Size = new System.Drawing.Size(100, 20);
            this.textboxresponsable.TabIndex = 1;
            // 
            // textboxequipo
            // 
            this.textboxequipo.Location = new System.Drawing.Point(123, 86);
            this.textboxequipo.Name = "textboxequipo";
            this.textboxequipo.Size = new System.Drawing.Size(100, 20);
            this.textboxequipo.TabIndex = 2;
            // 
            // textboxdescripcion
            // 
            this.textboxdescripcion.Location = new System.Drawing.Point(123, 112);
            this.textboxdescripcion.Name = "textboxdescripcion";
            this.textboxdescripcion.Size = new System.Drawing.Size(100, 20);
            this.textboxdescripcion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Responsable:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 89);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id:";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(123, 8);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(100, 20);
            this.textboxid.TabIndex = 9;
            // 
            // NuevoParte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 228);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxdescripcion);
            this.Controls.Add(this.textboxequipo);
            this.Controls.Add(this.textboxresponsable);
            this.Controls.Add(this.textboxcliente);
            this.Name = "NuevoParte";
            this.Text = "Nuevo Parte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxcliente;
        private System.Windows.Forms.TextBox textboxresponsable;
        private System.Windows.Forms.TextBox textboxequipo;
        private System.Windows.Forms.TextBox textboxdescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxid;

    }
}