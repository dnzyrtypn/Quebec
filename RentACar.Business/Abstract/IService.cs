using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IService<TEntity>
    {


            void Add(TEntity item);

            void Delete(TEntity item);

            void Update(TEntity item);

            TEntity GetByID(int? item);


            ICollection<TEntity> GetAll();

        }
    }

