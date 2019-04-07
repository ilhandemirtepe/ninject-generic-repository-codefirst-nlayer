using Xyzt.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyzt.Data.Mapping
{
   
    public class DenemeMap : EntityTypeConfiguration<Deneme>
    {
        public DenemeMap()
        {
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.UserDeneme).IsRequired();
           
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
            Property(t => t.IP);
            //table
            ToTable("DenemeTablosuHan");
        }
    }
}
