using RentACar.Business.Abstract;
using RentACar.Core.DataAccess;
using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business
{
    public class ManagementBase<DalClass, TEntity> : IService<TEntity>
        where DalClass : IEntityRepository<TEntity>, new()
        where TEntity : class,IEntity, new()
    {
        public DalClass _dalManagement;
        public ManagementBase()
        {
            _dalManagement = new DalClass();
        }
        public void Add(TEntity item)
        {
            _dalManagement.Add(item);

        }

        public void Delete(TEntity item)
        {
            _dalManagement.Delete(item);
        }

        public void Update(TEntity item)
        {
            _dalManagement.Update(item);
        }

        public TEntity GetByID(int? item)
        {
            return _dalManagement.GetByID(item);
        }

        public ICollection<TEntity> GetAll()
        {
            return _dalManagement.GetAll();
        }
    }
}
