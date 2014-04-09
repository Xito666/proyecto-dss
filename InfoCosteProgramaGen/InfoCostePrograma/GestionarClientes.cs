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
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            dataGridView_GestionarClientes.Rows.Add(1, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(2, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(3, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
            dataGridView_GestionarClientes.Rows.Add(4, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(5, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(6, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
            dataGridView_GestionarClientes.Rows.Add(7, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(8, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(9, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
            dataGridView_GestionarClientes.Rows.Add(10, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(11, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(12, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
            dataGridView_GestionarClientes.Rows.Add(13, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(14, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(15, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
            dataGridView_GestionarClientes.Rows.Add(16, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, "", true);
            dataGridView_GestionarClientes.Rows.Add(17, "El Gato Fotografía", "Av. Larga 7", 966124578, "info@elgatofotos.com", true);
            dataGridView_GestionarClientes.Rows.Add(18, "Pepito Perez Garcia", "C\\ Jon", 966218701, "pperez@hotmail.com", false);
        }

        private void dataGridView_GestionarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // NUEVO CLIENTE
        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente();
            nc.Show();
        }

        // EDITAR CLIENTE
        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            DataGridViewRow row = dataGridView_GestionarClientes.SelectedRows[0];

            c.rellenar(row);

            c.Show();
        }

        // BORRAR CLIENTE
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este cliente?", "Clientes", MessageBoxButtons.OKCancel);
        }

        // VER PRESUPUESTOS DE CLIENTE
        private void button6_Click(object sender, EventArgs e)
        {
            Ver_presupuestos vp = new Ver_presupuestos();
            vp.Show();
        }

        // VER RESERVAS DE CLIENTE
        private void button5_Click(object sender, EventArgs e)
        {
            ver_reservas vr = new ver_reservas();
            vr.Show();
        }
    }
}
