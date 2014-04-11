using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using InfoCosteProgramaGenNHibernate.EN.InfoCoste;
using InfoCosteProgramaGenNHibernate.CAD.InfoCoste;

namespace InfoCosteProgramaGenNHibernate.CP
{
    public class BasicCP
    {
        protected ISession session;

        protected bool sessionStarted;

        protected ITransaction tx;

        protected BasicCP()
        {
            sessionStarted = true;
        }

        protected BasicCP(ISession sessionAux)
        {
            session = sessionAux;
            sessionStarted = false;
        }

        protected void SessionInitializeTransaction()
        {
            if (session == null && sessionStarted == true)
            {
                session = NHibernateHelper.OpenSession();
                tx = session.BeginTransaction();
            }
        }

        protected void SessionCommit()
        {
            if (sessionStarted && session != null)
                tx.Commit();
        }

        protected void SessionRollBack()
        {
            if (sessionStarted && session != null && session.IsOpen)
                tx.Rollback();
        }

        protected void SessionClose()
        {
            if (sessionStarted && session != null && session.IsOpen)
            {
                session.Close();
                session.Dispose();
                session = null;
            }
        }
    }
}
