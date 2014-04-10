
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
public partial class ProformaCAD : BasicCAD, IProformaCAD
{
public ProformaCAD() : base ()
{
}

public ProformaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProformaEN ReadOIDDefault (int id)
{
        ProformaEN proformaEN = null;

        try
        {
                SessionInitializeTransaction ();
                proformaEN = (ProformaEN)session.Get (typeof(ProformaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ProformaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proformaEN;
}


public int Proforma (ProformaEN proforma)
{
        try
        {
                SessionInitializeTransaction ();
                if (proforma.PedidoCliente != null) {
                        proforma.PedidoCliente = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.PedidoClienteEN), proforma.PedidoCliente.Id);

                        proforma.PedidoCliente.TipoFactura = proforma;
                }

                session.Save (proforma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ProformaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proforma.Id;
}

public System.Collections.Generic.IList<ProformaEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProformaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProformaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProformaEN>();
                else
                        result = session.CreateCriteria (typeof(ProformaEN)).List<ProformaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ProformaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ProformaEN LeerPorOID (int id)
{
        ProformaEN proformaEN = null;

        try
        {
                SessionInitializeTransaction ();
                proformaEN = (ProformaEN)session.Get (typeof(ProformaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in ProformaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proformaEN;
}
}
}
