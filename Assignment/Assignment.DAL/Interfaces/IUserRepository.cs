using Assignment.DomainModel.Models;

namespace Assignment.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
    }
}
