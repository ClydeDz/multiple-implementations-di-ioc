using ConsoleDemoApp;
using ConsoleDemoApp.Implementation;
using ConsoleDemoApp.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


IHostBuilder CreateHostBuilder(string[] strings)
{

    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) =>
        {
            services.AddScoped<Domestic>();
            services.AddScoped<Wild>();

            services.AddTransient<Func<AnimalTypes, IAnimals>>(serviceProvider => serviceTypeName =>
            {
                switch (serviceTypeName)
                {
                    case AnimalTypes.Domestic:
                        return serviceProvider.GetService<Domestic>()!;
                    case AnimalTypes.Wild:
                        return serviceProvider.GetService<Wild>()!;
                    default:
                        return null;
                }
            });

            services.AddSingleton<App>();
        });
}