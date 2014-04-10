
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
public partial class LineaPedidoCEN
{
public void SetProducto (int p_LineaPedido_OID, int p_producto_OID)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedido_setProducto_customized) START*/


        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.SetProducto (p_LineaPedido_OID, p_producto_OID);

        /*PROTECTED REGION END*/
}
}
}
