using DependencyInjection.Model;

namespace DependencyInjection.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUserByID(int Id);
    }
}
