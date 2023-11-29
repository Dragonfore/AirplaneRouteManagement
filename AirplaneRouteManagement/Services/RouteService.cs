using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using AirplaneRouteManagement.Repositories;
using System.Linq;

namespace AirplaneRouteManagement.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;

        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public Route AddEditRoute(AddEditRouteDto dto)
        {
            return _routeRepository.AddEditRoute(dto);
        }

        public bool DeleteRoute(DeleteRouteDto dto)
        {
            return _routeRepository.DeleteRoute(dto);
        }

        public IQueryable<Route> GetRoutes()
        {
            return _routeRepository.GetRoutes();
        }

        public (IQueryable<Route>, IQueryable<Route>) GetRoutesByCityId(int cityId)
        {
            return _routeRepository.GetRoutesByCityId(cityId);
        }
    }
}
