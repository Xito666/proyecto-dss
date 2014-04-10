
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
public partial class PedidoClienteCEN
{
public void AnyadirLinea (int p_PedidoCliente_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_PedidoCliente_anyadirLinea_customized) START*/


        //Call to PedidoClienteCAD

        _IPedidoClienteCAD.AnyadirLinea (p_PedidoCliente_OID, p_lineaPedido_OIDs);

        /*PROTECTED REGION END*/
}
}
}
