

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
public partial class ParteIntervencionCEN
{
private IParteIntervencionCAD _IParteIntervencionCAD;

public ParteIntervencionCEN()
{
        this._IParteIntervencionCAD = new ParteIntervencionCAD ();
}

public ParteIntervencionCEN(IParteIntervencionCAD _IParteIntervencionCAD)
{
        this._IParteIntervencionCAD = _IParteIntervencionCAD;
}

public IParteIntervencionCAD get_IParteIntervencionCAD ()
{
        return this._IParteIntervencionCAD;
}

public int ParteIntervencion (int p_id, Nullable<DateTime> p_fecha, string p_datosPc, string p_accionesRealizadas, int p_trabajador, string p_cliente)
{
        ParteIntervencionEN parteIntervencionEN = null;
        int oid;

        //Initialized ParteIntervencionEN
        parteIntervencionEN = new ParteIntervencionEN ();
        parteIntervencionEN.Id = p_id;

        parteIntervencionEN.Fecha = p_fecha;

        parteIntervencionEN.DatosPc = p_datosPc;

        parteIntervencionEN.AccionesRealizadas = p_accionesRealizadas;


        if (p_trabajador != -1) {
                parteIntervencionEN.Trabajador = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN ();
                parteIntervencionEN.Trabajador.Id = p_trabajador;
        }


        if (p_cliente != null) {
                parteIntervencionEN.Cliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN ();
                parteIntervencionEN.Cliente.Id = p_cliente;
        }

        //Call to ParteIntervencionCAD

        oid = _IParteIntervencionCAD.ParteIntervencion (parteIntervencionEN);
        return oid;
}

public System.Collections.Generic.IList<ParteIntervencionEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ParteIntervencionEN> list = null;

        list = _IParteIntervencionCAD.LeerTodos (first, size);
        return list;
}
public ParteIntervencionEN LeerPorOID (int id)
{
        ParteIntervencionEN parteIntervencionEN = null;

        parteIntervencionEN = _IParteIntervencionCAD.LeerPorOID (id);
        return parteIntervencionEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> LeerPorFecha (Nullable<DateTime> fechaFiltro)
{
        return _IParteIntervencionCAD.LeerPorFecha (fechaFiltro);
}
}
}
