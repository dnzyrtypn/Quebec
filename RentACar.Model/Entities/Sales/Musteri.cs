using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class Musteri:IEntity
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string EhliyetFotokopisi { get; set; }
        public string Adress { get; set; }
        public string TelefonNo { get; set; }
        public string Mail { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properties

        public virtual User User { get; set; }
        public virtual ICollection<KiralamaBilgileri> KiralamaBilgileri { get; set; }

        


        
    }
}
