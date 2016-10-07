using P1DotNetVF.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace P1DotNetVF.Infra.Data.Context
{
	public class Context : DbContext 
	{
		public Context() : base("P1DotNetVF")
		{
		}

		public DbSet <Correntista> Correntistas{ get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
			modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());
			modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
			modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("")
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DTCadastro").CurrentVal //48min15seg
				}

			}
			return base.SaveChanges();
		}
	}
}
