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
    public partial class GestionarPartes : Form
    {
        public GestionarPartes()
        {
            InitializeComponent();
        }

        //JARO: esto esta forzando  que el aviso por mail siempre me llega a mi xk sino no podia probarlo.
        //Necesitare una lista de partes -> List<ParteInvervencionEN> partes;
        private void GestionarPartes_Load(object sender, EventArgs e)
        {
            //dataGridViewPartes.Rows.Add(new object[] { "17/05/2014", "Daniel Heredia", "Pepito", "Packard Bell", "Sustituir tarjeta" });

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN parte = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ParteIntervencionCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> listaPartes = parte.LeerTodos(0, 20);

            dataGridViewPartes.Rows.Clear();
            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN p in listaPartes)
            {
                TrabajadorCEN tCEN = new TrabajadorCEN();
                TrabajadorEN tEN = tCEN.LeerPorOID(p.Trabajador.Id);
                ClienteCEN cCEN = new ClienteCEN();
                ClienteEN cEN = cCEN.LeerPorOID(p.Cliente.Id);

                dataGridViewPartes.Rows.Add(p.Id,p.Fecha,cEN.NombreCompleto ,tEN.Nombre, p.DatosPc, p.AccionesRealizadas);
            }
        }

        // NUEVO
        private void button1_Click(object sender, EventArgs e)
        {

            /*NuevoParte parte= new NuevoParte();
            parte.Show();*/
            NuevoParte nc = new NuevoParte();
            if (nc.ShowDialog() == DialogResult.OK)

                GestionarPartes_Load(null, null);
        }

        // EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridViewPartes.CurrentRow;

            NuevoParte p = new NuevoParte(Convert.ToInt32(current.Cells[0].Value));
            if (p.ShowDialog() == DialogResult.OK)
                GestionarPartes_Load(null, null);
        }

        // BORRAR
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada");
        }

        // BUSCAR
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada");
        }

        // AVISAR
        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridViewPartes.CurrentRow;
            //ParteIntervencionEN parte = partes[dataGridView1.CurrentRow];
            if (current == null) return;
            //Obtener datos de cliente
            current.Cells[0].Value.ToString();

            ClienteCEN clientes = new ClienteCEN();
            //obtengo una lista pero realmente sera solo el usu con ese nombre
            IList<ClienteEN> clienteNombre = clientes.LeerPorNombre(current.Cells[2].Value.ToString());
           // ClienteEN cliente = clientes.LeerPorOID(current.Cells[0].Value.ToString());

            MailReparation avisa = new MailReparation();
            avisa.EnviarAviso(clienteNombre[0].NombreCompleto, clienteNombre[0].Email);
            //avisa.EnviarAviso(clienteNombre., cliente.Email);
        }
    }
}
