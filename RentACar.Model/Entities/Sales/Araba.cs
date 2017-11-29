using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
   public class Araba:IEntity
    {
        public string Plaka { get; set; }
        public Guid SasiNo { get; set; }
        public int Kapasite { get; set; }
        public int Kilometre { get; set; }
        public string Fotograf { get; set; }
        public int ModelYılı { get; set; }
        public int ArabaModelID { get; set; }
        public int YakıtID { get; set; }
        public int VitesID { get; set; }
        //public int UcretlerID { get; set; }
        public int BagajID { get; set; }
        public int SegmentID { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properties

        public virtual ArabaModel ArabaModel{ get; set; }
        public virtual YakıtTipi YakıtTipi { get; set; }
        public virtual Vites Vites { get; set; }
        public virtual Ucretler Ucret { get; set; }   //buradaki baglantıdan emin degilim,kontrol edelim.
        public virtual BagajTipi BagajTipi { get; set; }
        public virtual ArabaSegmenti ArabaSegmenti { get; set; }
        public virtual ICollection<KiralamaBilgileri> KiralamaBilgileri { get; set; }
    
       



    }
}
