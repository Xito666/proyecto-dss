
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class TipoFacturaEN
{
/**
 *
 */

private int id;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private string datosPago;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual string DatosPago {
        get { return datosPago; } set { datosPago = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN PedidoCliente {
        get { return pedidoCliente; } set { pedidoCliente = value;  }
}





public TipoFacturaEN()
{
}



public TipoFacturaEN(int id, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.init (id, fecha, datosPago, pedidoCliente);
}


public TipoFacturaEN(TipoFacturaEN tipoFactura)
{
        this.init (tipoFactura.Id, tipoFactura.Fecha, tipoFactura.DatosPago, tipoFactura.PedidoCliente);
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
        TipoFacturaEN t = obj as TipoFacturaEN;
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
