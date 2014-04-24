
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
public partial class TipoFacturaCAD : BasicCAD, ITipoFacturaCAD
{
public TipoFacturaCAD() : base ()
{
}

public TipoFacturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public TipoFacturaEN ReadOIDDefault (int id)
{
        TipoFacturaEN tipoFacturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                tipoFacturaEN = (TipoFacturaEN)session.Get (typeof(TipoFacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tipoFacturaEN;
}


public void SetDatosPago (TipoFacturaEN tipoFactura)
{
        try
        {
                SessionInitializeTransaction ();
                TipoFacturaEN tipoFacturaEN = (TipoFacturaEN)session.Load (typeof(TipoFacturaEN), tipoFactura.Id);

                tipoFacturaEN.DatosPago = tipoFactura.DatosPago;

                session.Update (tipoFacturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void SetFecha (TipoFacturaEN tipoFactura)
{
        try
        {
                SessionInitializeTransaction ();
                TipoFacturaEN tipoFacturaEN = (TipoFacturaEN)session.Load (typeof(TipoFacturaEN), tipoFactura.Id);

                tipoFacturaEN.Fecha = tipoFactura.Fecha;

                session.Update (tipoFacturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public int TipoFactura (TipoFacturaEN tipoFactura)
{
        try
        {
                SessionInitializeTransaction ();
                if (tipoFactura.PedidoCliente != null) {
                        tipoFactura.PedidoCliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN), tipoFactura.PedidoCliente.Id);

                        tipoFactura.PedidoCliente.TipoFactura = tipoFactura;
                }

                session.Save (tipoFactura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tipoFactura.Id;
}

public System.Collections.Generic.IList<TipoFacturaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<TipoFacturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TipoFacturaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TipoFacturaEN>();
                else
                        result = session.CreateCriteria (typeof(TipoFacturaEN)).List<TipoFacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public TipoFacturaEN LeerPorOID (int id)
{
        TipoFacturaEN tipoFacturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                tipoFacturaEN = (TipoFacturaEN)session.Get (typeof(TipoFacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tipoFacturaEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN> LeerPorFecha (Nullable<DateTime> fechaFiltro)
{
        System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TipoFacturaEN self where FROM TipoFacturaEN t where t.Fecha LIKE '%:fechaFiltro%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TipoFacturaENleerPorFechaHQL");
                query.SetParameter ("fechaFiltro", fechaFiltro);

                result = query.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TipoFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
