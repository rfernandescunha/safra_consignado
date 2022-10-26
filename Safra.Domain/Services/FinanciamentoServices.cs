using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using Safra.Domain.Interfaces.IServices;
using Safra.Domain.Notifications;
using Safra.Domain.Validation.Financiamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Services
{
    public class FinanciamentoServices : IFinanciamentoServices
    {
        private readonly IFinanciamentoRepository _financiamentoRepository;
        private readonly NotificationContext _notificationContext;

        public FinanciamentoServices(IFinanciamentoRepository FinanciamentoRepository)
        {
            _financiamentoRepository = FinanciamentoRepository;
            _notificationContext = new NotificationContext();
        }
        public async Task<bool> Delete(int Id)
        {
            return await _financiamentoRepository.Delete(Id);
        }

        public async Task<tab_financiamento> Find(int Id)
        {
            return await _financiamentoRepository.Find(Id);
        }

        public async Task<IEnumerable<tab_financiamento>> Find(Expression<Func<tab_financiamento, bool>> predicate = null)
        {
            return await _financiamentoRepository.Find(predicate);
        }

        public async Task<tab_financiamento> Insert(tab_financiamento entity)
        {
            entity.Validate(entity, new FinanciamentoInsert());

            if (entity.Invalid)
                return entity;


            return await _financiamentoRepository.Insert(entity);
        }

        public async Task<tab_financiamento> Update(tab_financiamento entity)
        {
            entity.Validate(entity, new FinanciamentoUpdate());

            if (entity.Invalid)
                return entity;

            return await _financiamentoRepository.Update(entity);
        }
    }
}

