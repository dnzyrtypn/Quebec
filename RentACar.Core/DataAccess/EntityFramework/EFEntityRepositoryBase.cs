using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace RentACar.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TContext,TEntity>:IEntityRepository<TEntity>
        where TContext : DbContext,new()
        where TEntity: class,IEntity,new()
    {
        public void Add(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using(TContext context=new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity,bool >>filter=null)
        {
            using(TContext context=new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault();
            }

        }

       public TEntity GetByID(int? item)
       {
           using (TContext context = new TContext())
           {

               return context.Set<TEntity>().Find(item);
           }
              
       }
        

        public ICollection<TEntity> GetAll(Expression<Func<TEntity,bool >>filter=null)
        {
            using(TContext context=new TContext())
            {

                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }

        }
        public void Update(TEntity entity)
        {
            using(TContext context=new TContext())
            {
            var updateEntity=context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();

            }
        }

    }
}
