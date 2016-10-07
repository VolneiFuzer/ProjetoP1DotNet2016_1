using P1DotNetVF.Domain.Entities;
using System.Collections.Generic;

namespace P1DotNetVF.Application.Interface
{
	public interface ICorrentistaAppService : IAppServiceBase<Correntista>
	{
		IEnumerable<Correntista> BuscarPorNome(string n);
	}
}
