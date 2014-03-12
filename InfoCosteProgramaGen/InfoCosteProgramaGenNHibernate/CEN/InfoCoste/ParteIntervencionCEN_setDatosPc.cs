
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
public partial class ParteIntervencionCEN
{
public void SetDatosPc (int p_ParteIntervencion_OID, string p_datosPc)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_ParteIntervencion_setDatosPc_customized) START*/

        ParteIntervencionEN parteIntervencionEN = null;

        //Initialized ParteIntervencionEN
        parteIntervencionEN = new ParteIntervencionEN ();
        parteIntervencionEN.Id = p_ParteIntervencion_OID;
        parteIntervencionEN.DatosPc = p_datosPc;
        //Call to ParteIntervencionCAD

        _IParteIntervencionCAD.SetDatosPc (parteIntervencionEN);

        /*PROTECTED REGION END*/
}
}
}
