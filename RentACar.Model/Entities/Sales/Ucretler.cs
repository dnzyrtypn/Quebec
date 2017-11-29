using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class Ucretler : IEntity
    {
        public int UcretID  { get; set; }
        public decimal GunlukUcret { get; set; }
        public decimal HaftalikUcret { get; set; }
        public decimal AylikUcret { get; set; }
        public decimal YillikUcret { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properties

        public virtual Araba Araba { get; set; }
       

        
    }
}
