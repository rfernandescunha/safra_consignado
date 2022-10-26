using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;

namespace Safra.Infra.Data.Repositories
{
    public class TipoCreditoRepository : BaseRepository<tab_tipo_credito>, ITipoCreditoRepository
    {
        public TipoCreditoRepository(SafraContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}