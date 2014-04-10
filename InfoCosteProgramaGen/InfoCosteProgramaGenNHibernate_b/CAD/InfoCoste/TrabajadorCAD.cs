
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
public partial class TrabajadorCAD : BasicCAD, ITrabajadorCAD
{
public TrabajadorCAD() : base ()
{
}

public TrabajadorCAD(ISession sessionAux) : base (sessionAux)
{
}



public TrabajadorEN ReadOIDDefault (int id)
{
        TrabajadorEN trabajadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Get (typeof(TrabajadorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajadorEN;
}


public System.Collections.Generic.IList<TrabajadorEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<TrabajadorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TrabajadorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TrabajadorEN>();
                else
                        result = session.CreateCriteria (typeof(TrabajadorEN)).List<TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public TrabajadorEN LeerPorOID (int id)
{
        TrabajadorEN trabajadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Get (typeof(TrabajadorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajadorEN;
}

public void SetPassword (TrabajadorEN trabajador)
{
        try
        {
                SessionInitializeTransaction ();
                TrabajadorEN trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), trabajador.Id);

                trabajadorEN.Password = trabajador.Password;

                session.Update (trabajadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void SetNombre (TrabajadorEN trabajador)
{
        try
        {
                SessionInitializeTransaction ();
                TrabajadorEN trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), trabajador.Id);

                trabajadorEN.Nombre = trabajador.Nombre;

                session.Update (trabajadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public int Trabajador (TrabajadorEN trabajador)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (trabajador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajador.Id;
}

public void Borrar (int id)
{
        try
        {
                SessionInitializeTransaction ();
                TrabajadorEN trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), id);
                session.Delete (trabajadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> LeerPorNombre (string nombreFiltro)
{
        System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN t where t.Nombre = :nombreFiltro";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TrabajadorENleerPorNombreHQL");
                query.SetParameter ("nombreFiltro", nombreFiltro);

                result = query.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
