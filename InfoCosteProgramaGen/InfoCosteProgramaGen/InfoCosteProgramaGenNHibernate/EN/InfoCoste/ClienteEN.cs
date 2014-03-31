
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ClienteEN
{
/**
 *
 */

private string id;

/**
 *
 */

private string direccion;

/**
 *
 */

private int telefono;

/**
 *
 */

private string email;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente;

/**
 *
 */

private string nombreCompleto;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> ParteIntervencion {
        get { return parteIntervencion; } set { parteIntervencion = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> PedidoCliente {
        get { return pedidoCliente; } set { pedidoCliente = value;  }
}


public virtual string NombreCompleto {
        get { return nombreCompleto; } set { nombreCompleto = value;  }
}





public ClienteEN()
{
        parteIntervencion = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN>();
        pedidoCliente = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN>();
}



public ClienteEN(string id, string direccion, int telefono, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente, string nombreCompleto)
{
        this.init (id, direccion, telefono, email, parteIntervencion, pedidoCliente, nombreCompleto);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.Id, cliente.Direccion, cliente.Telefono, cliente.Email, cliente.ParteIntervencion, cliente.PedidoCliente, cliente.NombreCompleto);
}

private void init (string id, string direccion, int telefono, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente, string nombreCompleto)
{
        this.Id = id;


        this.Direccion = direccion;

        this.Telefono = telefono;

        this.Email = email;

        this.ParteIntervencion = parteIntervencion;

        this.PedidoCliente = pedidoCliente;

        this.NombreCompleto = nombreCompleto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
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
