using System.Data.Entity.ModelConfiguration;
using Xyzt.Core.Data;

namespace Xyzt.Data.Mapping
{
   public class UserMap :EntityTypeConfiguration<User> 
    {
       public UserMap()
       {
           //key
           HasKey(t => t.ID);
           //properties
           Property(t => t.UserName).IsRequired();
           Property(t => t.Email).IsRequired();
           Property(t => t.Password).IsRequired();
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();
           Property(t => t.IP);
           //table
           ToTable("UsersDeneme");
       }
    }
}
