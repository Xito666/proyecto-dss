
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id);

void SetProducto (int p_LineaPedido_OID, int p_producto_OID);

void SetDescuento (LineaPedidoEN lineaPedido);


void SetCantidad (LineaPedidoEN lineaPedido);


void SetNumero (LineaPedidoEN lineaPedido);







int LineaPedido (LineaPedidoEN lineaPedido);
}
}
