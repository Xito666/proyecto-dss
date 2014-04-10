
using System;
using InfoCosteProgramaGenNHibernate.EN.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CAD.InfoCoste
{
public partial interface ITipoFacturaCAD
{
TipoFacturaEN ReadOIDDefault (int id);


void SetDatosPago (TipoFacturaEN tipoFactura);


void SetFecha (TipoFacturaEN tipoFactura);





int TipoFactura (TipoFacturaEN tipoFactura);

System.Collections.Generic.IList<TipoFacturaEN> LeerTodos (int first, int size);


TipoFacturaEN LeerPorOID (int id);


System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.TipoFacturaEN> LeerPorFecha (Nullable<DateTime> fechaFiltro);
}
}
