
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
public void BorrarTipoFactura (int p_PedidoCliente_OID)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_PedidoCliente_borrarTipoFactura_customized) START*/


        //Call to PedidoClienteCAD

        _IPedidoClienteCAD.BorrarTipoFactura (p_PedidoCliente_OID);

        /*PROTECTED REGION END*/
}
}
}
