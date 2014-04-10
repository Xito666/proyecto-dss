

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CEN.InfoCoste
{
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string Cliente (string p_id, string p_direccion, int p_telefono, string p_email, string p_nombreCompleto)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Id = p_id;

        clienteEN.Direccion = p_direccion;

        clienteEN.Telefono = p_telefono;

        clienteEN.Email = p_email;

        clienteEN.NombreCompleto = p_nombreCompleto;

        //Call to ClienteCAD

        oid = _IClienteCAD.Cliente (clienteEN);
        return oid;
}

public System.Collections.Generic.IList<ClienteEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteCAD.LeerTodos (first, size);
        return list;
}
public ClienteEN LeerPorOID (string id)
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.LeerPorOID (id);
        return clienteEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN> LeerPorNombre (string nombreFiltro)
{
        return _IClienteCAD.LeerPorNombre (nombreFiltro);
}
public void Borrar (string id)
{
        _IClienteCAD.Borrar (id);
}
}
}
