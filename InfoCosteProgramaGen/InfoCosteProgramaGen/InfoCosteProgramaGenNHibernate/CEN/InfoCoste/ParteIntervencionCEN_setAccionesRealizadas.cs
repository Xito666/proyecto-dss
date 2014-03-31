
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
public void SetAccionesRealizadas (int p_ParteIntervencion_OID, string p_accionesRealizadas)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_ParteIntervencion_setAccionesRealizadas_customized) START*/

        ParteIntervencionEN parteIntervencionEN = null;

        //Initialized ParteIntervencionEN
        parteIntervencionEN = new ParteIntervencionEN ();
        parteIntervencionEN.Id = p_ParteIntervencion_OID;
        parteIntervencionEN.AccionesRealizadas = p_accionesRealizadas;
        //Call to ParteIntervencionCAD

        _IParteIntervencionCAD.SetAccionesRealizadas (parteIntervencionEN);

        /*PROTECTED REGION END*/
}
}
}
