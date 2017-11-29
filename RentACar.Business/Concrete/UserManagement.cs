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
    public class UserManagement:ManagementBase<EFUserDAL,User>,IUserService
    {



        public User GetUserByPasswordandMail(string password, string mail)
        {
            return _dalManagement.Get(x => x.Mail == mail && x.Sifre == password);
        }
    }
}
