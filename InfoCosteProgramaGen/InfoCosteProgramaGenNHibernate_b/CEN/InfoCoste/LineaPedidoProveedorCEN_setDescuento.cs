
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
public void SetDescuento (string p_LineaPedidoProveedor_OID, double p_descuento)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedidoProveedor_setDescuento_customized) START*/

        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Id = p_LineaPedidoProveedor_OID;
        lineaPedidoProveedorEN.Descuento = p_descuento;
        //Call to LineaPedidoProveedorCAD

        _ILineaPedidoProveedorCAD.SetDescuento (lineaPedidoProveedorEN);

        /*PROTECTED REGION END*/
}
}
}
