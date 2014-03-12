
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ProformaEN                 :                           InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN


{
public ProformaEN() : base ()
{
}



public ProformaEN(int id, Nullable<DateTime> fecha, string datosPago, InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoCliente)
{
        this.init (id, fecha, datosPago, pedidoCliente);
}


public ProformaEN(ProformaEN proforma)
{
        this.init (proforma.Id, proforma.Fecha, proforma.DatosPago, proforma.PedidoCliente);
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
        ProformaEN t = obj as ProformaEN;
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
