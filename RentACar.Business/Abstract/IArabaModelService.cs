using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IArabaModelService:IService<ArabaModel>
    {
        ICollection<ArabaModel> GetByArabaSegmenti(int? item);
        ICollection<ArabaModel> GetByBagajTipi(int? item);

        ICollection<ArabaModel> GetByMarka(int? item);
        ICollection<ArabaModel> GetByVites(int? item);
        ICollection<ArabaModel> GetByYakıtTipi(int? item);

    }
}
