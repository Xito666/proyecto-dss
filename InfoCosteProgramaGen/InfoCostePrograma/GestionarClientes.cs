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
            dataGridView_GestionarClientes.Rows.Add(1, "Azul-Tierra", "C\\ de Ejemplo 123", 966454545, true, "Eliminar", "Editar");
            dataGridView_GestionarClientes.Rows.Add(2, "El Gato Fotografía", "Av. Larga 7", 966124578, true, "Eliminar", "Editar");
            dataGridView_GestionarClientes.Rows.Add(3, "Pepito Perez Garcia", "C\\ Jon", 966218701, false, "Eliminar", "Editar");
        }

        private void dataGridView_GestionarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

            }
            else if (e.ColumnIndex == 6)
            {
                // pasarle el trabajador para rellenar los datos en los recuadros correspondientes
                NuevoCliente nc = new NuevoCliente();
                nc.Show();
            }
        }
    }
}
