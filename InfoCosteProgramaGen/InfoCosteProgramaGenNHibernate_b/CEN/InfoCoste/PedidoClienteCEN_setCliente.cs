
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
public void SetCliente (int p_PedidoCliente_OID, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN nuevoCliente)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_PedidoCliente_setCliente_customized) START*/


        //Call to PedidoClienteCAD

        _IPedidoClienteCAD.SetCliente (p_PedidoCliente_OID, nuevoCliente);

        /*PROTECTED REGION END*/
}
}
}
