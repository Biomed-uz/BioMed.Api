﻿using BioMed.Domain.Entities;

namespace BioMed.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        IEnumerable<T> FindAll();
        T FindById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
