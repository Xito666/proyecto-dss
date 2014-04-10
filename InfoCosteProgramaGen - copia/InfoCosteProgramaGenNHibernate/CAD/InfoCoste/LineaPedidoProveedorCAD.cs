
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
public partial class LineaPedidoProveedorCAD : BasicCAD, ILineaPedidoProveedorCAD
{
public LineaPedidoProveedorCAD() : base ()
{
}

public LineaPedidoProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaPedidoProveedorEN ReadOIDDefault (string id)
{
        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Get (typeof(LineaPedidoProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoProveedorEN;
}


public void SetProducto (string p_LineaPedidoProveedor_OID, double p_precioCoste)
{
        InfoCosteProgramaGenNHibernate.EN.InfoCoste.LineaPedidoProveedorEN lineaPedidoProveedorEN = null;
        try
        {
                SessionInitializeTransaction ();
                lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), p_LineaPedidoProveedor_OID);
                lineaPedidoProveedorEN.Producto = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN), p_precioCoste);

                lineaPedidoProveedorEN.Producto.LineaPedidoProveedor.Add (lineaPedidoProveedorEN);



                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void SetDescuento (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), lineaPedidoProveedor.Id);

                lineaPedidoProveedorEN.Descuento = lineaPedidoProveedor.Descuento;

                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void SetCantidad (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), lineaPedidoProveedor.Id);

                lineaPedidoProveedorEN.Cantidad = lineaPedidoProveedor.Cantidad;

                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void SetNumero (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), lineaPedidoProveedor.Id);

                lineaPedidoProveedorEN.Numero = lineaPedidoProveedor.Numero;

                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public string LineaPedidoProveedor (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                if (lineaPedidoProveedor.Producto != null) {
                        lineaPedidoProveedor.Producto = (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN)session.Load (typeof(InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN), lineaPedidoProveedor.Producto.Id);

                        lineaPedidoProveedor.Producto.LineaPedidoProveedor.Add (lineaPedidoProveedor);
                }

                session.Save (lineaPedidoProveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is InfoCosteProgramaGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new InfoCosteProgramaGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoProveedor.Id;
}
}
}
