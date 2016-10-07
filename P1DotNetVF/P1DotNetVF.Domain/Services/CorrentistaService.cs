using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Domain.Interfaces.Repositories;
using P1DotNetVF.Domain.Interfaces.Services;

namespace P1DotNetVF.Domain.Services
{
	public class CorrentistaService : ServiceBase <Correntista>, ICorrentistaService
	{
		private readonly ICorrentistaRepository _correntistaRepository;

		public CorrentistaService(ICorrentistaRepository correntistaRepository) : base (correntistaRepository)
		{
			_correntistaRepository = correntistaRepository;
		}
	}
}
