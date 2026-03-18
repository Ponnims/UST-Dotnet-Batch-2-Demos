using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext cntxt;

        public UserRepository(UserDbContext cntxt)
        {
            this.cntxt = cntxt;
        }
        public User Login(User user)
        {
            return cntxt.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
        }

        public void Register(User user)
        {
            cntxt.Users.Add(user);
            cntxt.SaveChanges();
        }
    }
}
