
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
public partial class ClienteParticularCAD : BasicCAD, IClienteParticularCAD
{
public ClienteParticularCAD() : base ()
{
}

public ClienteParticularCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteParticularEN ReadOIDDefault (string id)
{
        ClienteParticularEN clienteParticularEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteParticularEN = (ClienteParticularEN)session.Get (typeof(ClienteParticularEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteParticularCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteParticularEN;
}


public string ClienteParticular (ClienteParticularEN clienteParticular)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (clienteParticular);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteParticularCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteParticular.Id;
}

public System.Collections.Generic.IList<ClienteParticularEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteParticularEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteParticularEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteParticularEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteParticularEN)).List<ClienteParticularEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteParticularCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ClienteParticularEN LeerPorOID (string id)
{
        ClienteParticularEN clienteParticularEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteParticularEN = (ClienteParticularEN)session.Get (typeof(ClienteParticularEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteParticularCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteParticularEN;
}
}
}
