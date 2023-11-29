using AirplaneRouteManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly RouteContext _routeContext;

        public CityRepository(RouteContext routeContext)
        {
            _routeContext = routeContext;
        }

    }
}
