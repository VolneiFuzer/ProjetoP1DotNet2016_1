using P1DotNetVF.Domain.Interfaces.Repositories;
using P1DotNetVF.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace P1DotNetVF.Infra.Data.Repositories
{
	public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
	{
		protected P1DotNetVFContext Db = new P1DotNetVFContext();

		public void Add(TEntity obj)
		{
			Db.Set<TEntity>().Add(obj);
			Db.SaveChanges();
		}

		public TEntity GetByID(int id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Db.Set<TEntity>().ToList(); 
		}

		public void Remove(TEntity obj)
		{
			Db.Set<TEntity>().Remove(obj);
			Db.SaveChanges();
		}

		public void Update(TEntity obj)
		{
			Db.Entry(obj).State = EntityState.Modified;
			Db.SaveChanges();
		}
	}
}
