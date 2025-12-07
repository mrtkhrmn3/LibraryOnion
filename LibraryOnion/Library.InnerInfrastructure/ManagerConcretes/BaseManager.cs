using AutoMapper;
using Library.Application.DTOInterfaces;
using Library.Application.ManagerInterfaces;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Enums;
using Library.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.InnerInfrastructure.ManagerConcretes
{
    public abstract class BaseManager<T, U> : IManager<T, U> where T : class, IDto where U : class, IEntity
    {
        protected readonly IRepository<U> _repository;
        protected readonly IMapper _mapper;

        protected BaseManager(IRepository<U> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task CreateAsync(T entity)
        {
            var entityToCreate = _mapper.Map<U>(entity);
            entityToCreate.CreatedDate = DateTime.Now;
            entityToCreate.Status = DataStatus.Insterted;
            await _repository.CreateAsync(entityToCreate);
        }

        public virtual List<T> GetActives()
        {
            var entities = _repository.Where(x => x.Status == DataStatus.Insterted).ToList();
            return _mapper.Map<List<T>>(entities);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<T>>(entities);
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<T>(entity);
        }

        public virtual List<T> GetPassives()
        {
            var entities = _repository.Where(x => x.Status == DataStatus.Deleted).ToList();
            return _mapper.Map<List<T>>(entities);
        }

        public virtual List<T> GetUpdateds()
        {
            var entities = _repository.Where(x => x.Status == DataStatus.Updated).ToList();
            return _mapper.Map<List<T>>(entities);
        }

        public virtual async Task<string> HardDeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return "Entity not found";

            await _repository.DeleteAsync(entity);
            return "Entity deleted successfully";
        }

        public virtual async Task<string> SoftDeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return "Entity not found";

            entity.DeletedDate = DateTime.Now;
            entity.Status = DataStatus.Deleted;
            await _repository.UpdateAsync(entity, entity);
            return "Entity soft deleted successfully";
        }

        public virtual async Task UpdateAsync(T entity)
        {
            var existingEntity = await _repository.GetByIdAsync(entity.Id);
            if (existingEntity == null)
                throw new Exception("Entity not found");

            var entityToUpdate = _mapper.Map<U>(entity);
            entityToUpdate.CreatedDate = existingEntity.CreatedDate;
            entityToUpdate.UpdatedDate = DateTime.Now;
            entityToUpdate.Status = DataStatus.Updated;
            await _repository.UpdateAsync(existingEntity, entityToUpdate);
        }
    }
}
