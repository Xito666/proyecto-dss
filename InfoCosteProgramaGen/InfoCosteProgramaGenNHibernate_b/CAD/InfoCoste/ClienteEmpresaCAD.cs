
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
public partial class ClienteEmpresaCAD : BasicCAD, IClienteEmpresaCAD
{
public ClienteEmpresaCAD() : base ()
{
}

public ClienteEmpresaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEmpresaEN ReadOIDDefault (string id)
{
        ClienteEmpresaEN clienteEmpresaEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEmpresaEN = (ClienteEmpresaEN)session.Get (typeof(ClienteEmpresaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteEmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEmpresaEN;
}


public void SetNumeroCuenta (ClienteEmpresaEN clienteEmpresa)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEmpresaEN clienteEmpresaEN = (ClienteEmpresaEN)session.Load (typeof(ClienteEmpresaEN), clienteEmpresa.Id);

                clienteEmpresaEN.NumeroCuenta = clienteEmpresa.NumeroCuenta;

                session.Update (clienteEmpresaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteEmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public string ClienteEmpresa (ClienteEmpresaEN clienteEmpresa)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (clienteEmpresa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteEmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEmpresa.Id;
}

public System.Collections.Generic.IList<ClienteEmpresaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEmpresaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteEmpresaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteEmpresaEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteEmpresaEN)).List<ClienteEmpresaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteEmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ClienteEmpresaEN LeerPorOID (string id)
{
        ClienteEmpresaEN clienteEmpresaEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEmpresaEN = (ClienteEmpresaEN)session.Get (typeof(ClienteEmpresaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ClienteEmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEmpresaEN;
}
}
}
