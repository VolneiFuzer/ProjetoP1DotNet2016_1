
using P1DotNetVF.Application.Interface;
using P1DotNetVF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace P1DotNetVF.Application
{
	public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
	{
		private readonly IRepositoryBase<TEntity> _serviceBase;

		public AppServiceBase(IRepositoryBase<TEntity> serviceBase)
		{
			_serviceBase = serviceBase;
		}

		public void Add(TEntity obj)
		{
			_serviceBase.Add(obj);
		}

		public void Dispose()
		{
			_serviceBase.Dispose();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _serviceBase.GetAll();
		}

		public TEntity GetByID(int id)
		{
			return _serviceBase.GetByID(id);
		}

		public void Remove(TEntity obj)
		{
			_serviceBase.Remove(obj);
		}

		public void Update(TEntity obj)
		{
			_serviceBase.Update(obj);
		}
	}
}
