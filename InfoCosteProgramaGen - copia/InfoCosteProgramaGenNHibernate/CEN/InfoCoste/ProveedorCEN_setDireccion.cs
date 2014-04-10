
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
public void SetDireccion (string p_Proveedor_OID, string p_direccion)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Proveedor_setDireccion_customized) START*/

        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_Proveedor_OID;
        proveedorEN.Direccion = p_direccion;
        //Call to ProveedorCAD

        _IProveedorCAD.SetDireccion (proveedorEN);

        /*PROTECTED REGION END*/
}
}
}
