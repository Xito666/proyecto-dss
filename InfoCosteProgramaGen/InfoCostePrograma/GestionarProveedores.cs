using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfoCostePrograma
{
    public partial class GestionarProveedores : Form
    {
        public GestionarProveedores()
        {
            InitializeComponent();
        }

        private void GestionarProveedores_Load(object sender, EventArgs e)
        {
            dataGridView_GestionarProveedores.Rows.Add(1, "Azul-Tierra", "C\\ de Ejemplo 123", "");
            dataGridView_GestionarProveedores.Rows.Add(2, "El Gato Fotografía", "Av. Larga 7", "info@elgatofotos.com");
            dataGridView_GestionarProveedores.Rows.Add(3, "Pepito Perez Garcia", "C\\ Jon", "pperez@hotmail.com");
        }

        private void dataGridView_GestionarProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoProveedor np = new NuevoProveedor();
            np.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este proveedor?", "Proveedor", MessageBoxButtons.OKCancel);
        }
    }
}
