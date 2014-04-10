
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class LineaPedidoEN
{
/**
 *
 */

private int id;

/**
 *
 */

private int numero;

/**
 *
 */

private int cantidad;

/**
 *
 */

private double descuento;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual int Numero {
        get { return numero; } set { numero = value;  }
}


public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}


public virtual double Descuento {
        get { return descuento; } set { descuento = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN PedidoCliente {
        get { return pedidoCliente; } set { pedidoCliente = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int numero, int cantidad, double descuento, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto)
{
        this.init (id, numero, cantidad, descuento, pedidoCliente, producto);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (lineaPedido.Id, lineaPedido.Numero, lineaPedido.Cantidad, lineaPedido.Descuento, lineaPedido.PedidoCliente, lineaPedido.Producto);
}

private void init (int id, int numero, int cantidad, double descuento, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto)
{
        this.Id = id;


        this.Numero = numero;

        this.Cantidad = cantidad;

        this.Descuento = descuento;

        this.PedidoCliente = pedidoCliente;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
