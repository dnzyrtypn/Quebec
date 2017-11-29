using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Entities.Sales
{
    public class ArabaSegmenti: IEntity
    {
        public int SegmentID { get; set; }
        public string  SegmentAdi { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properties

        public virtual ICollection<Araba> Araba { get; set; }



    }
}
