﻿using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAccess.Abstract;
using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework.Sales
{
    public class EFVitesDAL : EFEntityRepositoryBase<RentACarDbContext, Vites>, IVitesDAL
    {
    }
}
