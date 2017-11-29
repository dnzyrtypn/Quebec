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
    public class FaturaMap : EntityTypeConfiguration<Fatura>
    {
        public FaturaMap()
        {
            HasKey(x => x.FaturaID);
            Property(x => x.FaturaID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FaturaTutari).IsRequired();
            Property(x => x.İndirim).IsRequired();
            Property(x => x.GunlukUcret).IsRequired();
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();

          
        }

    }
}
