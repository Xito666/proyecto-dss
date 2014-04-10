

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
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public int Producto (int p_id, string p_nombre, string p_descripcion, double p_precio, string p_familia, int p_stock)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_id;

        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.Precio = p_precio;

        productoEN.Familia = p_familia;

        productoEN.Stock = p_stock;

        //Call to ProductoCAD

        oid = _IProductoCAD.Producto (productoEN);
        return oid;
}

public System.Collections.Generic.IList<ProductoEN> LeerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.LeerTodos (first, size);
        return list;
}
public ProductoEN LeerPorOID (int id)
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.LeerPorOID (id);
        return productoEN;
}

public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN> LeerPorNombre (string nombreFiltro)
{
        return _IProductoCAD.LeerPorNombre (nombreFiltro);
}
public System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ProductoEN> LeerPorFamilia (string familiaFiltro)
{
        return _IProductoCAD.LeerPorFamilia (familiaFiltro);
}
public void Borrar (int id)
{
        _IProductoCAD.Borrar (id);
}
}
}
