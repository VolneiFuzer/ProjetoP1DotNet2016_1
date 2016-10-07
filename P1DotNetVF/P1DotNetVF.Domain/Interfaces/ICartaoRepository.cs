using P1DotNetVF.Domain.Entities;
using System.Collections.Generic;

namespace P1DotNetVF.Domain.Interfaces
{
	public interface ICartaoRepository : IRepositoryBase<Cartao>
	{
		IEnumerable<Cartao> BuscarPorNome(string n);
	}
}
