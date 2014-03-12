
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
public void SetNombre (string p_Proveedor_OID, string p_nombre)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Proveedor_setNombre_customized) START*/

        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_Proveedor_OID;
        proveedorEN.Nombre = p_nombre;
        //Call to ProveedorCAD

        _IProveedorCAD.SetNombre (proveedorEN);

        /*PROTECTED REGION END*/
}
}
}
