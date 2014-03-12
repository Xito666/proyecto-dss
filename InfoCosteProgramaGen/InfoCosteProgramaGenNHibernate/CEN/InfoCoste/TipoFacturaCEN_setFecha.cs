
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
public partial class TipoFacturaCEN
{
public void SetFecha (int p_TipoFactura_OID, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_TipoFactura_setFecha_customized) START*/

        TipoFacturaEN tipoFacturaEN = null;

        //Initialized TipoFacturaEN
        tipoFacturaEN = new TipoFacturaEN ();
        tipoFacturaEN.Id = p_TipoFactura_OID;
        tipoFacturaEN.Fecha = p_fecha;
        //Call to TipoFacturaCAD

        _ITipoFacturaCAD.SetFecha (tipoFacturaEN);

        /*PROTECTED REGION END*/
}
}
}
