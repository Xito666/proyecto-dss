
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ProductoEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private double precio;

/**
 *
 */

private string familia;

/**
 *
 */

private int stock;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual double Precio {
        get { return precio; } set { precio = value;  }
}


public virtual string Familia {
        get { return familia; } set { familia = value;  }
}


public virtual int Stock {
        get { return stock; } set { stock = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> LineaPedidoProveedor {
        get { return lineaPedidoProveedor; } set { lineaPedidoProveedor = value;  }
}





public ProductoEN()
{
        lineaPedido = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN>();
        lineaPedidoProveedor = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN>();
}



public ProductoEN(int id, string nombre, string descripcion, double precio, string familia, int stock, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor)
{
        this.init (id, nombre, descripcion, precio, familia, stock, lineaPedido, lineaPedidoProveedor);
}


public ProductoEN(ProductoEN producto)
{
        this.init (producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Familia, producto.Stock, producto.LineaPedido, producto.LineaPedidoProveedor);
}

private void init (int id, string nombre, string descripcion, double precio, string familia, int stock, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Precio = precio;

        this.Familia = familia;

        this.Stock = stock;

        this.LineaPedido = lineaPedido;

        this.LineaPedidoProveedor = lineaPedidoProveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
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
