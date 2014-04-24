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
    public partial class SeleccionaCliente : Form
    {

        public ClienteEN clienteSeleccionado;

        public SeleccionaCliente()
        {
            InitializeComponent();
        }

        private void SeleccionaCliente_Load(object sender, EventArgs e)
        {
            ClienteCEN ccen = new ClienteCEN();
            IList<ClienteEN> listaClientes = ccen.LeerTodos(0, 100);

            dataGridView1.Rows.Clear();
            foreach (ClienteEN c in listaClientes)
            {
                bool empresa = false;
                ClienteEmpresaCEN ceCEN = new ClienteEmpresaCEN();
                try
                {
                    ClienteEmpresaEN ceEN = ceCEN.LeerPorOID(c.Id);
                    if (ceEN != null)
                        empresa = true;
                }
                catch (Exception ex) { }
                dataGridView1.Rows.Add(c.Id, c.NombreCompleto, c.Direccion, c.Telefono, c.Email, empresa);
            }
        }

        private void dataGridView_GestionarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow current = dataGridView1.CurrentRow;

            ClienteCEN cCEN = new ClienteCEN();
            clienteSeleccionado = cCEN.LeerPorOID(current.Cells[0].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
