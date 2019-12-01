using Donation.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Donation.Infra.Data.Context;
using System.Linq;
using System.Data.Entity;

namespace Donation.Infra.Data.Repository
{
    public class RepositoryBase<Tentity> : IDisposable, IRepositoryBase<Tentity> where Tentity : class
    {
        Contexto Db = new Contexto();

        public void add(Tentity obj)
        {
            Db.Set<Tentity>().Add(obj);
            Db.SaveChanges();
        }

        public Tentity GetById(int id)
        {
            return Db.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> Getall()
        {
            return Db.Set<Tentity>().ToList();
        }

        public void Update(Tentity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(Tentity obj)
        {
            Db.Set<Tentity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
