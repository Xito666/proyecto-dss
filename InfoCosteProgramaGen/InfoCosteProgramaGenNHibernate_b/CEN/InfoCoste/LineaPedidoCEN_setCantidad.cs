
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
public void SetCantidad (int p_LineaPedido_OID, int p_cantidad)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedido_setCantidad_customized) START*/

        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Cantidad = p_cantidad;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.SetCantidad (lineaPedidoEN);

        /*PROTECTED REGION END*/
}
}
}
