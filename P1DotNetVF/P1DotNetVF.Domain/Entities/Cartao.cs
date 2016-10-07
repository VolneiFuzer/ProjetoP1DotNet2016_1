namespace P1DotNetVF.Domain.Entities
{
	public class Cartao
	{
		public int CartaoID { get; set; }
		public string NomeCartao { get; set; }
		public int Limite { get; set; }
		public int CorrentistaID { get; set; }
		public virtual Correntista Correntista { get; set; }
	}
}
