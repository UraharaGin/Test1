using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyTestPoject.Authorization.Domain;

namespace MyTestPoject.Authorization.Core
{
    
    class Repository : IRepository
    {
        private readonly DataBaseContext _dataBaseContex;

        public Repository(DataBaseContext dataBaseContex)
        {
            _dataBaseContex = dataBaseContex;
        }


        public void AddUser(User user)
        {
            this._dataBaseContex.Users.Add(user);
            this._dataBaseContex.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _dataBaseContex.Users;
        }

        public IEnumerable<MatrialStatus> GetMatrialStatuses()
        { 
            return _dataBaseContex.MatrialStatuses;
        }

        public IEnumerable<Gender> GetGenders()
        {
            return _dataBaseContex.Genders;
        }
    }
}