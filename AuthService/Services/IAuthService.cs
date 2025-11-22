namespace AuthService.Services
{
    public interface IAuthService
    {
        void Register(string fullName, string email, string password);
    }
}
