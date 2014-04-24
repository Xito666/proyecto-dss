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
    public partial class ver_reservas : Form
    {
        public ver_reservas()
        {
            InitializeComponent();
        }

        public ver_reservas(string ID)
        {
            InitializeComponent();
            ClienteCEN ccen = new ClienteCEN();
            ClienteEN cen = ccen.LeerPorOID(ID);
            IList<PedidoClienteEN> listaPedidos = cen.PedidoCliente;
            foreach(PedidoClienteEN ped in listaPedidos)
            {
                TipoFacturaEN tfac = ped.TipoFactura;
                
                // tfac contiene toda la info de la reserva
            }
            
        }

        private void ver_reservas_Load(object sender, EventArgs e)
        {

        }
    }
}
