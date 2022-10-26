using Safra.Domain.Entities;
using Safra.Domain.Interfaces.IRepository;
using Safra.Domain.Interfaces.IServices;
using Safra.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Safra.Domain.Services
{
    public class ParcelaServices : IParcelaServices
    {
        private readonly IParcelaRepository _ParcelaRepository;
        private readonly NotificationContext _notificationContext;

        public ParcelaServices(IParcelaRepository ParcelaRepository)
        {
            _ParcelaRepository = ParcelaRepository;
            _notificationContext = new NotificationContext();
        }
        public async Task<bool> Delete(int Id)
        {
            return await _ParcelaRepository.Delete(Id);
        }

        public async Task<tab_parcela> Find(int Id)
        {
            return await _ParcelaRepository.Find(Id);
        }

        public async Task<IEnumerable<tab_parcela>> Find(Expression<Func<tab_parcela, bool>> predicate = null)
        {
            return await _ParcelaRepository.Find(predicate);
        }

        public async Task<tab_parcela> Insert(tab_parcela entity)
        {
            //entity.Validate(entity, new ParcelaInsert());

            //if (entity.Invalid)
            //    return entity;


            return await _ParcelaRepository.Insert(entity);
        }

        public async Task<tab_parcela> Update(tab_parcela entity)
        {
            //entity.Validate(entity, new ParcelaUpdate());

            //if (entity.Invalid)
            //    return entity;

            return await _ParcelaRepository.Update(entity);
        }
    }
}

