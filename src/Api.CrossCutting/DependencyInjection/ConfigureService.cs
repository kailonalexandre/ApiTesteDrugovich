using Api.Domain.Interfaces.Services.Client;
using Api.Domain.Interfaces.Services.Group;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Domain.Interfaces.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IClientService, ClientService>();
            serviceCollection.AddTransient<IGroupService, GroupService>();

        }
    }
}
