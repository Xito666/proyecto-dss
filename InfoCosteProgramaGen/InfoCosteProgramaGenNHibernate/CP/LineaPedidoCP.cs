using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CP
{
    public class LineaPedidoCP : BasicCP
    {
        public List<List<String>> getLineasPedidoPorId(int id)
        {
            SessionInitializeTransaction();

            List<List<String>> filas = new List<List<string>>();

            PedidoClienteCAD pcCAD = new PedidoClienteCAD(session);
            PedidoClienteEN pedido = pcCAD.LeerPorOID(id);
            IList<LineaPedidoEN> lineas = pedido.LineaPedido;

            foreach (LineaPedidoEN linea in lineas)
            {
                List<String> fila = new List<string>();
                fila.Add(linea.Producto.Id.ToString());
                fila.Add(linea.Cantidad.ToString());
                fila.Add(linea.Producto.Nombre.ToString());
                fila.Add(linea.Descuento.ToString());
                fila.Add(linea.Producto.Precio.ToString());
                double precioL = Convert.ToInt32(linea.Cantidad) * (Convert.ToInt32(linea.Producto.Precio) - ((Convert.ToInt32(linea.Descuento) / 100f) * (Convert.ToInt32(linea.Producto.Precio))));
                fila.Add(precioL.ToString());
                filas.Add(fila);
            }

            SessionCommit();
            return filas;
        }

        public ClienteEN getClienteDePedido(int id)
        {
            SessionInitializeTransaction();

            PedidoClienteCAD pcCAD = new PedidoClienteCAD(session);
            PedidoClienteEN pedido = pcCAD.LeerPorOID(id);
            ClienteEN c = new ClienteEN(pedido.Cliente);

            SessionCommit();

            return c;
        }
    }
}
