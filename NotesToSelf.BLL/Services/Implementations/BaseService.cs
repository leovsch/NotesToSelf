using System;
using AutoMapper;
using NotesToSelf.BLL.Services.Interfaces;
using NotesToSelf.DAL.Repositories.Interfaces;

namespace NotesToSelf.BLL.Services.Implementations
{
    public class BaseService<TEntity, T> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public T Add(T toAddd)
        {
            //var mapped = _mapper.Map<TEntity>(toAddd);
            //_baseRepository.Add(mapped);
            //return _mapper.Map<T>(mapped);
            throw new NotImplementedException();
        }
    }
}
