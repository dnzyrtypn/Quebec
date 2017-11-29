using RentACar.Model.Entities.Sales;
using RentACar.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class RentACarDbContext:DbContext
    {
        public RentACarDbContext() : base(@"Server=DUYGU\SQLEXPRESS;Database=RentACarQuebec;Integrated Security=true")
        {
            Database.SetInitializer<RentACarDbContext>(new DropCreateDatabaseIfModelChanges<RentACarDbContext>());
        }

        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Araba> Araba { get; set; }
        public DbSet<ArabaSegmenti> ArabaSegmenti { get; set; }
        public DbSet<ArabaModel> ArabaModel { get; set; }
        public DbSet<BagajTipi> BagajTipi { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<KiralamaBilgileri> KiralamaBilgileri { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Ucretler> Ucretler { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Vites> Vites { get; set; }
        public DbSet<YakıtTipi> YakıtTipi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArabaMap());
            modelBuilder.Configurations.Add(new ArabaModelMap());
            modelBuilder.Configurations.Add(new ArabaSegmentiMap());
            modelBuilder.Configurations.Add(new BagajTipiMap());
            modelBuilder.Configurations.Add(new KiralamaBilgileriMap());
            modelBuilder.Configurations.Add(new MarkaMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new UcretlerMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new VitesMap());
            modelBuilder.Configurations.Add(new YakıtTipiMap());
            modelBuilder.Configurations.Add(new FaturaMap());
        }
    }
}
