using Donation.Application.Interfaces;
using Donation.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _IServiceBase;

        public AppServiceBase(IServiceBase<TEntity> IServiceBase)
        {
            _IServiceBase = IServiceBase;
        }

        public void add(TEntity obj)
        {
            _IServiceBase.add(obj);
        }

        public IEnumerable<TEntity> Getall()
        {
            return _IServiceBase.Getall();
        }

        public TEntity GetById(int id)
        {
            return _IServiceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _IServiceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _IServiceBase.Update(obj);
        }

        public void Dispose()
        {
            _IServiceBase.Dispose();
        }
    }
}
