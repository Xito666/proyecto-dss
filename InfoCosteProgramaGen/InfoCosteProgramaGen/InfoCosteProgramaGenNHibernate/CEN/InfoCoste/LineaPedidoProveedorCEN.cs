

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CEN.InfoCoste
{
public partial class LineaPedidoProveedorCEN
{
private ILineaPedidoProveedorCAD _ILineaPedidoProveedorCAD;

public LineaPedidoProveedorCEN()
{
        this._ILineaPedidoProveedorCAD = new LineaPedidoProveedorCAD ();
}

public LineaPedidoProveedorCEN(ILineaPedidoProveedorCAD _ILineaPedidoProveedorCAD)
{
        this._ILineaPedidoProveedorCAD = _ILineaPedidoProveedorCAD;
}

public ILineaPedidoProveedorCAD get_ILineaPedidoProveedorCAD ()
{
        return this._ILineaPedidoProveedorCAD;
}

public string LineaPedidoProveedor (string p_id, int p_numero, int p_cantidad, double p_descuento, double p_precioCoste, int p_producto)
{
        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;
        string oid;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Id = p_id;

        lineaPedidoProveedorEN.Numero = p_numero;

        lineaPedidoProveedorEN.Cantidad = p_cantidad;

        lineaPedidoProveedorEN.Descuento = p_descuento;

        lineaPedidoProveedorEN.PrecioCoste = p_precioCoste;


        if (p_producto != -1) {
                lineaPedidoProveedorEN.Producto = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN ();
                lineaPedidoProveedorEN.Producto.Id = p_producto;
        }

        //Call to LineaPedidoProveedorCAD

        oid = _ILineaPedidoProveedorCAD.LineaPedidoProveedor (lineaPedidoProveedorEN);
        return oid;
}
}
}
