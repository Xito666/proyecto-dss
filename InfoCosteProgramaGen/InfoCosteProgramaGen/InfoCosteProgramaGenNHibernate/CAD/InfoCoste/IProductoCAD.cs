
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
}
}
