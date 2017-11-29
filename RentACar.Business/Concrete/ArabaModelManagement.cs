using RentACar.Business.Abstract;
using RentACar.DataAccess.Abstract;
using RentACar.DataAccess.Concrete.EntityFramework.Sales;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class ArabaModelManagement:ManagementBase<EFArabaModelDAL,ArabaModel>, IArabaModelService

    {


        public ICollection<ArabaModel> GetByArabaSegmenti(int? item)
        {
            return _dalManagement.GetAll(a => a.Araba.FirstOrDefault().SegmentID == item);
        }


        public ICollection<ArabaModel> GetByBagajTipi(int? item)
        {
            return _dalManagement.GetAll(a => a.Araba.FirstOrDefault().BagajID == item);
        }


        public ICollection<ArabaModel> GetByMarka(int? item)
        {
            return _dalManagement.GetAll(a => a.Marka.MarkaID == item);
        }


        public ICollection<ArabaModel> GetByVites(int? item)
        {
            return _dalManagement.GetAll(a => a.Araba.FirstOrDefault().VitesID == item);
        }

        public ICollection<ArabaModel> GetByYakıtTipi(int? item)
        {
            return _dalManagement.GetAll(a => a.Araba.FirstOrDefault().YakıtID == item);
        }
    }
}
