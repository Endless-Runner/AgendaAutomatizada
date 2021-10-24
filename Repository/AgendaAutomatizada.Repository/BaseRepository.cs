using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAutomatizada.Repository
{
    public class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity : class
    {
        protected AgendaDbContext context { get; private set; }

        public BaseRepository(AgendaDbContext dbContext)
        {
            context = dbContext;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public virtual TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual TEntity GetCompositeKey(int firstId, int secondId)
        {
            return context.Set<TEntity>().Find(firstId, secondId);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }


        public void Add(TEntity entity)
        {
            var entry = context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                context.Set<TEntity>().Add(entity);
            }
            else
            {
                entry.State = EntityState.Modified;
            }
        }

        public void AddAll(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Add(entity);
            }
        }

        public void Remove(TEntity entity)
        {
            var entry = context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                context.Set<TEntity>().Attach(entity);
            }
            context.Entry<TEntity>(entity).State = EntityState.Deleted;
        }

        public void RemoveAll(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Remove(entity);
            }
        }

        public void RefreshEntity(TEntity entity)
        {
            context.Entry<TEntity>(entity).Reload();
        }
    }
}
