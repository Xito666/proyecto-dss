

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
public partial class ReservaCEN
{
private IReservaCAD _IReservaCAD;

public ReservaCEN()
{
        this._IReservaCAD = new ReservaCAD ();
}

public ReservaCEN(IReservaCAD _IReservaCAD)
{
        this._IReservaCAD = _IReservaCAD;
}

public IReservaCAD get_IReservaCAD ()
{
        return this._IReservaCAD;
}

public int Reserva (int p_id, Nullable<DateTime> p_fecha, string p_datosPago, int p_pedidoCliente)
{
        ReservaEN reservaEN = null;
        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Id = p_id;

        reservaEN.Fecha = p_fecha;

        reservaEN.DatosPago = p_datosPago;


        if (p_pedidoCliente != -1) {
                reservaEN.PedidoCliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN ();
                reservaEN.PedidoCliente.Id = p_pedidoCliente;
        }

        //Call to ReservaCAD

        oid = _IReservaCAD.Reserva (reservaEN);
        return oid;
}

public System.Collections.Generic.IList<ReservaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> list = null;

        list = _IReservaCAD.LeerTodos (first, size);
        return list;
}
public ReservaEN LeerPorOID (int id)
{
        ReservaEN reservaEN = null;

        reservaEN = _IReservaCAD.LeerPorOID (id);
        return reservaEN;
}
}
}
