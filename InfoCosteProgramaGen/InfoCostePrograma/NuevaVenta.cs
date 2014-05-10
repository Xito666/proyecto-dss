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
    public partial class NuevaVenta : Form
    {

        ClienteEN c;
        TipoFacturaEN f;

        public NuevaVenta(int id) //id de Pedido
        {
            InitializeComponent();

            dataGridView1.Enabled = false;
            cliente.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            buscarcliente.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;


            LineaPedidoCP lpCP = new LineaPedidoCP();
            List<List<String>> filas = lpCP.getLineasPedidoPorId(id);

            double total = 0;

            foreach (List<String> fila in filas)
            {
                dataGridView1.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5]);
                total += Double.Parse(fila[5]);
            }

            LineaPedidoCP lpCP2 = new LineaPedidoCP();
            ClienteEN clie = lpCP2.getClienteDePedido(id);
            c = clie;
            cliente.Text = clie.NombreCompleto;
            label_Precio.Text = total.ToString();

            TipoFacturaEN tf = obtenerFacturaTipada(id);

            f = tf;

            Type g = tf.GetType();
            if (g == typeof(FacturaEN))
            {
                radioButton1.Checked = true;
                ConvertirEnFactura.Visible = false;
            }
            else if (g == typeof(ReservaEN))
                radioButton3.Checked = true;
            else if (g == typeof(PresupuestoEN))
                radioButton2.Checked = true;
            else if (g == typeof(ProformaEN))
                radioButton4.Checked = true;
           

        }

        public NuevaVenta()
        {
            InitializeComponent();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            ConvertirEnFactura.Visible = false;
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
            else if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show(this, "Agregue productos a la venta", "Error");
            }
            else
            {
                PedidoClienteCEN pcCEN = new PedidoClienteCEN();
                IList<PedidoClienteEN> listaPed = pcCEN.LeerTodos(0,100);


                int nID = 0;
                try
                {
                    nID = listaPed.Last().Id + 1;
                }
                catch (Exception ex) { }

                pcCEN.PedidoCliente(nID, DateTime.Now, c.Id);

                PedidoClienteEN pcEN = pcCEN.LeerPorOID(nID);

                LineaPedidoCEN lpCEN = new LineaPedidoCEN();

                int id = 0;
                try
                {
                    id = lpCEN.LeerTodos(0, 10000).Last().Id + 1;
                }
                catch (Exception ex) { }

                int i = 0;
                List<int> listaID = new List<int>();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    lpCEN.LineaPedido(id, i,Convert.ToInt32(fila.Cells[1].Value.ToString()), Double.Parse(fila.Cells[3].Value.ToString()),Convert.ToInt32(fila.Cells[0].Value.ToString()));
                    listaID.Add(id);

                    ProductoCEN pCEN = new ProductoCEN();
                    ProductoEN pEN = pCEN.LeerPorOID(Convert.ToInt32(fila.Cells[0].Value.ToString()));
                    pCEN.SetStock(Convert.ToInt32(fila.Cells[0].Value.ToString()), pEN.Stock-1);

                    i++;
                    id++;
                }
                pcCEN.AnyadirLinea(pcEN.Id, listaID);

                if (radioButton1.Checked) // factura
                {
                    new FacturaCEN().Factura(pcEN.Id, DateTime.Now, "contado", pcEN.Id, true);
                }
                else if (radioButton2.Checked) // presup
                {
                    new PresupuestoCEN().Presupuesto(pcEN.Id, DateTime.Now, "contado", pcEN.Id);
                }
                else if (radioButton3.Checked) // reserva
                {
                    new ReservaCEN().Reserva(pcEN.Id, DateTime.Now, "contado", pcEN.Id);
                }
                else if (radioButton4.Checked)// proforma
                {
                    new ProformaCEN().Proforma(pcEN.Id, DateTime.Now, "contado", pcEN.Id);
                }
                else
                    throw new Exception();

                MessageBox.Show(this, "Documento Generado\nID: " + pcEN.Id+"\n", "Guardar documento");

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void crearFactura(PedidoClienteEN pedidoEN)
        {
        }

        private void crearPresupuesto(PedidoClienteEN pedidoEN)
        {
        }

        private void crearReserva(PedidoClienteEN pedidoEN)
        {
        }

        private void crearProforma(PedidoClienteEN pedidoEN)
        {
        }

       public static TipoFacturaEN obtenerFacturaTipada(int id)
        {
            TipoFacturaEN tf;
            try
            {
                tf = new FacturaCEN().LeerPorOID(id);
                if(tf != null)
                return tf;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                tf = new PresupuestoCEN().LeerPorOID(id);
                if (tf != null)
                return tf;
            }
            catch (Exception ex) { }
            try
            {
                tf = new ReservaCEN().LeerPorOID(id);
                if (tf != null)
                return tf;
            }
            catch (Exception ex) { }
            try
            {
                tf = new ProformaCEN().LeerPorOID(id);
                if (tf != null)
                return tf;
            }
            catch (Exception ex) { }

            return new TipoFacturaEN();
        }

       private void button4_Click(object sender, EventArgs e)
       {
           // Convertir Presupuesto, Reserva o Proforma en Factura

           InvoiceUtils conversor = new InvoiceUtils();

           bool ok = conversor.toFactura(f);

           if (ok)
               MessageBox.Show("Facturado correctamente");
           else
               MessageBox.Show("Problemas al facturar");

           DialogResult = DialogResult.OK;
           this.Close();
       }
       
    }
}
