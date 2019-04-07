using System.Linq;
using Xyzt.Core.Data;

namespace Xyzt.Service
{
   public interface IUserService
    {
       IQueryable<User> GetUsers();
       User GetUser(long id);
       void InsertUser(User user);
       void UpdateUser(User user);
       void DeleteUser(User user);
    }
}
