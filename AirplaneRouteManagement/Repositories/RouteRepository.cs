using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

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
                var hasExisting = _routeContext.Routes.Where(x => x.NodeId1 == dto.CityId1 && x.NodeId2 == dto.CityId2).Any();
                if (hasExisting)
                {
                    _logger.LogWarning("Attempting to add a route that already exists with ids {id1}, {id2}.", dto.CityId1, dto.CityId2);
                    return null;
                }

                var route = new Route
                {
                    NodeId1 = dto.CityId1,
                    NodeId2 = dto.CityId2,
                };
                var result = _routeContext.Routes.Add(route);
                _routeContext.SaveChanges();

                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public bool DeleteRoute(DeleteRouteDto dto)
        {
            try
            {
                var routeToDelete = _routeContext.Routes.Find(dto.RouteId);

                _routeContext.Remove(routeToDelete);
                _routeContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }

        public IQueryable<Route> GetRoutes()
        {
            return _routeContext.Routes.AsQueryable();
        }

        // Returns:
        // (Inbound Routes, Outbound Routes)
        public (IQueryable<Route>, IQueryable<Route>) GetRoutesByCityId(int cityId)
        {
            var inbound = _routeContext.Routes.Where(x => x.NodeId2 == cityId);
            var outbound = _routeContext.Routes.Where(x => x.NodeId1 == cityId);
            return (inbound, outbound);
        }
    }
}
