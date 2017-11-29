using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class KiralamaBilgileri : IEntity
    {
        public int KiralamaID { get; set; }
        public string Plaka { get; set; }
        public DateTime AlısTarihi { get; set; }
        public DateTime İadeTarihi { get; set; }
        public string AlısYeri { get; set; }
        public string İadeYeri { get; set; }
        public string MusteriTc { get; set; }
        public int FaturaID { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }


        //Navigation Properties

        public virtual Araba Araba { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Fatura Fatura { get; set; }


    }
}
