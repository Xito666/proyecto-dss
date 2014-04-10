

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
public partial class ClienteParticularCEN
{
private IClienteParticularCAD _IClienteParticularCAD;

public ClienteParticularCEN()
{
        this._IClienteParticularCAD = new ClienteParticularCAD ();
}

public ClienteParticularCEN(IClienteParticularCAD _IClienteParticularCAD)
{
        this._IClienteParticularCAD = _IClienteParticularCAD;
}

public IClienteParticularCAD get_IClienteParticularCAD ()
{
        return this._IClienteParticularCAD;
}

public string ClienteParticular (string p_id, string p_direccion, int p_telefono, string p_email, string p_nombreCompleto)
{
        ClienteParticularEN clienteParticularEN = null;
        string oid;

        //Initialized ClienteParticularEN
        clienteParticularEN = new ClienteParticularEN ();
        clienteParticularEN.Id = p_id;

        clienteParticularEN.Direccion = p_direccion;

        clienteParticularEN.Telefono = p_telefono;

        clienteParticularEN.Email = p_email;

        clienteParticularEN.NombreCompleto = p_nombreCompleto;

        //Call to ClienteParticularCAD

        oid = _IClienteParticularCAD.ClienteParticular (clienteParticularEN);
        return oid;
}

public System.Collections.Generic.IList<ClienteParticularEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteParticularEN> list = null;

        list = _IClienteParticularCAD.LeerTodos (first, size);
        return list;
}
public ClienteParticularEN LeerPorOID (string id)
{
        ClienteParticularEN clienteParticularEN = null;

        clienteParticularEN = _IClienteParticularCAD.LeerPorOID (id);
        return clienteParticularEN;
}
}
}
