
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IProveedorCAD
{
ProveedorEN ReadOIDDefault (string id);

void SetEmail (ProveedorEN proveedor);


void SetDireccion (ProveedorEN proveedor);


void SetNombre (ProveedorEN proveedor);


void Borrar(string id);



string Proveedor (ProveedorEN proveedor);

System.Collections.Generic.IList<ProveedorEN> LeerTodos (int first, int size);


ProveedorEN LeerPorOID (string id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN> LeerPorNombre (string nombreFiltro);
}
}
