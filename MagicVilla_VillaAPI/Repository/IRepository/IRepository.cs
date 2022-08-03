﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);

        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true);

        Task CreateAsync(T entity);

        Task UpdateAsync(T model);

        Task RemoveAsync(T entity);

        Task SaveAsync();
    }
}