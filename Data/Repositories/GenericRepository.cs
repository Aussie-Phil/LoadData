using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace Data.Repositories
{
    //Quite standard - this is very similar to one used at work

    /// <summary>
    /// Base repository class - holds all the methods ofr standard usage of the DB.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public class GenericRepository<TEntity, TKey> where TEntity : class
    {
        private NodeDBContext _nodeDbContext;

        protected GenericRepository()
        {
        }

        protected GenericRepository(NodeDBContext nodeDBContext)
        {
            _nodeDbContext = nodeDBContext;
        }


        public NodeDBContext Context
        {
            get
            {
                if (_nodeDbContext == null)
                    _nodeDbContext = new NodeDBContext();

                return _nodeDbContext;
            }
            set { _nodeDbContext = value; }
        }

        public virtual IEnumerable<TEntity> ExecuteSqlQuery(string sql, params object[] parameters)
        {
            return Context.Database.SqlQuery<TEntity>(sql, parameters);
        }

        protected void ExecuteSqlCommand(string sql, params object[] parameters)
        {
            Context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public virtual IQueryable<TEntity> AsQueryable()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            return query;
        }

        public virtual TEntity GetSingle(TKey id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public virtual void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual int Save()
        {
            int updateCount = 0;

            try
            {
                updateCount = Context.SaveChanges();
            }
            catch (Exception validationException)
            {
                throw new DbEntityValidationException("Can't save." + validationException.InnerException, validationException);
            }

            return updateCount;
        }
    }
}

