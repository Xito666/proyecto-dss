

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
public partial class PresupuestoCEN
{
private IPresupuestoCAD _IPresupuestoCAD;

public PresupuestoCEN()
{
        this._IPresupuestoCAD = new PresupuestoCAD ();
}

public PresupuestoCEN(IPresupuestoCAD _IPresupuestoCAD)
{
        this._IPresupuestoCAD = _IPresupuestoCAD;
}

public IPresupuestoCAD get_IPresupuestoCAD ()
{
        return this._IPresupuestoCAD;
}

public int Presupuesto (int p_id, Nullable<DateTime> p_fecha, string p_datosPago, int p_pedidoCliente)
{
        PresupuestoEN presupuestoEN = null;
        int oid;

        //Initialized PresupuestoEN
        presupuestoEN = new PresupuestoEN ();
        presupuestoEN.Id = p_id;

        presupuestoEN.Fecha = p_fecha;

        presupuestoEN.DatosPago = p_datosPago;


        if (p_pedidoCliente != -1) {
                presupuestoEN.PedidoCliente = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN ();
                presupuestoEN.PedidoCliente.Id = p_pedidoCliente;
        }

        //Call to PresupuestoCAD

        oid = _IPresupuestoCAD.Presupuesto (presupuestoEN);
        return oid;
}

public System.Collections.Generic.IList<PresupuestoEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PresupuestoEN> list = null;

        list = _IPresupuestoCAD.LeerTodos (first, size);
        return list;
}
public PresupuestoEN LeerPorOID (int id)
{
        PresupuestoEN presupuestoEN = null;

        presupuestoEN = _IPresupuestoCAD.LeerPorOID (id);
        return presupuestoEN;
}

public void Borrar (int id)
{
        _IPresupuestoCAD.Borrar (id);
}
}
}
