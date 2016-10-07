

using P1DotNetVF.Domain.Entities;
using System.Collections.Generic;

namespace P1DotNetVF.Application.Interface
{
	public interface ICartaoAppService : IAppServiceBase<Cartao>
	{
		IEnumerable<Cartao> BuscarPorNome(string n);
	}
}
