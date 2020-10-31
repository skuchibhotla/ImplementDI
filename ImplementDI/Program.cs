using ImplementDI.Abstractions;
using ImplementDI.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Dynamic;
using System.Security.Authentication.ExtendedProtection;

namespace ImplementDI
{
    class Program
    {
        public static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<ConsoleApplication>().Run();
            DisposeServices();
        }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ICustomer, Customer>();
            services.AddSingleton<ConsoleApplication>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        public static void DisposeServices()
        {
            if(_serviceProvider == null)
            {
                return;
            }

            if(_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
