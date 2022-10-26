using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Infra.Data.Repositories
{
    public class FinanciamentoRepository : BaseRepository<tab_financiamento>, IFinanciamentoRepository
    {
        public FinanciamentoRepository(SafraContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}