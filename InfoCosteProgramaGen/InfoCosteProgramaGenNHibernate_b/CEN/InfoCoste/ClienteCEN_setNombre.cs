
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
public void SetNombre (string p_Cliente_OID, string p_nombreCompleto)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Cliente_setNombre_customized) START*/

        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Id = p_Cliente_OID;
        clienteEN.NombreCompleto = p_nombreCompleto;
        //Call to ClienteCAD

        _IClienteCAD.SetNombre (clienteEN);

        /*PROTECTED REGION END*/
}
}
}
