using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Mapping
{
    public class UcretlerMap : EntityTypeConfiguration<Ucretler>
    {
        public UcretlerMap()
        {
            HasKey(x => x.UcretID);
            Property(x => x.UcretID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GunlukUcret).IsRequired();
            Property(x => x.HaftalikUcret).IsRequired();
            Property(x => x.AylikUcret).IsRequired();
            Property(x => x.YillikUcret).IsRequired();
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();

            HasOptional(x => x.Araba).WithRequired(x => x.Ucret);
        }
    }
}
