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
    public partial class GestionarProductos : Form
    {
        public GestionarProductos()
        {
            InitializeComponent();
        }

        // CARGAR
        private void GestionarProductos_Load(object sender, EventArgs e)
        {
            ProductoCEN pCEN = new ProductoCEN();
            IList<ProductoEN> listaProductos = pCEN.LeerTodos(0,1000);

            dataGridView_GestionarProductos.Rows.Clear();
            int i = 0;
            foreach (ProductoEN p in listaProductos)
            {
                dataGridView_GestionarProductos.Rows.Add(p.Id, p.Nombre, p.Familia, p.Precio, p.Stock, p.Descripcion);

                dataGridView_GestionarProductos.Rows[i].Cells[2].ReadOnly = true;
                dataGridView_GestionarProductos.Rows[i].Cells[0].ReadOnly = true;
                i++;
            }
        }

        // GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {
            ProductoCEN pCEN = new ProductoCEN();
            int ins = 0;

            for (int i = 0; i < dataGridView_GestionarProductos.Rows.Count-1; i++)
            {
                try
                {
                    DataGridViewRow fila = dataGridView_GestionarProductos.Rows[i];
                    ProductoEN pEN = pCEN.LeerPorOID(Convert.ToInt32(fila.Cells[0].Value));
                    
                    if (pEN != null)
                    {
                        pCEN.SetNombre(Convert.ToInt32(fila.Cells[0].Value.ToString()), fila.Cells[1].Value.ToString());
                        pCEN.SetPrecio(Convert.ToInt32(fila.Cells[0].Value.ToString()), Double.Parse(fila.Cells[3].Value.ToString()));
                        pCEN.SetStock(Convert.ToInt32(fila.Cells[0].Value.ToString()), Convert.ToInt32(fila.Cells[4].Value.ToString()));
                        pCEN.SetDescription(Convert.ToInt32(fila.Cells[0].Value.ToString()), fila.Cells[5].Value.ToString());
                    }
                    else
                    {
                        pCEN.Producto(Convert.ToInt32(fila.Cells[0].Value.ToString()),
                                        fila.Cells[1].Value.ToString(),
                                        fila.Cells[5].Value.ToString(),
                                        Double.Parse(fila.Cells[3].Value.ToString()),
                                        fila.Cells[2].Value.ToString(),
                                        Convert.ToInt32(fila.Cells[4].Value.ToString()));
                        ins++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la fila " + i + "\nNo pueden haber campos vacíos", "Error", MessageBoxButtons.OKCancel);
                }
            }

            MessageBox.Show("Se han confirmado las modificaciones.\nSe han insertado " + ins + " registros.", "Save Log", MessageBoxButtons.OKCancel);
        }


        // BORRAR
        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se va a eliminar el producto", "Productos", MessageBoxButtons.OK) == DialogResult.OK)
            {
                DataGridViewRow current = dataGridView_GestionarProductos.CurrentRow;

                ProductoCEN pCEN = new ProductoCEN();
                pCEN.Borrar(Convert.ToInt32(current.Cells[0].Value));

                GestionarProductos_Load(null, null);
            }
        }

        // BUSCAR POR FAMILIA
        private void button3_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del Producto?");
            ProductoCEN pcen = new ProductoCEN();
            IList<ProductoEN> lp = pcen.LeerPorFamilia(input);

            dataGridView_GestionarProductos.Rows.Clear();
            int i = 0;
            
            foreach (ProductoEN p in lp)
            {
                dataGridView_GestionarProductos.Rows.Add(p.Id, p.Nombre, p.Familia, p.Precio, p.Stock, p.Descripcion);

                dataGridView_GestionarProductos.Rows[i].Cells[2].ReadOnly = true;
                dataGridView_GestionarProductos.Rows[i].Cells[0].ReadOnly = true;
                i++;
            }
        }

        // BUSCAR POR NOMBRE
        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del Producto?");
            ProductoCEN pcen = new ProductoCEN();
            IList<ProductoEN> lp = pcen.LeerPorNombre(input);

            dataGridView_GestionarProductos.Rows.Clear();
            int i = 0;
            foreach (ProductoEN p in lp)
            {
                dataGridView_GestionarProductos.Rows.Add(p.Id, p.Nombre, p.Familia, p.Precio, p.Stock, p.Descripcion);

                dataGridView_GestionarProductos.Rows[i].Cells[2].ReadOnly = true;
                dataGridView_GestionarProductos.Rows[i].Cells[0].ReadOnly = true;
                i++;
            }
        }
    }
}
