
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CEN.InfoCoste
{
public partial class LineaPedidoProveedorCEN
{
public void SetCantidad (string p_LineaPedidoProveedor_OID, int p_cantidad)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedidoProveedor_setCantidad_customized) START*/

        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Id = p_LineaPedidoProveedor_OID;
        lineaPedidoProveedorEN.Cantidad = p_cantidad;
        //Call to LineaPedidoProveedorCAD

        _ILineaPedidoProveedorCAD.SetCantidad (lineaPedidoProveedorEN);

        /*PROTECTED REGION END*/
}
}
}
