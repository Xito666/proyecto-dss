
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface ITrabajadorCAD
{
TrabajadorEN ReadOIDDefault (int id);

System.Collections.Generic.IList<TrabajadorEN> LeerTodos (int first, int size);


TrabajadorEN LeerPorOID (int id);



void SetPassword (TrabajadorEN trabajador);


void SetNombre (TrabajadorEN trabajador);




int Trabajador (TrabajadorEN trabajador);
}
}
