
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
public void SetDescription (int p_Producto_OID, string p_descripcion)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Producto_setDescription_customized) START*/

        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_Producto_OID;
        productoEN.Descripcion = p_descripcion;
        //Call to ProductoCAD

        _IProductoCAD.SetDescription (productoEN);

        /*PROTECTED REGION END*/
}
}
}
