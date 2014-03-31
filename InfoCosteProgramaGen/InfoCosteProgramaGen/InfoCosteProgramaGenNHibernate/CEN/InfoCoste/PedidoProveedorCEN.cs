

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
public partial class PedidoProveedorCEN
{
private IPedidoProveedorCAD _IPedidoProveedorCAD;

public PedidoProveedorCEN()
{
        this._IPedidoProveedorCAD = new PedidoProveedorCAD ();
}

public PedidoProveedorCEN(IPedidoProveedorCAD _IPedidoProveedorCAD)
{
        this._IPedidoProveedorCAD = _IPedidoProveedorCAD;
}

public IPedidoProveedorCAD get_IPedidoProveedorCAD ()
{
        return this._IPedidoProveedorCAD;
}

public void BorrarLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs)
{
        //Call to PedidoProveedorCAD

        _IPedidoProveedorCAD.BorrarLinea (p_PedidoProveedor_OID, p_lineaPedidoProveedor_OIDs);
}
public void AnyadirLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs)
{
        //Call to PedidoProveedorCAD

        _IPedidoProveedorCAD.AnyadirLinea (p_PedidoProveedor_OID, p_lineaPedidoProveedor_OIDs);
}
public void SetProveedor (int p_PedidoProveedor_OID, string p_proveedor_OID)
{
        //Call to PedidoProveedorCAD

        _IPedidoProveedorCAD.SetProveedor (p_PedidoProveedor_OID, p_proveedor_OID);
}
public int PedidoProveedor (int p_id, Nullable<DateTime> p_fecha, string p_proveedor)
{
        PedidoProveedorEN pedidoProveedorEN = null;
        int oid;

        //Initialized PedidoProveedorEN
        pedidoProveedorEN = new PedidoProveedorEN ();
        pedidoProveedorEN.Id = p_id;

        pedidoProveedorEN.Fecha = p_fecha;


        if (p_proveedor != null) {
                pedidoProveedorEN.Proveedor = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN ();
                pedidoProveedorEN.Proveedor.Id = p_proveedor;
        }

        //Call to PedidoProveedorCAD

        oid = _IPedidoProveedorCAD.PedidoProveedor (pedidoProveedorEN);
        return oid;
}

public System.Collections.Generic.IList<PedidoProveedorEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoProveedorEN> list = null;

        list = _IPedidoProveedorCAD.LeerTodos (first, size);
        return list;
}
public PedidoProveedorEN LeePorOID (int id)
{
        PedidoProveedorEN pedidoProveedorEN = null;

        pedidoProveedorEN = _IPedidoProveedorCAD.LeePorOID (id);
        return pedidoProveedorEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> LeePorFecha (Nullable<DateTime> fechaFiltro)
{
        return _IPedidoProveedorCAD.LeePorFecha (fechaFiltro);
}
}
}
