using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using MyTestPoject.Authorization.Domain;

namespace MyTestPoject.Authorization.Core
{
    public interface IRepository
    {
        void AddUser(User user);

        IEnumerable<User> GetUsers();
        IEnumerable<MatrialStatus> GetMatrialStatuses();
        IEnumerable<Gender> GetGenders();
    }
}