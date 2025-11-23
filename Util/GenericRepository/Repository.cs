using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Util.GenericRepository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _set;

        protected Repository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _set = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _set.Add(entity);
        }

        public void AddAll(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException(nameof(entities));

            _set.AddRange(entities);
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate != null ? _set.Any(predicate) : _set.Any();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate != null ? _set.Count(predicate) : _set.Count();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _set.Remove(entity);
        }

        public void DeleteAll(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException(nameof(entities));

            _set.RemoveRange(entities);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate = null, params string[] includes)
        {
            IQueryable<TEntity> data = predicate != null ? _set.AsNoTracking().Where(predicate) : _set.AsNoTracking();

            foreach (var include in includes)
            {
                data = data.Include(include);
            }

            return data;
        }

        public TEntity FindById(object entityKey)
        {
            return _set.Find(entityKey);
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _set.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
