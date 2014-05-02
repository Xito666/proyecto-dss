
using System;
using System.Text;
using InfoCosteProgramaGenNHibernate.CEN.InfoCoste;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.Exceptions;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial class PresupuestoCAD : BasicCAD, IPresupuestoCAD
{
public PresupuestoCAD() : base ()
{
}

public PresupuestoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PresupuestoEN ReadOIDDefault (int id)
{
        PresupuestoEN presupuestoEN = null;

        try
        {
                SessionInitializeTransaction ();
                presupuestoEN = (PresupuestoEN)session.Get (typeof(PresupuestoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PresupuestoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return presupuestoEN;
}


public int Presupuesto (PresupuestoEN presupuesto)
{
        try
        {
                SessionInitializeTransaction ();
                if (presupuesto.PedidoCliente != null) {
                        presupuesto.PedidoCliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN), presupuesto.PedidoCliente.Id);

                        presupuesto.PedidoCliente.TipoFactura = presupuesto;
                }

                session.Save (presupuesto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PresupuestoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return presupuesto.Id;
}

public System.Collections.Generic.IList<PresupuestoEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PresupuestoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PresupuestoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PresupuestoEN>();
                else
                        result = session.CreateCriteria (typeof(PresupuestoEN)).List<PresupuestoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PresupuestoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public PresupuestoEN LeerPorOID (int id)
{
        PresupuestoEN presupuestoEN = null;

        try
        {
                SessionInitializeTransaction ();
                presupuestoEN = (PresupuestoEN)session.Get (typeof(PresupuestoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PresupuestoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return presupuestoEN;
}

public void Borrar (int id)
{
        try
        {
                SessionInitializeTransaction ();
                PresupuestoEN presupuestoEN = (PresupuestoEN)session.Load (typeof(PresupuestoEN), id);
                session.Delete (presupuestoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PresupuestoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
