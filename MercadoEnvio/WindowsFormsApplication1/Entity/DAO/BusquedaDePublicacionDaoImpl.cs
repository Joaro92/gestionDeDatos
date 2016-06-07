﻿using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class BusquedaDePublicacionDaoImpl : BusquedaDePublicacionDao
    {

        public void Add(BusquedaDePublicacion busquedaDePublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    BusquedaDePublicacion newEntityRef = manager.Session.Merge(busquedaDePublicacion);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(BusquedaDePublicacion busquedaDePublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    BusquedaDePublicacion newEntityRef = manager.Session.Merge(busquedaDePublicacion);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(BusquedaDePublicacion busquedaDePublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    BusquedaDePublicacion newEntityRef = manager.Session.Merge(busquedaDePublicacion);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public IList<BusquedaDePublicacion> darLista()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<BusquedaDePublicacion>();
                return crit.List<BusquedaDePublicacion>(); 
                

            }
        }

    }
}
