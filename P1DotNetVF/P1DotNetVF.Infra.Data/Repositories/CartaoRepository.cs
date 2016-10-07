using System.Collections.Generic;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Domain.Interfaces;
using System.Linq;

namespace P1DotNetVF.Infra.Data.Repositories
{
	public class CartaoRepository : RepositoryBase<Cartao>, ICartaoRepository
	{
		public IEnumerable<Cartao> BuscarPorNome(string n)
		{
			return Db.Cartoes.Where(p => p.NomeCartao == n);
		}
	}
}
