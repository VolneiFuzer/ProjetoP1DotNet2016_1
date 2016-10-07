
using P1DotNetVF.Application.Interface;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace P1DotNetVF.Application
{
	public class CartaoAppService : AppServiceBase<Cartao>, ICartaoAppService
	{
		private readonly ICartaoService _cartaoService;

		public CartaoAppService(ICartaoService cartaoService) : base(cartaoService)
		{
			_cartaoService = cartaoService;
		}

		public IEnumerable<Cartao> BuscarPorNome(string n)
		{
			return _cartaoService.GetAll();
		}
	}
}
