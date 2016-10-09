using P1DotNetVF.Domain.Entities;
using System.Collections.Generic;

namespace P1DotNetVF.Domain.Interfaces.Services
{
	public interface ICartaoService : IServiceBase<Cartao>
	{
		IEnumerable<Cartao> BuscarPorNome(string n);
	}
}
