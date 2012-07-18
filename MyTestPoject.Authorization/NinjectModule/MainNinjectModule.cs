
using MyTestPoject.Authorization.Core;
using MyTestPoject.Authorization.Domain;
using MyTestPoject.Authorization.Helpers;

namespace MyTestPoject.Authorization.NinjectModule
{
    using Ninject.Modules;
    public class MainNinjectModule : NinjectModule
    {

        public override void Load()
        {
            Bind<DataBaseContext>().ToMethod(it => new DataBaseContext());
            Bind<IRepository>().To<Repository>();
            Bind<IAuthenticator>().To<Authenticator>();
            Bind<Gender>().ToMethod(it => new Gender());
            Bind<MatrialStatus>().ToMethod(it => new MatrialStatus());
            Bind<IModelFactory>().To<ModelFactory>();
        }
    }
}

