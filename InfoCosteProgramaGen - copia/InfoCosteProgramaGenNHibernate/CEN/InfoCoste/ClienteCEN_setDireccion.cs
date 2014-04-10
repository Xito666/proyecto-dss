
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
public void SetDireccion (string p_Cliente_OID, string p_direccion)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Cliente_setDireccion_customized) START*/

        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Id = p_Cliente_OID;
        clienteEN.Direccion = p_direccion;
        //Call to ClienteCAD

        _IClienteCAD.SetDireccion (clienteEN);

        /*PROTECTED REGION END*/
}
}
}
