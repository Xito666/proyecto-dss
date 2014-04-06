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
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este producto?", "Producto", MessageBoxButtons.OKCancel);
        }

        private void GestionarProductos_Load(object sender, EventArgs e)
        {
            dataGridView_GestionarProductos.Rows.Add(1, "Monitor", "Pantallas", "29.99", "4", "Buena calidad");
            dataGridView_GestionarProductos.Rows.Add(2, "Teclado", "Ordenadores", "2.99", "2", "Bueno, bonito, barato");
            dataGridView_GestionarProductos.Rows.Add(3, "Teclado", "Ordenadores", "15", "3", "Tremendo!");
            dataGridView_GestionarProductos.Rows.Add(4, "Raton", "Ordenadores", "18", "1", "OP");
            dataGridView_GestionarProductos.Rows.Add(5, "Antena Wifi", "Accesorios", "8.25", "2", "Largo alcance");
            dataGridView_GestionarProductos.Rows.Add(6, "Router", "Accesorios", "15.80", "2", "Gran calidad");
            dataGridView_GestionarProductos.Rows.Add(7, "Alargador", "Accesorios", "5", "5", "15 Metros");
            dataGridView_GestionarProductos.Rows.Add(8, "Cable HDMI", "Accesorios", "10.20", "1", "");
            dataGridView_GestionarProductos.Rows.Add(9, "Cable USB", "Accesorios", "10", "15", "");
            dataGridView_GestionarProductos.Rows.Add(10, "Procesador Intel", "Ordenadores", "", "", "");

        }
    }
}
