﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingDemo.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync (int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync (T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T enity);

    }
}
