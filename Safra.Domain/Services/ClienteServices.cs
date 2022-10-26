using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using Safra.Domain.Interfaces.IServices;
using Safra.Domain.Notifications;
using Safra.Domain.Validation.Cliente;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Safra.Domain.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly NotificationContext _notificationContext;

        public ClienteServices(IClienteRepository ClienteRepository)
        {
            _clienteRepository = ClienteRepository;
            _notificationContext = new NotificationContext();
        }
        public async Task<bool> Delete(int Id)
        {
            return await _clienteRepository.Delete(Id);
        }

        public async Task<tab_cliente> Find(int Id)
        {
            return await _clienteRepository.Find(Id);
        }

        public async Task<IEnumerable<tab_cliente>> Find(Expression<Func<tab_cliente, bool>> predicate = null)
        {
            return await _clienteRepository.Find(predicate);
        }

        public async Task<tab_cliente> Insert(tab_cliente entity)
        {
            entity.Validate(entity, new ClienteInsert());

            if (entity.Invalid)
                return entity;


            return await _clienteRepository.Insert(entity);
        }

        public async Task<tab_cliente> Update(tab_cliente entity)
        {
            entity.Validate(entity, new ClienteUpdate());

            if (entity.Invalid)
                return entity;

            return await _clienteRepository.Update(entity);
        }
    }
}

