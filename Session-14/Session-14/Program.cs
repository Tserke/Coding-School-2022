using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Session_14
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Customer>, MockCustomerRepo>();
            services.AddSingleton<MainForm>();

            ServiceProvider= services.BuildServiceProvider();
            var mainForm=ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
    }
}