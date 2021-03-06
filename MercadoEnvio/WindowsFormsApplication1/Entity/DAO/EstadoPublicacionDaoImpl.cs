﻿using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class EstadoPublicacionDaoDaoImpl : EstadoPublicacionDao     {

        public void Add(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Estadopublicacion newEntityRef = manager.Session.Merge(estadopublicacion);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Estadopublicacion newEntityRef = manager.Session.Merge(estadopublicacion);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Estadopublicacion estadopublicacion)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Estadopublicacion newEntityRef = manager.Session.Merge(estadopublicacion);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }



        public IList<Estadopublicacion> darEstados()
        {
            using (NHibernateManager manager = new NHibernateManager()) {

                ICriteria crit = manager.Session.CreateCriteria<Estadopublicacion>();

                return crit.List<Estadopublicacion>(); 
                

           }
       }

        public Estadopublicacion darEstadoByID(int id){
            using (NHibernateManager manager = new NHibernateManager())           {
                ICriteria crit = manager.Session.CreateCriteria<Estadopublicacion>();
                //crit.CreateAlias("Usuario", "usr");
                crit.Add(Expression.Eq("idEstadoPublicacion", id));
                return crit.UniqueResult<Estadopublicacion>();
            }
        }

    }
}
