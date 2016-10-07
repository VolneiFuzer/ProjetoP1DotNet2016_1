using P1DotNetVF.Domain.Entities;
using P1DotNetVF.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace P1DotNetVF.Infra.Data.Context
{
	public class P1DotNetVFContext : DbContext 
	{
		public P1DotNetVFContext() : base("P1DotNetVF")
		{
		}

		public DbSet <Correntista> Correntistas{ get; set; }
		public DbSet<Cartao> Cartoes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
			modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());
			modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
			modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
			modelBuilder.Configurations.Add(new CorrentistaConfiguration());
			modelBuilder.Configurations.Add(new CartaoConfiguration());
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DTCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DTCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DTCadastro").IsModified = false;
				}

			}
			return base.SaveChanges();
		}
	}
}
