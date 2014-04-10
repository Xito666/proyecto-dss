
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ProveedorEN
{
/**
 *
 */

private string id;

/**
 *
 */

private string nombre;

/**
 *
 */

private string direccion;

/**
 *
 */

private string email;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> pedidoProveedor;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> PedidoProveedor {
        get { return pedidoProveedor; } set { pedidoProveedor = value;  }
}





public ProveedorEN()
{
        pedidoProveedor = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN>();
}



public ProveedorEN(string id, string nombre, string direccion, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> pedidoProveedor)
{
        this.init (id, nombre, direccion, email, pedidoProveedor);
}


public ProveedorEN(ProveedorEN proveedor)
{
        this.init (proveedor.Id, proveedor.Nombre, proveedor.Direccion, proveedor.Email, proveedor.PedidoProveedor);
}

private void init (string id, string nombre, string direccion, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> pedidoProveedor)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Direccion = direccion;

        this.Email = email;

        this.PedidoProveedor = pedidoProveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProveedorEN t = obj as ProveedorEN;
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
