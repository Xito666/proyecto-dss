namespace InfoCostePrograma
{
    partial class GestionarTrabajadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_GestionarTrabajadores = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionarTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Trabajadores";
            // 
            // dataGridView_GestionarTrabajadores
            // 
            this.dataGridView_GestionarTrabajadores.AllowUserToAddRows = false;
            this.dataGridView_GestionarTrabajadores.AllowUserToDeleteRows = false;
            this.dataGridView_GestionarTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GestionarTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Contrasenya,
            this.Nombre,
            this.Eliminar,
            this.Editar});
            this.dataGridView_GestionarTrabajadores.Location = new System.Drawing.Point(12, 45);
            this.dataGridView_GestionarTrabajadores.Name = "dataGridView_GestionarTrabajadores";
            this.dataGridView_GestionarTrabajadores.ReadOnly = true;
            this.dataGridView_GestionarTrabajadores.RowHeadersWidth = 20;
            this.dataGridView_GestionarTrabajadores.Size = new System.Drawing.Size(523, 185);
            this.dataGridView_GestionarTrabajadores.TabIndex = 1;
            this.dataGridView_GestionarTrabajadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GestionarTrabajadores_CellContentClick);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Contrasenya
            // 
            this.Contrasenya.HeaderText = "Contraseña";
            this.Contrasenya.Name = "Contrasenya";
            this.Contrasenya.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // GestionarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 242);
            this.Controls.Add(this.dataGridView_GestionarTrabajadores);
            this.Controls.Add(this.label1);
            this.Name = "GestionarTrabajadores";
            this.Text = "GestionarTrabajadores";
            this.Load += new System.EventHandler(this.GestionarTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionarTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_GestionarTrabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}