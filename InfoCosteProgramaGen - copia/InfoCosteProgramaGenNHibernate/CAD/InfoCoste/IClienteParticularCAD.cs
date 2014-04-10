
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IClienteParticularCAD
{
ClienteParticularEN ReadOIDDefault (string id);

string ClienteParticular (ClienteParticularEN clienteParticular);

System.Collections.Generic.IList<ClienteParticularEN> LeerTodos (int first, int size);


ClienteParticularEN LeerPorOID (string id);
}
}
