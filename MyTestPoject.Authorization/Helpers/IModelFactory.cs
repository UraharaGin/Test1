using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTestPoject.Authorization.Models;

namespace MyTestPoject.Authorization.Helpers
{
    public interface IModelFactory
    {
        RegisterViewModel RegisterViewModel();

        RegisterViewModel RegisterViewModel(RegisterViewModel register);
    }
}