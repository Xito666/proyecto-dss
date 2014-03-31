
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IClienteEmpresaCAD
{
ClienteEmpresaEN ReadOIDDefault (string id);

void SetNumeroCuenta (ClienteEmpresaEN clienteEmpresa);



string ClienteEmpresa (ClienteEmpresaEN clienteEmpresa);

System.Collections.Generic.IList<ClienteEmpresaEN> LeerTodos (int first, int size);


ClienteEmpresaEN LeerPorOID (string id);
}
}
