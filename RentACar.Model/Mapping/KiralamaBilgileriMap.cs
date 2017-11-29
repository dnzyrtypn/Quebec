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
    public class KiralamaBilgileriMap : EntityTypeConfiguration<KiralamaBilgileri>
    {
        public KiralamaBilgileriMap()
        {
            HasKey(x => x.KiralamaID);
            Property(x => x.KiralamaID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AlısTarihi).IsRequired();
            Property(x => x.İadeTarihi).IsRequired();
            Property(x => x.İadeYeri).IsRequired(); 
            Property(x => x.AlısYeri).IsRequired();
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();


            HasRequired(x => x.Araba).WithMany(x => x.KiralamaBilgileri).HasForeignKey(x => x.Plaka);
            HasRequired(x => x.Musteri).WithMany(x => x.KiralamaBilgileri).HasForeignKey(x => x.MusteriTc);
            HasRequired(x => x.Fatura).WithRequiredPrincipal(x => x.KiralamaBilgileri);



        }
    }
}
