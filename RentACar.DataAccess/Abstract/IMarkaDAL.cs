using RentACar.Core.DataAccess;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstract
{
    public interface IMarkaDAL : IEntityRepository<Marka>
    {
    }
}
