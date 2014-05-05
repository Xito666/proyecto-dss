

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
public partial class ClienteEmpresaCEN
{
private IClienteEmpresaCAD _IClienteEmpresaCAD;

public ClienteEmpresaCEN()
{
        this._IClienteEmpresaCAD = new ClienteEmpresaCAD ();
}

public ClienteEmpresaCEN(IClienteEmpresaCAD _IClienteEmpresaCAD)
{
        this._IClienteEmpresaCAD = _IClienteEmpresaCAD;
}

public IClienteEmpresaCAD get_IClienteEmpresaCAD ()
{
        return this._IClienteEmpresaCAD;
}

public string ClienteEmpresa (string p_id, string p_direccion, int p_telefono, string p_email, string p_nombreCompleto, string p_numeroCuenta)
{
        ClienteEmpresaEN clienteEmpresaEN = null;
        string oid;

        //Initialized ClienteEmpresaEN
        clienteEmpresaEN = new ClienteEmpresaEN ();
        clienteEmpresaEN.Id = p_id;

        clienteEmpresaEN.Direccion = p_direccion;

        clienteEmpresaEN.Telefono = p_telefono;

        clienteEmpresaEN.Email = p_email;

        clienteEmpresaEN.NombreCompleto = p_nombreCompleto;

        clienteEmpresaEN.NumeroCuenta = p_numeroCuenta;

        //Call to ClienteEmpresaCAD

        oid = _IClienteEmpresaCAD.ClienteEmpresa (clienteEmpresaEN);
        return oid;
}

public System.Collections.Generic.IList<ClienteEmpresaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEmpresaEN> list = null;

        list = _IClienteEmpresaCAD.LeerTodos (first, size);
        return list;
}
public ClienteEmpresaEN LeerPorOID (string id)
{
        ClienteEmpresaEN clienteEmpresaEN = null;

        clienteEmpresaEN = _IClienteEmpresaCAD.LeerPorOID (id);
        return clienteEmpresaEN;
}
}
}
