
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
public void SetPassword (int p_Trabajador_OID, string p_password)
{
        /*PROTECTED REGION ID(InfoCosteProgramaGenNHibernate.CEN.InfoCoste_Trabajador_setPassword_customized) START*/

        TrabajadorEN trabajadorEN = null;

        //Initialized TrabajadorEN
        trabajadorEN = new TrabajadorEN ();
        trabajadorEN.Id = p_Trabajador_OID;
        trabajadorEN.Password = p_password;
        //Call to TrabajadorCAD

        _ITrabajadorCAD.SetPassword (trabajadorEN);

        /*PROTECTED REGION END*/
}
}
}
