using System;
using System.Collections.Generic;
using System.Text;

namespace NotesToSelf.DAL.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity toAdd);
    }
}
