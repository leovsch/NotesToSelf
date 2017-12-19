using System;
using NotesToSelf.DAL.Repositories.Interfaces;

namespace NotesToSelf.Services.Implementations
{
    public class BaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        public BaseService()
        {
        }

        public T Add<T>(TEntity toAddd)
        {
            throw new NotImplementedException();
        }
    }
}
