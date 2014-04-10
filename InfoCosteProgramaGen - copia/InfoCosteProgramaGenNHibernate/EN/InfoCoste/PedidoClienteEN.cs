
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class PedidoClienteEN
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

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN tipoFactura;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN TipoFactura {
        get { return tipoFactura; } set { tipoFactura = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}





public PedidoClienteEN()
{
        lineaPedido = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN>();
}



public PedidoClienteEN(int id, Nullable<DateTime> fecha, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente, InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN tipoFactura, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido)
{
        this.init (id, fecha, cliente, tipoFactura, lineaPedido);
}


public PedidoClienteEN(PedidoClienteEN pedidoCliente)
{
        this.init (pedidoCliente.Id, pedidoCliente.Fecha, pedidoCliente.Cliente, pedidoCliente.TipoFactura, pedidoCliente.LineaPedido);
}

private void init (int id, Nullable<DateTime> fecha, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente, InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN tipoFactura, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Cliente = cliente;

        this.TipoFactura = tipoFactura;

        this.LineaPedido = lineaPedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoClienteEN t = obj as PedidoClienteEN;
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
