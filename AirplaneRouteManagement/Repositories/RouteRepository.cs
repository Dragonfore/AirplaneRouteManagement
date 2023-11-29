using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using Microsoft.Extensions.Logging;
using System;

namespace AirplaneRouteManagement.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly RouteContext _routeContext;
        private readonly ILogger _logger;

        public RouteRepository(RouteContext routeContext, ILoggerFactory logger)
        {
            _routeContext = routeContext;
            _logger = logger.CreateLogger(nameof(RouteRepository));
        }

        public Route AddEditRoute(AddEditRouteDto dto)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }
    }
}
