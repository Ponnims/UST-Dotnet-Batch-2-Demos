namespace AuthenticationService.Services
{
    public interface ITokenGenerator
    {
        string GenerateToken(string email);
    }
}
