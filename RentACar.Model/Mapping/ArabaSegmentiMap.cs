﻿using RentACar.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model.Mapping
{
    public class ArabaSegmentiMap : EntityTypeConfiguration<ArabaSegmenti>
    {
        public ArabaSegmentiMap()
        {
            HasKey(x => x.SegmentID);
            Property(x => x.SegmentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SegmentAdi).IsRequired().HasMaxLength(50);
            Property(x => x.CreatedByID).IsRequired();
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.IsActive).IsRequired();
        }
    }
}