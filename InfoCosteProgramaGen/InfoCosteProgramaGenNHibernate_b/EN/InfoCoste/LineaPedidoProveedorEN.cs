
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class LineaPedidoProveedorEN
{
/**
 *
 */

private string id;

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

private double precioCoste;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedor;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto;





public virtual string Id {
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


public virtual double PrecioCoste {
        get { return precioCoste; } set { precioCoste = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN PedidoProveedor {
        get { return pedidoProveedor; } set { pedidoProveedor = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public LineaPedidoProveedorEN()
{
}



public LineaPedidoProveedorEN(string id, int numero, int cantidad, double descuento, double precioCoste, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedor, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto)
{
        this.init (id, numero, cantidad, descuento, precioCoste, pedidoProveedor, producto);
}


public LineaPedidoProveedorEN(LineaPedidoProveedorEN lineaPedidoProveedor)
{
        this.init (lineaPedidoProveedor.Id, lineaPedidoProveedor.Numero, lineaPedidoProveedor.Cantidad, lineaPedidoProveedor.Descuento, lineaPedidoProveedor.PrecioCoste, lineaPedidoProveedor.PedidoProveedor, lineaPedidoProveedor.Producto);
}

private void init (string id, int numero, int cantidad, double descuento, double precioCoste, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedor, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN producto)
{
        this.Id = id;


        this.Numero = numero;

        this.Cantidad = cantidad;

        this.Descuento = descuento;

        this.PrecioCoste = precioCoste;

        this.PedidoProveedor = pedidoProveedor;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoProveedorEN t = obj as LineaPedidoProveedorEN;
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
