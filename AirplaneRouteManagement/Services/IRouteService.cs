using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using System.Linq;

namespace AirplaneRouteManagement.Services
{
    public interface IRouteService
    {
        Route AddEditRoute(AddEditRouteDto dto);
        bool DeleteRoute(DeleteRouteDto dto);
        IQueryable<Route> GetRoutes();
        (IQueryable<Route>, IQueryable<Route>) GetRoutesByCityId(int cityId);
    }
}
