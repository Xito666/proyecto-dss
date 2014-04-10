
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class PresupuestoEN              :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN


{
public PresupuestoEN() : base ()
{
}



public PresupuestoEN(int id, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.init (id, fecha, datosPago, pedidoCliente);
}


public PresupuestoEN(PresupuestoEN presupuesto)
{
        this.init (presupuesto.Id, presupuesto.Fecha, presupuesto.DatosPago, presupuesto.PedidoCliente);
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
        PresupuestoEN t = obj as PresupuestoEN;
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
