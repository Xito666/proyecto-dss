

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CEN.InfoCoste
{
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public int Factura (int p_id, Nullable<DateTime> p_fecha, string p_datosPago, int p_pedidoCliente, bool p_pagada)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_id;

        facturaEN.Fecha = p_fecha;

        facturaEN.DatosPago = p_datosPago;


        if (p_pedidoCliente != -1) {
                facturaEN.PedidoCliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN ();
                facturaEN.PedidoCliente.Id = p_pedidoCliente;
        }

        facturaEN.Pagada = p_pagada;

        //Call to FacturaCAD

        oid = _IFacturaCAD.Factura (facturaEN);
        return oid;
}

public System.Collections.Generic.IList<FacturaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.LeerTodos (first, size);
        return list;
}
public FacturaEN LeerPorOID (int id)
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.LeerPorOID (id);
        return facturaEN;
}

public void Borrar (int id)
{
        _IFacturaCAD.Borrar (id);
}
}
}
