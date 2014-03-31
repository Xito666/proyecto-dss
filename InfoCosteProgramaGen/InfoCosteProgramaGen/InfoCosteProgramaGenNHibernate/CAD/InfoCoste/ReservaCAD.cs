
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
public partial class ReservaCAD : BasicCAD, IReservaCAD
{
public ReservaCAD() : base ()
{
}

public ReservaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReservaEN ReadOIDDefault (int id)
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}


public int Reserva (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                if (reserva.PedidoCliente != null) {
                        reserva.PedidoCliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN), reserva.PedidoCliente.Id);

                        reserva.PedidoCliente.TipoFactura = reserva;
                }

                session.Save (reserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reserva.Id;
}

public System.Collections.Generic.IList<ReservaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReservaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                else
                        result = session.CreateCriteria (typeof(ReservaEN)).List<ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ReservaEN LeerPorOID (int id)
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ReservaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}
}
}
