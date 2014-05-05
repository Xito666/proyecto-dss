
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
public partial class ClienteEmpresaCEN
{
public void SetNumeroCuenta (string p_ClienteEmpresa_OID, string p_numeroCuenta)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_ClienteEmpresa_setNumeroCuenta_customized) START*/

        ClienteEmpresaEN clienteEmpresaEN = null;

        //Initialized ClienteEmpresaEN
        clienteEmpresaEN = new ClienteEmpresaEN ();
        clienteEmpresaEN.Id = p_ClienteEmpresa_OID;
        clienteEmpresaEN.NumeroCuenta = p_numeroCuenta;
        //Call to ClienteEmpresaCAD

        _IClienteEmpresaCAD.SetNumeroCuenta (clienteEmpresaEN);

        /*PROTECTED REGION END*/
}
}
}
