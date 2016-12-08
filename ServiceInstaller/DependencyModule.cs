using AadharAuthService.Services;
using Autofac;

namespace AadharAuthService.ServiceInstaller
{
    public class DependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();        
        }
    }
} 