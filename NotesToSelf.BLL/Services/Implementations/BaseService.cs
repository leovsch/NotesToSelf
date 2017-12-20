using System;
using AutoMapper;
using NotesToSelf.BLL.Services.Interfaces;
using NotesToSelf.DAL.DataModels;
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
            BaseDataModel mapped = _mapper.Map<TEntity>(toAddd) as BaseDataModel;
            if (mapped != null)
            {
                mapped.Id = Guid.NewGuid();
                var toAdd = mapped as TEntity;
                _baseRepository.Add(toAdd);
                return _mapper.Map<T>(mapped);
            }
            throw new Exception();
        }
    }
}
