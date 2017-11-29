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
    public class ArabaModelMap : EntityTypeConfiguration<ArabaModel>
    {
        public ArabaModelMap()
        {
            HasKey(x => x.ArabaModelID);
            Property(x => x.ArabaModelID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ModelAdı).IsRequired().HasMaxLength(50);
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();


            HasRequired(x => x.Marka).WithMany(x => x.ArabaModel).HasForeignKey(x => x.MarkaID);

        }
    }
}
