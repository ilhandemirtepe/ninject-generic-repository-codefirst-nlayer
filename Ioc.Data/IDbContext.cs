using System.Data.Entity;
using Xyzt.Core;
namespace Xyzt.Data
{
   public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
