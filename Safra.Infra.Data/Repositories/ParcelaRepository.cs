using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Infra.Data.Repositories
{
    public class ParcelaRepository : BaseRepository<tab_parcela>, IParcelaRepository
    {
        public ParcelaRepository(SafraContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}