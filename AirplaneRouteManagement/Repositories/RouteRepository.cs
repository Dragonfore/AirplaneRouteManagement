using AirplaneRouteManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly RouteContext _routeContext;

        public RouteRepository(RouteContext routeContext)
        {
            _routeContext = routeContext;
        }

    }
}
