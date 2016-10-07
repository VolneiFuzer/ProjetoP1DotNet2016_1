
using P1DotNetVF.Domain.Interfaces.Repositories;
using P1DotNetVF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace P1DotNetVF.Domain.Services
{
	public class ServiceBase<TEntity> : IDisposable, Interfaces.Services.IRepositoryBase<TEntity> where TEntity : class
	{
		private readonly Interfaces.Repositories.IRepositoryBase<TEntity> _repository;

		public ServiceBase(Interfaces.Repositories.IRepositoryBase<TEntity> repository)
		{
			_repository = repository;
		}

		public void Add(TEntity obj)
		{
			_repository.Add(obj);
		}

		public void Dispose()
		{
			_repository.Dispose();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _repository.GetAll();
		}

		public TEntity GetByID(int id)
		{
			return _repository.GetByID(id);
		}

		public void Remove(TEntity obj)
		{
			_repository.Remove(obj);
		}

		public void Update(TEntity obj)
		{
			_repository.Update(obj);
		}
	}
}
