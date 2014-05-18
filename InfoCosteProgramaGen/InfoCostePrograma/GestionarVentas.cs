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
using InfoCosteProgramaGenNHibernate.CP;

namespace InfoCostePrograma
{
    public partial class GestionarVentas : Form
    {
        public GestionarVentas()
        {
            InitializeComponent();
        }

        // CARGAR
        private void GestionarVentas_Load(object sender, EventArgs e)
        {
            PedidoClienteCEN pcCEN = new PedidoClienteCEN();
            IList<PedidoClienteEN> listaPedidos = pcCEN.LeerTodos(0, 100);

            dataGridView_GestionarVentas.Rows.Clear();

            foreach (PedidoClienteEN pedido in listaPedidos)
            {
                LineaPedidoCP lpCP = new LineaPedidoCP();
                List<List<String>> filas = lpCP.getLineasPedidoPorId(pedido.Id);

                double total = 0;

                foreach (List<String> fila in filas)
                {
                    total += Double.Parse(fila[5]);
                }

                LineaPedidoCP lpCP2 = new LineaPedidoCP();

                TipoFacturaEN tf = NuevaVenta.obtenerFacturaTipada(pedido.Id);

                String s = "";
                try
                {

                    Type g = tf.GetType();
                    if (g == typeof(FacturaEN))
                        s = "Factura";
                    else if (g == typeof(ReservaEN))
                        s = "Reserva";
                    else if (g == typeof(PresupuestoEN))
                        s = "Presupuesto";
                    else if (g == typeof(ProformaEN))
                        s = "Proforma";
                }
                catch (Exception ex) { }

                dataGridView_GestionarVentas.Rows.Add(pedido.Id, lpCP2.getClienteDePedido(pedido.Id).NombreCompleto, pedido.Fecha, total.ToString(), s);
            }
        }

        // NUEVA
        private void button1_Click(object sender, EventArgs e)
        {
            NuevaVenta nv = new NuevaVenta();
            if (nv.ShowDialog() == DialogResult.OK)
                GestionarVentas_Load(null, null);
        }

        // BORRAR
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar esta venta?", "Ventas", MessageBoxButtons.OK);

            DataGridViewRow current = dataGridView_GestionarVentas.CurrentRow;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.PedidoClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.PedidoClienteCEN();

            LineaPedidoCP cp = new LineaPedidoCP();
            cp.aumentarStockDePedido(Convert.ToInt32(current.Cells[0].Value));
            
            
            ccen.Borrar(Convert.ToInt32(current.Cells[0].Value));

            try {
                new TipoFacturaCEN().Borrar(Convert.ToInt32(current.Cells[0].Value));
            }
            catch (Exception ex) { }
            try {
                new FacturaCEN().Borrar(Convert.ToInt32(current.Cells[0].Value));
            }
            catch (Exception ex) { }
            try
            {
                new PresupuestoCEN().Borrar(Convert.ToInt32(current.Cells[0].Value));
            }
            catch (Exception ex) { }
            try
            {
                new ProductoCEN().Borrar(Convert.ToInt32(current.Cells[0].Value));
            }
            catch (Exception ex) { }
            try
            {
                new ReservaCEN().Borrar(Convert.ToInt32(current.Cells[0].Value));
            }
            catch (Exception ex) { }


            GestionarVentas_Load(null, null);
        }

        // BUSCAR
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada");
        }

        // IMPRIMIR
        private void button5_Click(object sender, EventArgs e)
        {
            PedidoClienteEN pedido = new PedidoClienteCEN().LeerPorOID(
            Convert.ToInt32(dataGridView_GestionarVentas.Rows[dataGridView_GestionarVentas.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
            Printable p = new Printable(pedido);
            p.Print();
        }

        // ESTADISTICAS
        private void button2_Click(object sender, EventArgs e)
        {
            GraficoVentas g = new GraficoVentas();
            g.ShowDialog();
        }

        private void dataGridView_GestionarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            NuevaVenta nv = new NuevaVenta(Convert.ToInt32(dataGridView_GestionarVentas.Rows[fila].Cells[0].Value.ToString()));

            if (nv.ShowDialog() == DialogResult.OK)
                GestionarVentas_Load(null, null);
        }
    }
}
