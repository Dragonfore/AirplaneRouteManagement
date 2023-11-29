using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;

namespace AirplaneRouteManagement.Repositories
{
    public interface IRouteRepository
    {
        Route AddEditRoute(AddEditRouteDto dto);
    }
}
