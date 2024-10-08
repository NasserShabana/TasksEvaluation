﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEvaluation.Core.Interfaces.IRepositories
{
    public interface IBaseRepository<T>where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById<Tid>(Tid id);
        Task<T> Create(T model);
        Task CreateRange(List<T> model);
        Task Update(T model);
        Task Delete(T model);
        Task SaveChangeAsync();

    }
}
