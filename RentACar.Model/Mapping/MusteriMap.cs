using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Mapping
{
    public class MusteriMap : EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            HasKey(x => x.TC);
            Property(x => x.Ad).IsRequired().HasMaxLength(50);
            Property(x => x.Adress).IsRequired();
            Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            Property(x => x.TelefonNo).IsRequired().HasMaxLength(50);
            Property(x => x.DogumTarihi).IsRequired();
            Property(x => x.CreatedByID).IsOptional();
            Property(x => x.CreatedOn).IsOptional();
            Property(x => x.IsActive).IsOptional();





            HasRequired(x => x.User).WithOptional(x => x.Musteri);
        }
    }
}
