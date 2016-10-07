using P1DotNetVF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace P1DotNetVF.Infra.Data.EntityConfig
{
	public class CartaoConfiguration : EntityTypeConfiguration<Cartao>
	{
		public CartaoConfiguration()
		{
			HasKey(c => c.CartaoID);
			Property(c => c.NomeCartao).IsRequired().HasMaxLength(50);
			HasRequired(c => c.Correntista).WithMany().HasForeignKey(p => p.CorrentistaID);
		}

	}
}
