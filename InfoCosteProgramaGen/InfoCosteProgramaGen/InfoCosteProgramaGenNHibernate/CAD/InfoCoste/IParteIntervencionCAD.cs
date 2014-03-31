
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface IParteIntervencionCAD
{
ParteIntervencionEN ReadOIDDefault (int id);

void SetAccionesRealizadas (ParteIntervencionEN parteIntervencion);


void SetDatosPc (ParteIntervencionEN parteIntervencion);








int ParteIntervencion (ParteIntervencionEN parteIntervencion);

System.Collections.Generic.IList<ParteIntervencionEN> LeerTodos (int first, int size);


ParteIntervencionEN LeerPorOID (int id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> LeerPorFecha (Nullable<DateTime> fechaFiltro);
}
}
