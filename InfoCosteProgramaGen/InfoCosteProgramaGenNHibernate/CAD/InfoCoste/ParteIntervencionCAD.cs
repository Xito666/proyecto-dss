
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
public partial class ParteIntervencionCAD : BasicCAD, IParteIntervencionCAD
{
public ParteIntervencionCAD() : base ()
{
}

public ParteIntervencionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ParteIntervencionEN ReadOIDDefault (int id)
{
        ParteIntervencionEN parteIntervencionEN = null;

        try
        {
                SessionInitializeTransaction ();
                parteIntervencionEN = (ParteIntervencionEN)session.Get (typeof(ParteIntervencionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return parteIntervencionEN;
}


public void SetAccionesRealizadas (ParteIntervencionEN parteIntervencion)
{
        try
        {
                SessionInitializeTransaction ();
                ParteIntervencionEN parteIntervencionEN = (ParteIntervencionEN)session.Load (typeof(ParteIntervencionEN), parteIntervencion.Id);

                parteIntervencionEN.AccionesRealizadas = parteIntervencion.AccionesRealizadas;

                session.Update (parteIntervencionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void SetDatosPc (ParteIntervencionEN parteIntervencion)
{
        try
        {
                SessionInitializeTransaction ();
                ParteIntervencionEN parteIntervencionEN = (ParteIntervencionEN)session.Load (typeof(ParteIntervencionEN), parteIntervencion.Id);

                parteIntervencionEN.DatosPc = parteIntervencion.DatosPc;

                session.Update (parteIntervencionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public int ParteIntervencion (ParteIntervencionEN parteIntervencion)
{
        try
        {
                SessionInitializeTransaction ();
                if (parteIntervencion.Trabajador != null) {
                        parteIntervencion.Trabajador = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN), parteIntervencion.Trabajador.Id);

                        parteIntervencion.Trabajador.ParteIntervencion.Add (parteIntervencion);
                }
                if (parteIntervencion.Cliente != null) {
                        parteIntervencion.Cliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN), parteIntervencion.Cliente.Id);

                        parteIntervencion.Cliente.ParteIntervencion.Add (parteIntervencion);
                }

                session.Save (parteIntervencion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return parteIntervencion.Id;
}

public System.Collections.Generic.IList<ParteIntervencionEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ParteIntervencionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ParteIntervencionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ParteIntervencionEN>();
                else
                        result = session.CreateCriteria (typeof(ParteIntervencionEN)).List<ParteIntervencionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ParteIntervencionEN LeerPorOID (int id)
{
        ParteIntervencionEN parteIntervencionEN = null;

        try
        {
                SessionInitializeTransaction ();
                parteIntervencionEN = (ParteIntervencionEN)session.Get (typeof(ParteIntervencionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return parteIntervencionEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> LeerPorFecha (Nullable<DateTime> fechaFiltro)
{
        System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ParteIntervencionEN self where FROM ParteIntervencionEN parte where parte.fecha = :fechaFiltro";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ParteIntervencionENleerPorFechaHQL");
                query.SetParameter ("fechaFiltro", fechaFiltro);

                result = query.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ParteIntervencionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
