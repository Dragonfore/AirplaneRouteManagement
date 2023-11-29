using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.Repositories;
using AirplaneRouteManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Linking at this level due to time and avoiding setting up service/api for the time being
            var routeContext = new RouteContext();
            routeContext.Database.EnsureCreated();
            var cityRepository = new CityRepository(routeContext);
            var cityService = new CityService(cityRepository);

            var routeRepository = new RouteRepository(routeContext);
            var routeService = new RouteService(routeRepository);

            Application.Run(new Form1(cityService, routeService));
        }
    }
}
