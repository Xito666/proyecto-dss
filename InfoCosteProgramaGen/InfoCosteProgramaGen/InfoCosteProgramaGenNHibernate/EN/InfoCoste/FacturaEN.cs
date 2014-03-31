
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class FacturaEN                  :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN


{
/**
 *
 */

private bool pagada;





public virtual bool Pagada {
        get { return pagada; } set { pagada = value;  }
}





public FacturaEN() : base ()
{
}



public FacturaEN(int id, bool pagada, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.init (id, pagada, fecha, datosPago, pedidoCliente);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.Pagada, factura.Fecha, factura.DatosPago, factura.PedidoCliente);
}

private void init (int id, bool pagada, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.Id = id;


        this.Pagada = pagada;

        this.Fecha = fecha;

        this.DatosPago = datosPago;

        this.PedidoCliente = pedidoCliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
