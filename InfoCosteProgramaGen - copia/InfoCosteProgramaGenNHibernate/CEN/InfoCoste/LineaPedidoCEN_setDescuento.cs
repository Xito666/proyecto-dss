
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
public void SetDescuento (int p_LineaPedido_OID, double p_descuento)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedido_setDescuento_customized) START*/

        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Descuento = p_descuento;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.SetDescuento (lineaPedidoEN);

        /*PROTECTED REGION END*/
}
}
}
