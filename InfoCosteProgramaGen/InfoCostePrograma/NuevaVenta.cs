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
    public partial class NuevaVenta : Form
    {

        ClienteEN c;

        public NuevaVenta()
        {
            InitializeComponent();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
        }

        private void buscarcliente_Click(object sender, EventArgs e)
        {
            SeleccionaCliente sc = new SeleccionaCliente();
            if (sc.ShowDialog() == DialogResult.OK)
            {
                c = sc.clienteSeleccionado;
                cliente.Text = c.NombreCompleto;
                cliente.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridView1.CurrentRow;
            dataGridView1.Rows.RemoveAt(current.Index);
            recalcularTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionaProducto sp = new SeleccionaProducto();

            if (sp.ShowDialog() == DialogResult.OK)
            {
                ProductoEN p = sp.productoSeleccionado;
                int cantidad = 1;
                int descuento = 0;
                dataGridView1.Rows.Add(p.Id,cantidad, p.Nombre, 0, p.Precio - (descuento*p.Precio), cantidad * p.Precio);
                recalcularTotal();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            if (columna == 3 || columna == 1)
            {
                int cantidad = Convert.ToInt32(dataGridView1.Rows[fila].Cells[1].Value);
                int precioU = Convert.ToInt32(dataGridView1.Rows[fila].Cells[4].Value);
                int descuento = Convert.ToInt32(dataGridView1.Rows[fila].Cells[3].Value);
                double precioL = cantidad * (precioU - ((descuento / 100f)* precioU));
                dataGridView1.Rows[fila].Cells[5].Value = precioL.ToString();
                recalcularTotal();
            }
            
        }

        private void recalcularTotal()
        {
            double acum = 0f;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                acum += Double.Parse(fila.Cells[5].Value.ToString());
            }
            label_Precio.Text = acum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cliente.Text == "")
            {
                MessageBox.Show(this, "Selecciona un cliente", "Error");
            }
            else if(0==0)
            {
                MessageBox.Show(this, "Agregue productos a la venta", "Error");
            }
            else
            {
            }
        }

       
    }
}
