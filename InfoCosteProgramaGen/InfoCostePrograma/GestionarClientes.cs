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
            dataGridView_GestionarClientes.Rows.Add(1, "Azul-Tierra", "C\\ de Ejemplo 123","", 966454545, true, "Eliminar", "Editar");
            dataGridView_GestionarClientes.Rows.Add(2, "El Gato Fotografía", "Av. Larga 7", "info@elgatofotos.com", 966124578, true, "Eliminar", "Editar");
            dataGridView_GestionarClientes.Rows.Add(3, "Pepito Perez Garcia", "C\\ Jon","pperez@hotmail.com", 966218701, false, "Eliminar", "Editar");
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
    }
}
