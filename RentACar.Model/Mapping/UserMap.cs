using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.TC);
            Property(x => x.Sifre).IsRequired();
            Property(x => x.CreatedByID).IsOptional();
            Property(x => x.CreatedOn).IsOptional();
            Property(x => x.IsActive).IsOptional();

            
        }
    }
}
