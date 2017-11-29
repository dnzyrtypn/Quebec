using RentACar.Business.Abstract;
using RentACar.DataAccess.Concrete.EntityFramework.Sales;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class YakıtTipiManagement:ManagementBase<EFYakıtTipiDAL,YakıtTipi>,IYakıtTipiService
    {
        public ICollection<YakıtTipi> GetByArabaModel(int? item)
        {
            return _dalManagement.GetAll(x => x.Araba.FirstOrDefault().ArabaModelID == item);
        }
    }
}
