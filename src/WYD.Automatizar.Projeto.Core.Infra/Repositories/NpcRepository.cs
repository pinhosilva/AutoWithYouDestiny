using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using WYD.Automatizar.Projeto.Core.Domain.Entities;
using WYD.Automatizar.Projeto.Core.Domain.Repositories;
using WYD.Automatizar.Projeto.Core.Domain.Repositories.NpcRep;

namespace WYD.Automatizar.Projeto.Core.Infra.Repositories
{
    public class NpcRepository : RepositoryBase<Npc>, INpcRepository
    {
        public async Task DeleteAsync(Npc npc)
        {
            Db.Set<Npc>().Attach(npc);
            Db.Set<Npc>().Remove(npc);

            await Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Npc>> GetAllAsync()
        {
            return await Db.Set<Npc>().ToListAsync();
        }

        public async Task InsertAsync(Npc npc)
        {
            Db.Set<Npc>().Add(npc);
            await Db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Npc npc)
        {
            Db.Entry(npc).State = EntityState.Modified;
            await Db.SaveChangesAsync();
        }
    }
}