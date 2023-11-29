using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.Repositories;
using AirplaneRouteManagement.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace AirplaneRouteManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var logger = LoggerFactory.Create(builder =>
            {
                builder.AddFilter("Microsoft", LogLevel.Warning)
                       .AddFilter("System", LogLevel.Warning)
                       .AddFilter("DvdFormApp.Program", LogLevel.Debug)
                       .AddConsole();
            });


            // Linking at this level due to time and avoiding setting up service/api for the time being
            var routeContext = new RouteContext();
            routeContext.Database.EnsureCreated();

            // Initialize Services and Repositories
            var cityRepository = new CityRepository(routeContext, logger);
            var cityService = new CityService(cityRepository);
            var routeRepository = new RouteRepository(routeContext, logger);
            var routeService = new RouteService(routeRepository);

            Application.Run(new Form1(cityService, routeService));
        }
    }
}
