

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
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int LineaPedido (int p_id, int p_numero, int p_cantidad, double p_descuento, int p_producto)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_id;

        lineaPedidoEN.Numero = p_numero;

        lineaPedidoEN.Cantidad = p_cantidad;

        lineaPedidoEN.Descuento = p_descuento;


        if (p_producto != -1) {
                lineaPedidoEN.Producto = new InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN ();
                lineaPedidoEN.Producto.Id = p_producto;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.LineaPedido (lineaPedidoEN);
        return oid;
}
}
}
