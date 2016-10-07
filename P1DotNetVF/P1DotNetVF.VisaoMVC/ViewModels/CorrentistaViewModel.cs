
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P1DotNetVF.VisaoMVC.ViewModels
{
	public class CorrentistaViewModel
	{
		[Key]
		public int CorrentistaID { get; set; }

		[Required(ErrorMessage = "Preencha a conta corrente")]
		public int NumContaCorrente { get; set; }

		[Required(ErrorMessage = "Preencha o CPG")]
		public long CPF { get; set; }

		[Required(ErrorMessage = "Preencha o Campo Nome")]
		[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Preencha o Campo Nome")]
		[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Sobrenome { get; set; }

		[DataType(DataType.Currency)]
		[Range(typeof(decimal), "0", "999999999999")]
		[Required(ErrorMessage = "Preencha o saldo inicial")]
		public int SaldoCC { get; set; }

		[ScaffoldColumn(false)]
		public DateTime DTCadastro { get; set; }
		public bool Ativo { get; set; }
		public virtual IEnumerable<CartaoViewModel> Cartoes { get; set; }

	}
}