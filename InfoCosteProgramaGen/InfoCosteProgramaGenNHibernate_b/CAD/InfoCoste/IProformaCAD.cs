
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IProformaCAD
{
ProformaEN ReadOIDDefault (int id);


int Proforma (ProformaEN proforma);

System.Collections.Generic.IList<ProformaEN> LeerTodos (int first, int size);


ProformaEN LeerPorOID (int id);
}
}
