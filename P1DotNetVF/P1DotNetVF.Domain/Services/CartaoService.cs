
using System;
using System.Collections.Generic;
using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Domain.Interfaces.Repositories;
using P1DotNetVF.Domain.Interfaces.Services;

namespace P1DotNetVF.Domain.Services
{
	public class CartaoService : ServiceBase<Cartao>, ICartaoService
	{
		private readonly ICartaoRepository _cartaoRepository;

		public CartaoService (ICartaoRepository cartaoRepository) : base (cartaoRepository)
		{
			_cartaoRepository = cartaoRepository;
		}

		public IEnumerable<Cartao> BuscarPorNome(string n)
		{
			return _cartaoRepository.BuscarPorNome(n);
		}
	}
}
