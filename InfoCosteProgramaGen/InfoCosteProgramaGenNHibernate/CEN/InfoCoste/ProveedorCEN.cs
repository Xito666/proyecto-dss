

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
public partial class ProveedorCEN
{
private IProveedorCAD _IProveedorCAD;

public ProveedorCEN()
{
        this._IProveedorCAD = new ProveedorCAD ();
}

public ProveedorCEN(IProveedorCAD _IProveedorCAD)
{
        this._IProveedorCAD = _IProveedorCAD;
}

public IProveedorCAD get_IProveedorCAD ()
{
        return this._IProveedorCAD;
}

public string Proveedor (string p_id, string p_nombre, string p_direccion, string p_email)
{
        ProveedorEN proveedorEN = null;
        string oid;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_id;

        proveedorEN.Nombre = p_nombre;

        proveedorEN.Direccion = p_direccion;

        proveedorEN.Email = p_email;

        //Call to ProveedorCAD

        oid = _IProveedorCAD.Proveedor (proveedorEN);
        return oid;
}

public System.Collections.Generic.IList<ProveedorEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> list = null;

        list = _IProveedorCAD.LeerTodos (first, size);
        return list;
}
public ProveedorEN LeerPorOID (string id)
{
        ProveedorEN proveedorEN = null;

        proveedorEN = _IProveedorCAD.LeerPorOID (id);
        return proveedorEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN> LeerPorNombre (string nombreFiltro)
{
        return _IProveedorCAD.LeerPorNombre (nombreFiltro);
}

public void Borrar(string id)
{
    _IProveedorCAD.Borrar(id);
}
}
}
