using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CP;

namespace InfoCostePrograma
{
    class InvoiceUtils
    {
        public bool toFactura(TipoFacturaEN tf)
        {
            Type g = tf.GetType();

            if (g == typeof(ReservaEN))
                return reservaToFactura((ReservaEN)tf);
            else if (g == typeof(PresupuestoEN))
                return presupuestoToFactura((PresupuestoEN)tf);
            else if (g == typeof(ProformaEN))
                return proformaToFactura((ProformaEN)tf);
            else return false;
        }

        private bool reservaToFactura(ReservaEN reserva)
        {
            PedidoClienteCEN pcCEN = new PedidoClienteCEN();
            PedidoClienteEN pedido = pcCEN.LeerPorOID(reserva.Id);

            // desrealciono
            PedidoClienteCEN pcCEN2 = new PedidoClienteCEN();
            pcCEN2.BorrarTipoFactura(pedido.Id, reserva.Id);

            //  borro reserva y tipofactura
            ReservaCEN rCEN = new ReservaCEN();
            rCEN.Borrar(reserva.Id);
            /*TipoFacturaCEN tfCEN = new TipoFacturaCEN();
            tfCEN.Borrar(reserva.Id);*/

            //Creo nueva factura
            FacturaCEN fCEN = new FacturaCEN();
            fCEN.Factura(reserva.Id, reserva.Fecha, reserva.DatosPago, pedido.Id, true);
            FacturaEN fEN = fCEN.LeerPorOID(reserva.Id);

            // relaciono
            pcCEN.NuevoTipoFactura(pedido.Id, fEN.Id);

            return true;
        }

        private bool presupuestoToFactura(PresupuestoEN presupuesto)
        {
            PedidoClienteCEN pcCEN = new PedidoClienteCEN();
            PedidoClienteEN pedido = pcCEN.LeerPorOID(presupuesto.Id);

            // desrealciono
            PedidoClienteCEN pcCEN2 = new PedidoClienteCEN();
            pcCEN2.BorrarTipoFactura(pedido.Id, presupuesto.Id);

            //  borro presupuesto y tipofactura
            PresupuestoCEN rCEN = new PresupuestoCEN();
            rCEN.Borrar(presupuesto.Id);
            /*TipoFacturaCEN tfCEN = new TipoFacturaCEN();
            tfCEN.Borrar(reserva.Id);*/

            //Creo nueva factura
            FacturaCEN fCEN = new FacturaCEN();
            fCEN.Factura(presupuesto.Id, presupuesto.Fecha, presupuesto.DatosPago, pedido.Id, true);
            FacturaEN fEN = fCEN.LeerPorOID(presupuesto.Id);

            // relaciono
            pcCEN.NuevoTipoFactura(pedido.Id, fEN.Id);

            return true;
        }

        private bool proformaToFactura(ProformaEN proforma)
        {
            PedidoClienteCEN pcCEN = new PedidoClienteCEN();
            PedidoClienteEN pedido = pcCEN.LeerPorOID(proforma.Id);

            // desrealciono
            PedidoClienteCEN pcCEN2 = new PedidoClienteCEN();
            pcCEN2.BorrarTipoFactura(pedido.Id, proforma.Id);

            //  borro presupuesto y tipofactura
            ProformaCEN rCEN = new ProformaCEN();
            rCEN.Borrar(proforma.Id);
            /*TipoFacturaCEN tfCEN = new TipoFacturaCEN();
            tfCEN.Borrar(reserva.Id);*/

            //Creo nueva factura
            FacturaCEN fCEN = new FacturaCEN();
            fCEN.Factura(proforma.Id, proforma.Fecha, proforma.DatosPago, pedido.Id, true);
            FacturaEN fEN = fCEN.LeerPorOID(proforma.Id);

            // relaciono
            pcCEN.NuevoTipoFactura(pedido.Id, fEN.Id);

            return true;
        }
    }
}
