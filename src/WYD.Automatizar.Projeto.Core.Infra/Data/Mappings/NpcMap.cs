using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WYD.Automatizar.Projeto.Core.Domain.Entities;

namespace WYD.Automatizar.Projeto.Core.Infra.Data.Mappings
{
    public class NpcMap : EntityTypeConfiguration<Npc>
    {
        public NpcMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(n => n.MinuteGenerate).IsRequired();
            Property(n => n.MaxNumMob).IsRequired();
            Property(n => n.MinGroup).IsRequired();
            Property(n => n.Leader).IsRequired().HasMaxLength(20);
            Property(n => n.Follower).IsRequired().HasMaxLength(20);
            Property(n => n.RouteType).IsRequired();
            Property(n => n.Formation).IsRequired();
            Property(n => n.StartX).IsRequired();
            Property(n => n.StartY).IsRequired();
            Property(n => n.StartRange).IsRequired();
            Property(n => n.StartWait).IsRequired();
            Property(n => n.DestX).IsRequired();
            Property(n => n.DestY).IsRequired();
            Property(n => n.DestRange).IsRequired();
            Property(n => n.DestWait).IsRequired();
        }
    }
}