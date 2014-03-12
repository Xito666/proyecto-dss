
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
public void SetProducto (string p_LineaPedidoProveedor_OID, double p_precioCoste)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedidoProveedor_setProducto_customized) START*/


        //Call to LineaPedidoProveedorCAD

        _ILineaPedidoProveedorCAD.SetProducto (p_LineaPedidoProveedor_OID, p_precioCoste);

        /*PROTECTED REGION END*/
}
}
}
