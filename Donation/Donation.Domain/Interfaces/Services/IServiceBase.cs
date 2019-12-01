﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Domain.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> Getall();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
