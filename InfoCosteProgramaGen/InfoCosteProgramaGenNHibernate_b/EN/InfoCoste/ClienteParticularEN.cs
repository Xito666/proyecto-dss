
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ClienteParticularEN                :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN


{
public ClienteParticularEN() : base ()
{
}



public ClienteParticularEN(string id, string direccion, int telefono, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente, string nombreCompleto)
{
        this.init (id, direccion, telefono, email, parteIntervencion, pedidoCliente, nombreCompleto);
}


public ClienteParticularEN(ClienteParticularEN clienteParticular)
{
        this.init (clienteParticular.Id, clienteParticular.Direccion, clienteParticular.Telefono, clienteParticular.Email, clienteParticular.ParteIntervencion, clienteParticular.PedidoCliente, clienteParticular.NombreCompleto);
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
        ClienteParticularEN t = obj as ClienteParticularEN;
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
