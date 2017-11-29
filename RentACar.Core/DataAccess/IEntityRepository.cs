using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.DataAccess
{
    public interface IEntityRepository<T> where T :class,IEntity
    {
        void Add(T entity);
        void Delete(T entitiy);
        void Update(T entity);
        T GetByID(int? item);
        T Get(Expression<Func<T, bool>> filter = null);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
