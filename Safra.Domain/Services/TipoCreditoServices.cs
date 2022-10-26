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
    public class TipoCreditoServices : ITipoCreditoServices
    {
        private readonly ITipoCreditoRepository _TipoCreditoRepository;
        private readonly NotificationContext _notificationContext;

        public TipoCreditoServices(ITipoCreditoRepository TipoCreditoRepository)
        {
            _TipoCreditoRepository = TipoCreditoRepository;
            _notificationContext = new NotificationContext();
        }
        public async Task<bool> Delete(int Id)
        {
            return await _TipoCreditoRepository.Delete(Id);
        }

        public async Task<tab_tipo_credito> Find(int Id)
        {
            return await _TipoCreditoRepository.Find(Id);
        }

        public async Task<IEnumerable<tab_tipo_credito>> Find(Expression<Func<tab_tipo_credito, bool>> predicate = null)
        {
            return await _TipoCreditoRepository.Find(predicate);
        }

        public async Task<tab_tipo_credito> Insert(tab_tipo_credito entity)
        {
            //entity.Validate(entity, new TipoCreditoInsert());

            //if (entity.Invalid)
            //    return entity;


            return await _TipoCreditoRepository.Insert(entity);
        }

        public async Task<tab_tipo_credito> Update(tab_tipo_credito entity)
        {
            //entity.Validate(entity, new TipoCreditoUpdate());

            //if (entity.Invalid)
            //    return entity;

            return await _TipoCreditoRepository.Update(entity);
        }
    }
}

