using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Mapping
{
    public class ArabaMap : EntityTypeConfiguration<Araba>
    {
        public ArabaMap()
        {
            ToTable("Arabalar");
            HasKey(x => x.Plaka);

            Property(x => x.SasiNo).IsRequired();
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();
            
            HasRequired(x => x.Vites).WithMany(x=>x.Araba).HasForeignKey(x => x.VitesID);
            HasRequired(x => x.BagajTipi).WithMany(x => x.Araba).HasForeignKey(x => x.BagajID);
            HasRequired(x => x.ArabaModel).WithMany(x => x.Araba).HasForeignKey(x => x.ArabaModelID);
            HasRequired(x => x.ArabaSegmenti).WithMany(x => x.Araba).HasForeignKey(x => x.SegmentID);
            HasRequired(x => x.YakıtTipi).WithMany(x => x.Araba).HasForeignKey(x => x.YakıtID);
            //HasRequired(x => x.Ucret).WithOptional(x => x.Araba);  //bir e bir ilişkide withRequredDependent olabilir mi tartışalım
                   
            
        }
    }
}
