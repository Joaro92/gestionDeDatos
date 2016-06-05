﻿using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class RolDaoImpl : RolDao
    {

        public void Add(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Save(rol);
                    transaction.Commit();
                }
            }
        }

        public void Update(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Update(rol);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Rol rol)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    manager.Session.Delete(rol);
                    transaction.Commit();
                }
            }
        }



        public IList<Rol> darRolActivo()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Rol>();
                crit.Add(Expression.Eq("activo", true));
                return crit.List<Rol>(); 
                

        }
    }

    }
}