
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ReservaEN                  :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN


{
public ReservaEN() : base ()
{
}



public ReservaEN(int id, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.init (id, fecha, datosPago, pedidoCliente);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (reserva.Id, reserva.Fecha, reserva.DatosPago, reserva.PedidoCliente);
}

private void init (int id, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.Id = id;


        this.Fecha = fecha;

        this.DatosPago = datosPago;

        this.PedidoCliente = pedidoCliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
