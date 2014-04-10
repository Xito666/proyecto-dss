
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
public partial class ClienteCEN
{
public void SetEmail (string p_Cliente_OID, string p_email)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Cliente_setEmail_customized) START*/

        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Id = p_Cliente_OID;
        clienteEN.Email = p_email;
        //Call to ClienteCAD

        _IClienteCAD.SetEmail (clienteEN);

        /*PROTECTED REGION END*/
}
}
}
