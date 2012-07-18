using System;
using System.Linq;
using MyTestPoject.Authorization.Domain;


namespace MyTestPoject.Authorization.Core
{
    public class Authenticator : IAuthenticator
    {
        private readonly IRepository _repository;

        public Authenticator(IRepository repository)
        {
            _repository = repository;
        }

        public void CreateUser(User user)
        {
            if(this._repository.GetUsers().Any(x => x.EMail == user.EMail))
            {
                throw new UserCreateMailAlreadyUsingExeption();
            }
            this._repository.AddUser(user);
        }

        public bool ValidateUser(string eMail, string password)
        {
            if(_repository.GetUsers().Any(it => it.Password == password && eMail.ToLower() == it.EMail.ToLower()))
            {
                return true;
            }
            return false;
        }
    }

    public class UserCreateMailAlreadyUsingExeption : Exception
    {
    }
}