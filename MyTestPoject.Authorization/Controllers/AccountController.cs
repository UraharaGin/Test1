using System;
using System.Web.Mvc;
using MyTestPoject.Authorization.Core;
using MyTestPoject.Authorization.Domain;
using MyTestPoject.Authorization.Helpers;
using MyTestPoject.Authorization.Models;

namespace MyTestPoject.Authorization.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticator _authenticator;
        private readonly IModelFactory _modelFactory;

        public AccountController(IAuthenticator authenticator, IModelFactory modelFactory)
        {
            _authenticator = authenticator;
            _modelFactory = modelFactory;
        }

        [HttpGet]
        public ActionResult Register()
        {
            var model = _modelFactory.RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                               {
                                   DayOfBirth = register.DayOfBirth,
                                   EMail = register.EMail,
                                   FirstName = register.FirstName,
                                   GenderId = Guid.Parse(register.Gender),
                                   MatrialStatusId = Guid.Parse(register.MatrialStatus),
                                   LastName = register.LastName,
                                   Password = register.Password,
                                   UserId = Guid.NewGuid()
                               };
                try
                {
                    _authenticator.CreateUser(user);
                }
                catch (UserCreateMailAlreadyUsingExeption)
                {
                    register = _modelFactory.RegisterViewModel(register);
                    return View(register);
                }
            }
            register.PossibleGenders = _modelFactory.RegisterViewModel().PossibleGenders;
            register.PossibleMatrialStatus = _modelFactory.RegisterViewModel().PossibleMatrialStatus;
            return View();
        }

        [HttpGet]
        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(Logon model)
        {
            return View();
        }
    }

    public class Logon
    {
    }
}
