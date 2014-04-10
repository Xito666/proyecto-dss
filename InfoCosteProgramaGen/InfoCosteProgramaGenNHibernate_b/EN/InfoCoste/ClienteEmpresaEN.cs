
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ClienteEmpresaEN                   :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN


{
/**
 *
 */

private int numeroCuenta;





public virtual int NumeroCuenta {
        get { return numeroCuenta; } set { numeroCuenta = value;  }
}





public ClienteEmpresaEN() : base ()
{
}



public ClienteEmpresaEN(string id, int numeroCuenta, string direccion, int telefono, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente, string nombreCompleto)
{
        this.init (id, numeroCuenta, direccion, telefono, email, parteIntervencion, pedidoCliente, nombreCompleto);
}


public ClienteEmpresaEN(ClienteEmpresaEN clienteEmpresa)
{
        this.init (clienteEmpresa.Id, clienteEmpresa.NumeroCuenta, clienteEmpresa.Direccion, clienteEmpresa.Telefono, clienteEmpresa.Email, clienteEmpresa.ParteIntervencion, clienteEmpresa.PedidoCliente, clienteEmpresa.NombreCompleto);
}

private void init (string id, int numeroCuenta, string direccion, int telefono, string email, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> pedidoCliente, string nombreCompleto)
{
        this.Id = id;


        this.NumeroCuenta = numeroCuenta;

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
        ClienteEmpresaEN t = obj as ClienteEmpresaEN;
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
