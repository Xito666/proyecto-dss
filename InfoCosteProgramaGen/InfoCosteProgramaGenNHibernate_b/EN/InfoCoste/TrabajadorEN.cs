
using System;

namespace InfoCosteProgramaGenNHibernate.EN.InfoCoste
{
public partial class TrabajadorEN
{
/**
 *
 */

private int id;

/**
 *
 */

private string nombre;

/**
 *
 */

private string password;

/**
 *
 */

private System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Password {
        get { return password; } set { password = value;  }
}


public virtual System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> ParteIntervencion {
        get { return parteIntervencion; } set { parteIntervencion = value;  }
}





public TrabajadorEN()
{
        parteIntervencion = new System.Collections.Generic.List<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN>();
}



public TrabajadorEN(int id, string nombre, string password, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion)
{
        this.init (id, nombre, password, parteIntervencion);
}


public TrabajadorEN(TrabajadorEN trabajador)
{
        this.init (trabajador.Id, trabajador.Nombre, trabajador.Password, trabajador.ParteIntervencion);
}

private void init (int id, string nombre, string password, System.Collections.Generic.IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ParteIntervencionEN> parteIntervencion)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Password = password;

        this.ParteIntervencion = parteIntervencion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TrabajadorEN t = obj as TrabajadorEN;
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
