
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
public void SetNumero (string p_LineaPedidoProveedor_OID, int p_numero)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_LineaPedidoProveedor_setNumero_customized) START*/

        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Id = p_LineaPedidoProveedor_OID;
        lineaPedidoProveedorEN.Numero = p_numero;
        //Call to LineaPedidoProveedorCAD

        _ILineaPedidoProveedorCAD.SetNumero (lineaPedidoProveedorEN);

        /*PROTECTED REGION END*/
}
}
}
