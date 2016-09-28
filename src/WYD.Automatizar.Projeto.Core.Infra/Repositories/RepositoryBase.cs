using System;
using System.Threading.Tasks;
using WYD.Automatizar.Projeto.Core.Domain.Repositories;
using WYD.Automatizar.Projeto.Core.Infra.Data;

namespace WYD.Automatizar.Projeto.Core.Infra.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected WydContext Db = new WydContext();

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Db.Set<TEntity>().FindAsync(id);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}