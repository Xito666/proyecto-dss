
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface ILineaPedidoProveedorCAD
{
LineaPedidoProveedorEN ReadOIDDefault (string id);

void SetProducto (string p_LineaPedidoProveedor_OID, double p_precioCoste);

void SetDescuento (LineaPedidoProveedorEN lineaPedidoProveedor);


void SetCantidad (LineaPedidoProveedorEN lineaPedidoProveedor);


void SetNumero (LineaPedidoProveedorEN lineaPedidoProveedor);







string LineaPedidoProveedor (LineaPedidoProveedorEN lineaPedidoProveedor);
}
}
