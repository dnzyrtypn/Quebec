using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class User : IEntity
    {
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properties

        public virtual Musteri Musteri { get; set; }
       
    }
}
