namespace InfoCostePrograma
{
    partial class GestionarClientes
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
            this.dataGridView_GestionarClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GestionarClientes
            // 
            this.dataGridView_GestionarClientes.AllowUserToDeleteRows = false;
            this.dataGridView_GestionarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GestionarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.Empresa,
            this.Eliminar,
            this.Editar});
            this.dataGridView_GestionarClientes.Location = new System.Drawing.Point(12, 45);
            this.dataGridView_GestionarClientes.Name = "dataGridView_GestionarClientes";
            this.dataGridView_GestionarClientes.ReadOnly = true;
            this.dataGridView_GestionarClientes.RowHeadersWidth = 20;
            this.dataGridView_GestionarClientes.Size = new System.Drawing.Size(723, 185);
            this.dataGridView_GestionarClientes.TabIndex = 3;
            this.dataGridView_GestionarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GestionarClientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "¿Empresa?";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestionar Trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gestionar Trabajadores";
            // 
            // GestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_GestionarClientes);
            this.Controls.Add(this.label1);
            this.Name = "GestionarClientes";
            this.Text = "GestionarClientes";
            this.Load += new System.EventHandler(this.GestionarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GestionarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GestionarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}