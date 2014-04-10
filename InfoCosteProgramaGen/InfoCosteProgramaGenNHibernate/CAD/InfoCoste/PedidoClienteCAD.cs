
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
public partial class PedidoClienteCAD : BasicCAD, IPedidoClienteCAD
{
public PedidoClienteCAD() : base ()
{
}

public PedidoClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoClienteEN ReadOIDDefault (int id)
{
        PedidoClienteEN pedidoClienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoClienteEN = (PedidoClienteEN)session.Get (typeof(PedidoClienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoClienteEN;
}


public void Facturar (int p_PedidoCliente_OID, int p_tipoFactura_OID)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoClienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoClienteEN = (PedidoClienteEN)session.Load (typeof(PedidoClienteEN), p_PedidoCliente_OID);
                pedidoClienteEN.TipoFactura = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN), p_tipoFactura_OID);

                pedidoClienteEN.TipoFactura.PedidoCliente = pedidoClienteEN;




                session.Update (pedidoClienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void BorrarLinea (int p_PedidoCliente_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoClienteEN = null;
                pedidoClienteEN = (PedidoClienteEN)session.Load (typeof(PedidoClienteEN), p_PedidoCliente_OID);

                InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoClienteEN.LineaPedido != null) {
                        foreach (int item in p_lineaPedido_OIDs) {
                                lineaPedidoENAux = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN), item);
                                if (pedidoClienteEN.LineaPedido.Contains (lineaPedidoENAux) == true) {
                                        pedidoClienteEN.LineaPedido.Remove (lineaPedidoENAux);
                                        lineaPedidoENAux.PedidoCliente = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineaPedido_OIDs you are trying to unrelationer, doesn't exist in PedidoClienteEN");
                        }
                }

                session.Update (pedidoClienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AnyadirLinea (int p_PedidoCliente_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoClienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoClienteEN = (PedidoClienteEN)session.Load (typeof(PedidoClienteEN), p_PedidoCliente_OID);
                InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoClienteEN.LineaPedido == null) {
                        pedidoClienteEN.LineaPedido = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN>();
                }

                foreach (int item in p_lineaPedido_OIDs) {
                        lineaPedidoENAux = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN ();
                        lineaPedidoENAux = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoEN), item);
                        lineaPedidoENAux.PedidoCliente = pedidoClienteEN;

                        pedidoClienteEN.LineaPedido.Add (lineaPedidoENAux);
                }


                session.Update (pedidoClienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void SetCliente (int p_PedidoCliente_OID, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN nuevoCliente)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN pedidoClienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoClienteEN = (PedidoClienteEN)session.Load (typeof(PedidoClienteEN), p_PedidoCliente_OID);
                pedidoClienteEN.Cliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN), nuevoCliente);

                pedidoClienteEN.Cliente.PedidoCliente.Add (pedidoClienteEN);



                session.Update (pedidoClienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public int PedidoCliente (PedidoClienteEN pedidoCliente)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedidoCliente.Cliente != null) {
                        pedidoCliente.Cliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN), pedidoCliente.Cliente.Id);

                        pedidoCliente.Cliente.PedidoCliente.Add (pedidoCliente);
                }

                session.Save (pedidoCliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoCliente.Id;
}

public System.Collections.Generic.IList<PedidoClienteEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoClienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoClienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoClienteEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoClienteEN)).List<PedidoClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public PedidoClienteEN LeerPorOID (int id)
{
        PedidoClienteEN pedidoClienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoClienteEN = (PedidoClienteEN)session.Get (typeof(PedidoClienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoClienteEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> LeerPorFecha (Nullable<DateTime> fechaFilter)
{
        System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoClienteEN self where FROM PedidoClienteEN p where p.Fecha = :fechaFilter";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoClienteENleerPorFechaHQL");
                query.SetParameter ("fechaFilter", fechaFilter);

                result = query.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in PedidoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
