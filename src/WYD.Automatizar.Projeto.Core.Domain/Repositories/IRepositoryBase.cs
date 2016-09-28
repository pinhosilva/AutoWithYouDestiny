using System.Threading.Tasks;

namespace WYD.Automatizar.Projeto.Core.Domain.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}