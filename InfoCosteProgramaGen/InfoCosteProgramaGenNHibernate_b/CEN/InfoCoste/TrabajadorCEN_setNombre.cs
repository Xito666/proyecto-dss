
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
public partial class TrabajadorCEN
{
public void SetNombre (int p_Trabajador_OID, string p_nombre)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Trabajador_setNombre_customized) START*/

        TrabajadorEN trabajadorEN = null;

        //Initialized TrabajadorEN
        trabajadorEN = new TrabajadorEN ();
        trabajadorEN.Id = p_Trabajador_OID;
        trabajadorEN.Nombre = p_nombre;
        //Call to TrabajadorCAD

        _ITrabajadorCAD.SetNombre (trabajadorEN);

        /*PROTECTED REGION END*/
}
}
}
