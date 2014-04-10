
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
public void SetDatosPago (int p_TipoFactura_OID, string p_datosPago)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_TipoFactura_setDatosPago_customized) START*/

        TipoFacturaEN tipoFacturaEN = null;

        //Initialized TipoFacturaEN
        tipoFacturaEN = new TipoFacturaEN ();
        tipoFacturaEN.Id = p_TipoFactura_OID;
        tipoFacturaEN.DatosPago = p_datosPago;
        //Call to TipoFacturaCAD

        _ITipoFacturaCAD.SetDatosPago (tipoFacturaEN);

        /*PROTECTED REGION END*/
}
}
}
