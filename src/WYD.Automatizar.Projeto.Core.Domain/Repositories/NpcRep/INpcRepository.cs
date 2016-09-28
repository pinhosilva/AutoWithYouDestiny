using System.Collections.Generic;
using System.Threading.Tasks;
using WYD.Automatizar.Projeto.Core.Domain.Entities;

namespace WYD.Automatizar.Projeto.Core.Domain.Repositories.NpcRep
{
    public interface INpcRepository : IRepositoryBase<Npc>
    {
        Task<IEnumerable<Npc>> GetAllAsync();
        Task InsertAsync(Npc cidade);
        Task DeleteAsync(Npc cidade);
        Task UpdateAsync(Npc entity);
    }
}