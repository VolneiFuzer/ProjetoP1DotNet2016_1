using P1DotNetVF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace P1DotNetVF.Infra.Data.EntityConfig
{
	public class CorrentistaConfiguration : EntityTypeConfiguration<Correntista>
	{
		public CorrentistaConfiguration()
		{
			HasKey(c => c.CorrentistaID);
			Property(c => c.Nome).IsRequired().HasMaxLength(50);
			Property(c => c.Sobrenome).IsRequired().HasMaxLength(50);
			Property(c => c.CPF).IsRequired();
		}
	}
}
