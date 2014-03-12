
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class ParteIntervencionEN
{
/**
 *
 */

private int id;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private string datosPc;

/**
 *
 */

private string accionesRealizadas;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador;

/**
 *
 */

private InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual string DatosPc {
        get { return datosPc; } set { datosPc = value;  }
}


public virtual string AccionesRealizadas {
        get { return accionesRealizadas; } set { accionesRealizadas = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN Trabajador {
        get { return trabajador; } set { trabajador = value;  }
}


public virtual InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}





public ParteIntervencionEN()
{
}



public ParteIntervencionEN(int id, Nullable<DateTime> fecha, string datosPc, string accionesRealizadas, InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente)
{
        this.init (id, fecha, datosPc, accionesRealizadas, trabajador, cliente);
}


public ParteIntervencionEN(ParteIntervencionEN parteIntervencion)
{
        this.init (parteIntervencion.Id, parteIntervencion.Fecha, parteIntervencion.DatosPc, parteIntervencion.AccionesRealizadas, parteIntervencion.Trabajador, parteIntervencion.Cliente);
}

private void init (int id, Nullable<DateTime> fecha, string datosPc, string accionesRealizadas, InfoCosteProgramaGenNHibernate.EN.InfoCoste.TrabajadorEN trabajador, InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN cliente)
{
        this.Id = id;


        this.Fecha = fecha;

        this.DatosPc = datosPc;

        this.AccionesRealizadas = accionesRealizadas;

        this.Trabajador = trabajador;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ParteIntervencionEN t = obj as ParteIntervencionEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
