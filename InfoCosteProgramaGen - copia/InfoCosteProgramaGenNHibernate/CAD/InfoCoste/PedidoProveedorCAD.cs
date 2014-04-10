
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
public partial class PedidoProveedorCAD : BasicCAD, IPedidoProveedorCAD
{
public PedidoProveedorCAD() : base ()
{
}

public PedidoProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoProveedorEN ReadOIDDefault (int id)
{
        PedidoProveedorEN pedidoProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoProveedorEN = (PedidoProveedorEN)session.Get (typeof(PedidoProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoProveedorEN;
}


public void BorrarLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedorEN = null;
                pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), p_PedidoProveedor_OID);

                InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN lineaPedidoProveedorENAux = null;
                if (pedidoProveedorEN.LineaPedidoProveedor != null) {
                        foreach (string item in p_lineaPedidoProveedor_OIDs) {
                                lineaPedidoProveedorENAux = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN), item);
                                if (pedidoProveedorEN.LineaPedidoProveedor.Contains (lineaPedidoProveedorENAux) == true) {
                                        pedidoProveedorEN.LineaPedidoProveedor.Remove (lineaPedidoProveedorENAux);
                                        lineaPedidoProveedorENAux.PedidoProveedor = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineaPedidoProveedor_OIDs you are trying to unrelationer, doesn't exist in PedidoProveedorEN");
                        }
                }

                session.Update (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AnyadirLinea (int p_PedidoProveedor_OID, System.Collections.Generic.IList<string> p_lineaPedidoProveedor_OIDs)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedorEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), p_PedidoProveedor_OID);
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN lineaPedidoProveedorENAux = null;
                if (pedidoProveedorEN.LineaPedidoProveedor == null) {
                        pedidoProveedorEN.LineaPedidoProveedor = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN>();
                }

                foreach (string item in p_lineaPedidoProveedor_OIDs) {
                        lineaPedidoProveedorENAux = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN ();
                        lineaPedidoProveedorENAux = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN), item);
                        lineaPedidoProveedorENAux.PedidoProveedor = pedidoProveedorEN;

                        pedidoProveedorEN.LineaPedidoProveedor.Add (lineaPedidoProveedorENAux);
                }


                session.Update (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void SetProveedor (int p_PedidoProveedor_OID, string p_proveedor_OID)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN pedidoProveedorEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), p_PedidoProveedor_OID);
                pedidoProveedorEN.Proveedor = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN), p_proveedor_OID);

                pedidoProveedorEN.Proveedor.PedidoProveedor.Add (pedidoProveedorEN);



                session.Update (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public int PedidoProveedor (PedidoProveedorEN pedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedidoProveedor.Proveedor != null) {
                        pedidoProveedor.Proveedor = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProveedorEN), pedidoProveedor.Proveedor.Id);

                        pedidoProveedor.Proveedor.PedidoProveedor.Add (pedidoProveedor);
                }

                session.Save (pedidoProveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoProveedor.Id;
}

public System.Collections.Generic.IList<PedidoProveedorEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoProveedorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoProveedorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoProveedorEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoProveedorEN)).List<PedidoProveedorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public PedidoProveedorEN LeePorOID (int id)
{
        PedidoProveedorEN pedidoProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoProveedorEN = (PedidoProveedorEN)session.Get (typeof(PedidoProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoProveedorEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> LeePorFecha (Nullable<DateTime> fechaFiltro)
{
        System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoProveedorEN self where FROM PedidoProveedorEN p where p.fecha = :fechaFiltro";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoProveedorENleePorFechaHQL");
                query.SetParameter ("fechaFiltro", fechaFiltro);

                result = query.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoProveedorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
