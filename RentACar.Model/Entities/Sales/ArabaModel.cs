using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
   public class ArabaModel:IEntity
    {
        public int ArabaModelID { get; set; }
        public string ModelAdı { get; set; }
        public int MarkaID { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }


        //Navigation Properties

        public virtual ICollection<Araba> Araba{ get; set; }
        public virtual Marka Marka { get; set; }

    }
}
