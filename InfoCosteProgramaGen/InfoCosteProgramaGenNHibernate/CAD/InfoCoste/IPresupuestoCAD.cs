
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IPresupuestoCAD
{
PresupuestoEN ReadOIDDefault (int id);


int Presupuesto (PresupuestoEN presupuesto);

System.Collections.Generic.IList<PresupuestoEN> LeerTodos (int first, int size);


PresupuestoEN LeerPorOID (int id);


void Borrar (int id);
}
}
