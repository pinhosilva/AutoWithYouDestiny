using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using WYD.Automatizar.Projeto.Core.Domain.Entities;
using WYD.Automatizar.Projeto.Core.Infra.Data.Mappings;
using WYD.Automatizar.Projeto.Core.Infra.Migrations;

namespace WYD.Automatizar.Projeto.Core.Infra.Data
{
    public class WydContext : DbContext
    {
        public WydContext()
           : base("WydContext")
        {

        }

        public virtual DbSet<Npc> Npcs { get; set; }

        static WydContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WydContext,Configuration>());
        }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Foi Removido Pluralização de Tabelas
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>(); //Foi Removido Plurarização de Entidades
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Foi Removido o modo de deletar em cascata de N:N
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //foi removido o mode de deletar em cascata de 1:N

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(NpcMap)));//Pega todas as configurações de map do caminho informado

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(250));
        }
    }
}