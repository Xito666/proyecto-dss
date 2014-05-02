
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IReservaCAD
{
ReservaEN ReadOIDDefault (int id);


int Reserva (ReservaEN reserva);

System.Collections.Generic.IList<ReservaEN> LeerTodos (int first, int size);


ReservaEN LeerPorOID (int id);


void Borrar (int id);
}
}
