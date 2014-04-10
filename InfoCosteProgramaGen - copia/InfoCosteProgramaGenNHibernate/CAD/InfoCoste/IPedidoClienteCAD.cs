
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IPedidoClienteCAD
{
PedidoClienteEN ReadOIDDefault (int id);

void Facturar (int p_PedidoCliente_OID, int p_tipoFactura_OID);



void BorrarLinea (int p_PedidoCliente_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);

void AnyadirLinea (int p_PedidoCliente_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);

void SetCliente (int p_PedidoCliente_OID, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN nuevoCliente);





int PedidoCliente (PedidoClienteEN pedidoCliente);

System.Collections.Generic.IList<PedidoClienteEN> LeerTodos (int first, int size);


PedidoClienteEN LeerPorOID (int id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> LeerPorFecha (Nullable<DateTime> fechaFilter);
}
}
