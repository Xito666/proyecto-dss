

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
public partial class TrabajadorCEN
{
private ITrabajadorCAD _ITrabajadorCAD;

public TrabajadorCEN()
{
        this._ITrabajadorCAD = new TrabajadorCAD ();
}

public TrabajadorCEN(ITrabajadorCAD _ITrabajadorCAD)
{
        this._ITrabajadorCAD = _ITrabajadorCAD;
}

public ITrabajadorCAD get_ITrabajadorCAD ()
{
        return this._ITrabajadorCAD;
}

public System.Collections.Generic.IList<TrabajadorEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<TrabajadorEN> list = null;

        list = _ITrabajadorCAD.LeerTodos (first, size);
        return list;
}
public TrabajadorEN LeerPorOID (int id)
{
        TrabajadorEN trabajadorEN = null;

        trabajadorEN = _ITrabajadorCAD.LeerPorOID (id);
        return trabajadorEN;
}

public int Trabajador (int p_id, string p_nombre, string p_password)
{
        TrabajadorEN trabajadorEN = null;
        int oid;

        //Initialized TrabajadorEN
        trabajadorEN = new TrabajadorEN ();
        trabajadorEN.Id = p_id;

        trabajadorEN.Nombre = p_nombre;

        trabajadorEN.Password = p_password;

        //Call to TrabajadorCAD

        oid = _ITrabajadorCAD.Trabajador (trabajadorEN);
        return oid;
}

public void Borrar (int id)
{
        _ITrabajadorCAD.Borrar (id);
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> LeerPorNombre (string nombreFiltro)
{
        return _ITrabajadorCAD.LeerPorNombre (nombreFiltro);
}
}
}
