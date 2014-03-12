
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
public partial class ProveedorCEN
{
public void SetEmail (string p_Proveedor_OID, string p_email)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Proveedor_setEmail_customized) START*/

        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_Proveedor_OID;
        proveedorEN.Email = p_email;
        //Call to ProveedorCAD

        _IProveedorCAD.SetEmail (proveedorEN);

        /*PROTECTED REGION END*/
}
}
}
