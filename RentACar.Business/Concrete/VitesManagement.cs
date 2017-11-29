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
    public class VitesManagement:ManagementBase<EFVitesDAL,Vites>,IVitesService
    {
        public ICollection<Vites> GetByYakıtTipi(int? item)
        {
            return _dalManagement.GetAll(x => x.Araba.FirstOrDefault().YakıtID == item);
        }
        
    }
}
