using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safra.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<tab_cliente>, IClienteRepository
    {
        public ClienteRepository(SafraContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}