using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCostePrograma
{
    public partial class SeleccionaProducto : Form
    {

        public ProductoEN productoSeleccionado;

        public SeleccionaProducto()
        {
            InitializeComponent();
        }

        private void SeleccionaProducto_Load(object sender, EventArgs e)
        {
            ProductoCEN pCEN = new ProductoCEN();
            IList<ProductoEN> listaProductos = pCEN.LeerTodos(0, 1000);

            foreach(ProductoEN p in listaProductos)
            {
                dataGridView1.Rows.Add(p.Id, p.Nombre, p.Familia, p.Precio, p.Stock, p.Descripcion);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow current = dataGridView1.CurrentRow;

            ProductoCEN pCEN = new ProductoCEN();
            productoSeleccionado = pCEN.LeerPorOID(Convert.ToInt32(current.Cells[0].Value));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del Producto?");
            ProductoCEN pcen = new ProductoCEN();
            IList<ProductoEN> lp = pcen.LeerPorFamilia(input);

            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (ProductoEN p in lp)
            {
                dataGridView1.Rows.Add(p.Id, p.Nombre, p.Familia, p.Precio, p.Stock, p.Descripcion);

                dataGridView1.Rows[i].Cells[2].ReadOnly = true;
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                i++;
            }
        }
    }
}
