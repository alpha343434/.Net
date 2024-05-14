using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity_Framework
{
    public class EfReposityoryBaseClass<T, TContext> : IEntityRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void AddProduct(T entity)
        {
            using(TContext context = new TContext()) // for efficient memory
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void UpdateProduct(T entity) 
        {
            using (TContext context = new TContext()) 
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(T entity) 
        {
            using (TContext context = new TContext()) 
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter = null) 
        {
            using(TContext context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }
        public T Get(Expression<Func<T,bool>> filter) 
        {
            using(TContext context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }
    }
}
