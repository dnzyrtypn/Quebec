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
  
    public class FaturaManagement:ManagementBase<EFFaturaDAL,Fatura>,IFaturaService
    {

        public Fatura GetByID(int item)
        {
            return _dalManagement.Get(a => a.FaturaID == item);
        }
    }
}
