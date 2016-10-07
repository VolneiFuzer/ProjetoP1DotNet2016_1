
using System.Collections.Generic;

namespace P1DotNetVF.Application.Interface
{
	public interface IAppServiceBase<TEntity> where TEntity : class
	{
		void Add(TEntity obj);
		TEntity GetByID(int id);
		IEnumerable<TEntity> GetAll();
		void Update(TEntity obj);
		void Remove(TEntity obj);
		void Dispose();
	}
}
