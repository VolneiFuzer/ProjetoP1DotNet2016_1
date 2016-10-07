
using System;
using System.Collections.Generic;
using P1DotNetVF.Application.Interface;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Domain.Interfaces.Services;

namespace P1DotNetVF.Application
{
	public class CorrentistaAppService : AppServiceBase<Correntista>, ICorrentistaAppService
	{
		private readonly ICorrentistaService _correntistaService;

		public CorrentistaAppService(ICorrentistaService correntistaService) : base(correntistaService)
		{
			_correntistaService = correntistaService;
		}

		public IEnumerable<Correntista> BuscarPorNome(string n)
		{
			return _correntistaService.GetAll();
		}
	}
}
