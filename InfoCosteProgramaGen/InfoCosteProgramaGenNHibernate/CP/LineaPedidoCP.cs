﻿using System;
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

        public double getTotalPedido(int id)
        {
            double total = 0;

            SessionInitializeTransaction();

            PedidoClienteCAD pcCAD = new PedidoClienteCAD(session);
            PedidoClienteEN pedido = pcCAD.LeerPorOID(id);
            IList<LineaPedidoEN> lineas = pedido.LineaPedido;

            foreach (LineaPedidoEN linea in lineas)
            {
                double precioL = Convert.ToInt32(linea.Cantidad) * (Convert.ToInt32(linea.Producto.Precio) - ((Convert.ToInt32(linea.Descuento) / 100f) * (Convert.ToInt32(linea.Producto.Precio))));
                total += precioL;
            }

            SessionCommit();

            return total;
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

        public void aumentarStockDePedido(int id) 
        {
            SessionInitializeTransaction();
            // recorrer todos los productos para aumenta stock (meter en CP)
            PedidoClienteCAD pcCAD = new PedidoClienteCAD(session);
            PedidoClienteEN pcEN = pcCAD.LeerPorOID(id);
            foreach (LineaPedidoEN lp in pcEN.LineaPedido)
            {
                int n = lp.Producto.Stock;
                new ProductoCEN().SetStock(lp.Producto.Id, n + 1);
            }
            SessionCommit();
        }


    }
}
