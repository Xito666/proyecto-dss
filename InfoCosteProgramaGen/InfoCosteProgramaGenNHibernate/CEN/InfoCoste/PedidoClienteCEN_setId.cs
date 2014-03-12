
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
public void SetId (int p_PedidoCliente_OID, int idNuevo)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_PedidoCliente_setId_customized) START*/

        PedidoClienteEN pedidoClienteEN = null;

        //Initialized PedidoClienteEN
        pedidoClienteEN = new PedidoClienteEN ();
        pedidoClienteEN.Id = p_PedidoCliente_OID;
        pedidoClienteEN.IdNuevo = idNuevo;
        //Call to PedidoClienteCAD

        _IPedidoClienteCAD.SetId (pedidoClienteEN);

        /*PROTECTED REGION END*/
}
}
}
