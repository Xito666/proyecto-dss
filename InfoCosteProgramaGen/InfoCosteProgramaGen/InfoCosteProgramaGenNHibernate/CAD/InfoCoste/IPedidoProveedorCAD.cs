
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IPedidoProveedorCAD
{
PedidoProveedorEN ReadOIDDefault (int id);



void BorrarLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs);

void AnyadirLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs);

void SetProveedor (int p_PedidoProveedor_OID, string p_proveedor_OID);





int PedidoProveedor (PedidoProveedorEN pedidoProveedor);

System.Collections.Generic.IList<PedidoProveedorEN> LeerTodos (int first, int size);


PedidoProveedorEN LeePorOID (int id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> LeePorFecha (Nullable<DateTime> fechaFiltro);
}
}
