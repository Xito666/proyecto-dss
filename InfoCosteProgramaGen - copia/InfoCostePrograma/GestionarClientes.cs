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
            if (e.ColumnIndex == 6)
            {

            }
            else if (e.ColumnIndex == 7)
            {
                // pasarle el trabajador para rellenar los datos en los recuadros correspondientes
                bool esEmpresa =Convert.ToBoolean( dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[5].Value.ToString());
                if (esEmpresa)
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN cliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN();

                    cliente.Id = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cliente.NombreCompleto = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cliente.Direccion = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cliente.Telefono = 0;//Convert.ToInt32(dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cliente.Email =  dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cliente.NumeroCuenta = 000000;

                    NuevoCliente nc = new NuevoCliente(cliente);
                    nc.Show();
                }
                else
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteParticularEN cliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteParticularEN();

                    cliente.Id = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cliente.NombreCompleto = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cliente.Direccion = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cliente.Telefono = 0;//Convert.ToInt32(dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cliente.Email = dataGridView_GestionarClientes.Rows[e.RowIndex].Cells[4].Value.ToString();

                    NuevoCliente nc = new NuevoCliente(cliente);
                    nc.Show();
                }


                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente();
            nc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ver_presupuestos vp = new Ver_presupuestos();
            vp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ver_reservas vr = new ver_reservas();
            vr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            DataGridViewRow row = dataGridView_GestionarClientes.SelectedRows[0];

            c.rellenar(row);

            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este cliente?", "Clientes", MessageBoxButtons.OKCancel);
        }
    }
}
