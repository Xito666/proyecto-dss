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
    public partial class GestionarVentas : Form
    {
        public GestionarVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar esta venta?", "Ventas", MessageBoxButtons.OKCancel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaVenta nv = new NuevaVenta();
            if (nv.ShowDialog() == DialogResult.OK)
                GestionarVentas_Load(null, null);
        }

        private void dataGridView_GestionarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionarVentas_Load(object sender, EventArgs e)
        {
            PedidoClienteCEN pcCEN = new PedidoClienteCEN();
            IList<PedidoClienteEN> listaPedidos = pcCEN.LeerTodos(0,100);

            dataGridView_GestionarVentas.Rows.Clear();
            foreach(PedidoClienteEN pedido in listaPedidos)
            {
                dataGridView_GestionarVentas.Rows.Add(pedido.Id, ""/*pedido.Cliente.NombreCompleto*/, pedido.Fecha, "");
            }

        }
    }
}
