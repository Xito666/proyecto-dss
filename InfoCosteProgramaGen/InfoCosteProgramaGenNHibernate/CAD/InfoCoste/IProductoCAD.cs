
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int id);

void DisminuirStock (ProductoEN producto);


void SetStock (ProductoEN producto);


void SetPrecio (ProductoEN producto);


void SetNombre (ProductoEN producto);








int Producto (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> LeerTodos (int first, int size);


ProductoEN LeerPorOID (int id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN> LeerPorNombre (string nombreFiltro);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN> LeerPorFamilia (string familiaFiltro);


void SetDescription (ProductoEN producto);


void Borrar (int id);
}
}
