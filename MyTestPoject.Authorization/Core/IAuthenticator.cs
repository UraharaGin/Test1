using MyTestPoject.Authorization.Domain;

namespace MyTestPoject.Authorization.Core
{
    public interface IAuthenticator
    {
        void CreateUser(User user);

        bool ValidateUser(string eMail, string password);
    }
}