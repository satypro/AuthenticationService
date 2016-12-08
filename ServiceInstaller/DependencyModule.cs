using AuthenticationService.Services;
using Autofac;

namespace AuthenticationService.ServiceInstaller
{
    public class DependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();        
        }
    }
} 