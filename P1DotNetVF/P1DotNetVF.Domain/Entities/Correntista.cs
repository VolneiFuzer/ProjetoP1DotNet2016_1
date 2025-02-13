﻿using System;
using System.Collections.Generic;

namespace P1DotNetVF.Domain.Entities
{
	public class Correntista
	{
		public int CorrentistaID { get; set; }
		public int NumContaCorrente { get; set; }
		public long CPF { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public int SaldoCC { get; set; }
		public DateTime  DTCadastro { get; set; }
		public bool Ativo { get; set; }
		public virtual IEnumerable<Cartao> Cartoes { get; set; }

		public void CompraComCartaoCredito()
		{
		}

		public void CompraComCartãoDebito()
		{
		}

		public bool getCorrentistaAtivo(Correntista correntista)
		{
			return this.Ativo;
		}
				
	}
}
