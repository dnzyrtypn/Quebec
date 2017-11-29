using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class Fatura:IEntity
    {
        public int FaturaID { get; set; }
        public decimal FaturaTutari { get; set; }
        public decimal GunlukUcret { get; set; }
        public decimal İndirim { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }


       

        //Navigation Properties

        public virtual KiralamaBilgileri KiralamaBilgileri { get; set; }

    }
}
