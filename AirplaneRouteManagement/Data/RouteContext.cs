using AirplaneRouteManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.Data
{
    public class RouteContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Route> Routes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    "server=.;Database=RouteManagement;trusted_connection=true;");
                base.OnConfiguring(optionsBuilder);
            }
        }

        public RouteContext(DbContextOptions options)
            : base(options) { }

        public RouteContext()
        {

        }
    }
}
