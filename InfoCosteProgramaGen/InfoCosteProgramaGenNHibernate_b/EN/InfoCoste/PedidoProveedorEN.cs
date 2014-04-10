
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class PedidoProveedorEN
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

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proveedor;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> LineaPedidoProveedor {
        get { return lineaPedidoProveedor; } set { lineaPedidoProveedor = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}





public PedidoProveedorEN()
{
        lineaPedidoProveedor = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN>();
}



public PedidoProveedorEN(int id, Nullable<DateTime> fecha, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proveedor)
{
        this.init (id, fecha, lineaPedidoProveedor, proveedor);
}


public PedidoProveedorEN(PedidoProveedorEN pedidoProveedor)
{
        this.init (pedidoProveedor.Id, pedidoProveedor.Fecha, pedidoProveedor.LineaPedidoProveedor, pedidoProveedor.Proveedor);
}

private void init (int id, Nullable<DateTime> fecha, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN> lineaPedidoProveedor, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN proveedor)
{
        this.Id = id;


        this.Fecha = fecha;

        this.LineaPedidoProveedor = lineaPedidoProveedor;

        this.Proveedor = proveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoProveedorEN t = obj as PedidoProveedorEN;
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
