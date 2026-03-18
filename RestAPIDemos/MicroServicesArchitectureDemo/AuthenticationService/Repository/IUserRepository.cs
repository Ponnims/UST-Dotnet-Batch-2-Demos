using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(User user);
    }
}
