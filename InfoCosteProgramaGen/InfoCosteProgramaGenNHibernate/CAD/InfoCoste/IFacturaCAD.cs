
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id);


void SetPagada (FacturaEN factura);


int Factura (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> LeerTodos (int first, int size);


FacturaEN LeerPorOID (int id);



void Borrar (int id);
}
}
