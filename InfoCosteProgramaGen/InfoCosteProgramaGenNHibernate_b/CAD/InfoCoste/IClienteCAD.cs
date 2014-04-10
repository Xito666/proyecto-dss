
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string id);

void SetEmail (ClienteEN cliente);


void SetTelefono (ClienteEN cliente);


void SetDireccion (ClienteEN cliente);






string Cliente (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> LeerTodos (int first, int size);


ClienteEN LeerPorOID (string id);



void SetNombre (ClienteEN cliente);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN> LeerPorNombre (string nombreFiltro);


void Borrar (string id);
}
}
