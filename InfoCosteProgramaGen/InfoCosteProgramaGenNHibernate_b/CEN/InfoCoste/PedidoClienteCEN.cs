

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
public partial class PedidoClienteCEN
{
private IPedidoClienteCAD _IPedidoClienteCAD;

public PedidoClienteCEN()
{
        this._IPedidoClienteCAD = new PedidoClienteCAD ();
}

public PedidoClienteCEN(IPedidoClienteCAD _IPedidoClienteCAD)
{
        this._IPedidoClienteCAD = _IPedidoClienteCAD;
}

public IPedidoClienteCAD get_IPedidoClienteCAD ()
{
        return this._IPedidoClienteCAD;
}

public void Facturar (int p_PedidoCliente_OID, int p_tipoFactura_OID)
{
        //Call to PedidoClienteCAD

        _IPedidoClienteCAD.Facturar (p_PedidoCliente_OID, p_tipoFactura_OID);
}
public int PedidoCliente (int p_id, Nullable<DateTime> p_fecha, string p_cliente)
{
        PedidoClienteEN pedidoClienteEN = null;
        int oid;

        //Initialized PedidoClienteEN
        pedidoClienteEN = new PedidoClienteEN ();
        pedidoClienteEN.Id = p_id;

        pedidoClienteEN.Fecha = p_fecha;


        if (p_cliente != null) {
                pedidoClienteEN.Cliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN ();
                pedidoClienteEN.Cliente.Id = p_cliente;
        }

        //Call to PedidoClienteCAD

        oid = _IPedidoClienteCAD.PedidoCliente (pedidoClienteEN);
        return oid;
}

public System.Collections.Generic.IList<PedidoClienteEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoClienteEN> list = null;

        list = _IPedidoClienteCAD.LeerTodos (first, size);
        return list;
}
public PedidoClienteEN LeerPorOID (int id)
{
        PedidoClienteEN pedidoClienteEN = null;

        pedidoClienteEN = _IPedidoClienteCAD.LeerPorOID (id);
        return pedidoClienteEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> LeerPorFecha (Nullable<DateTime> fechaFilter)
{
        return _IPedidoClienteCAD.LeerPorFecha (fechaFilter);
}
}
}
