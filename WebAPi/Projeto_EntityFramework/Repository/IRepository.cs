﻿using System;
using System.Linq;

namespace Projeto_EntityFramework.Repository
{
    interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Update(TEntity obj);
        void SaveAll();
        void Add(TEntity obj);
        void Delete(Func<TEntity, bool> predicate);
    }
}