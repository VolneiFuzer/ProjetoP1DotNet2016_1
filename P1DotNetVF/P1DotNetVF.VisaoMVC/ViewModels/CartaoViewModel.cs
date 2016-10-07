
using System.ComponentModel.DataAnnotations;

namespace P1DotNetVF.VisaoMVC.ViewModels
{
	public class CartaoViewModel
	{
		[Key]
		public int CartaoID { get; set; }

		[Required(ErrorMessage = "Preencha o Campo Nome")]
		[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string NomeCartao { get; set; }

		[DataType(DataType.Currency)]
		[Range(typeof(decimal), "0", "999999999999")]
		[Required(ErrorMessage = "Preencha o limite")]
		public int Limite { get; set; }

		public int CorrentistaID { get; set; }

		public virtual CorrentistaViewModel Correntistas { get; set; }


	}
}