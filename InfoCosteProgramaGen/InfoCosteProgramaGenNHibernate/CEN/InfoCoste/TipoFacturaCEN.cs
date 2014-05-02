

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
public partial class TipoFacturaCEN
{
private ITipoFacturaCAD _ITipoFacturaCAD;

public TipoFacturaCEN()
{
        this._ITipoFacturaCAD = new TipoFacturaCAD ();
}

public TipoFacturaCEN(ITipoFacturaCAD _ITipoFacturaCAD)
{
        this._ITipoFacturaCAD = _ITipoFacturaCAD;
}

public ITipoFacturaCAD get_ITipoFacturaCAD ()
{
        return this._ITipoFacturaCAD;
}

public int TipoFactura (int p_id, Nullable<DateTime> p_fecha, string p_datosPago, int p_pedidoCliente)
{
        TipoFacturaEN tipoFacturaEN = null;
        int oid;

        //Initialized TipoFacturaEN
        tipoFacturaEN = new TipoFacturaEN ();
        tipoFacturaEN.Id = p_id;

        tipoFacturaEN.Fecha = p_fecha;

        tipoFacturaEN.DatosPago = p_datosPago;


        if (p_pedidoCliente != -1) {
                tipoFacturaEN.PedidoCliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN ();
                tipoFacturaEN.PedidoCliente.Id = p_pedidoCliente;
        }

        //Call to TipoFacturaCAD

        oid = _ITipoFacturaCAD.TipoFactura (tipoFacturaEN);
        return oid;
}

public System.Collections.Generic.IList<TipoFacturaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<TipoFacturaEN> list = null;

        list = _ITipoFacturaCAD.LeerTodos (first, size);
        return list;
}
public TipoFacturaEN LeerPorOID (int id)
{
        TipoFacturaEN tipoFacturaEN = null;

        tipoFacturaEN = _ITipoFacturaCAD.LeerPorOID (id);
        return tipoFacturaEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN> LeerPorFecha (Nullable<DateTime> fechaFiltro)
{
        return _ITipoFacturaCAD.LeerPorFecha (fechaFiltro);
}
public void Borrar (int id)
{
        _ITipoFacturaCAD.Borrar (id);
}
}
}
