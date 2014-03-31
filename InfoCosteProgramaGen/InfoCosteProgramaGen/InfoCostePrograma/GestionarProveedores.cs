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

        private void dataGridView_GestionarProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_GestionarProveedores.Rows.Add(1, "Azul-Tierra", "C\\ de Ejemplo 123", "", 966454545, true, "Eliminar", "Editar");
            dataGridView_GestionarProveedores.Rows.Add(2, "El Gato Fotografía", "Av. Larga 7", "info@elgatofotos.com", 966124578, true, "Eliminar", "Editar");
            dataGridView_GestionarProveedores.Rows.Add(3, "Pepito Perez Garcia", "C\\ Jon", "pperez@hotmail.com", 966218701, false, "Eliminar", "Editar");
        }
    }
}
