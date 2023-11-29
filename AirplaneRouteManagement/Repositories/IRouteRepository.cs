using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using System.Linq;

namespace AirplaneRouteManagement.Repositories
{
    public interface IRouteRepository
    {
        Route AddEditRoute(AddEditRouteDto dto);
        bool DeleteRoute(DeleteRouteDto dto);
        IQueryable<Route> GetRoutes();
        (IQueryable<Route>, IQueryable<Route>) GetRoutesByCityId(int cityId);
    }
}
