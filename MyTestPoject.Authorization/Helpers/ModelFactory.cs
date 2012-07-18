using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyTestPoject.Authorization.Core;
using MyTestPoject.Authorization.Models;

namespace MyTestPoject.Authorization.Helpers
{
    public class ModelFactory : IModelFactory
    {
        private readonly IRepository _repository;

        public ModelFactory(IRepository repository)
        {
            _repository = repository;
        }

        public RegisterViewModel RegisterViewModel()
        {
            var register = new RegisterViewModel();

            var genders = _repository.GetGenders();
            IEnumerable<SelectListItem> genderItems = from gender in genders
                                                      select new SelectListItem
                                                                 {
                                                                     Text = gender.GenderName,
                                                                     Value = gender.GenderId.ToString()
                                                                 };
            register.PossibleGenders = (genderItems);

            var matrials = _repository.GetMatrialStatuses();
            IEnumerable<SelectListItem> matrialItems = from matrial in matrials
                                                      select new SelectListItem
                                                      {
                                                          Text = matrial.MatrialStatusName,
                                                          Value = matrial.MatrialStatusId.ToString()
                                                      };
            register.PossibleMatrialStatus = (matrialItems);

            return register;
        }

        public RegisterViewModel RegisterViewModel(RegisterViewModel register)
        {
            var newRegister = register;
            var posibles = RegisterViewModel();
            newRegister.PossibleGenders = posibles.PossibleGenders;
            newRegister.PossibleMatrialStatus = posibles.PossibleMatrialStatus;

            return register;
        }
    }
}