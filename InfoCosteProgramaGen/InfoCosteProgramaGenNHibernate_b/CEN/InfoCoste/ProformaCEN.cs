

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
public partial class ProformaCEN
{
private IProformaCAD _IProformaCAD;

public ProformaCEN()
{
        this._IProformaCAD = new ProformaCAD ();
}

public ProformaCEN(IProformaCAD _IProformaCAD)
{
        this._IProformaCAD = _IProformaCAD;
}

public IProformaCAD get_IProformaCAD ()
{
        return this._IProformaCAD;
}

public int Proforma (int p_id, Nullable<DateTime> p_fecha, string p_datosPago, int p_pedidoCliente)
{
        ProformaEN proformaEN = null;
        int oid;

        //Initialized ProformaEN
        proformaEN = new ProformaEN ();
        proformaEN.Id = p_id;

        proformaEN.Fecha = p_fecha;

        proformaEN.DatosPago = p_datosPago;


        if (p_pedidoCliente != -1) {
                proformaEN.PedidoCliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN ();
                proformaEN.PedidoCliente.Id = p_pedidoCliente;
        }

        //Call to ProformaCAD

        oid = _IProformaCAD.Proforma (proformaEN);
        return oid;
}

public System.Collections.Generic.IList<ProformaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProformaEN> list = null;

        list = _IProformaCAD.LeerTodos (first, size);
        return list;
}
public ProformaEN LeerPorOID (int id)
{
        ProformaEN proformaEN = null;

        proformaEN = _IProformaCAD.LeerPorOID (id);
        return proformaEN;
}
}
}
