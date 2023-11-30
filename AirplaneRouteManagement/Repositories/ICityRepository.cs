using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using System.Linq;

namespace AirplaneRouteManagement.Repositories
{
    public interface ICityRepository
    {
        City AddEditCity(AddEditCityDto dto);
        bool DeleteCity(DeleteCityDto dto);
        IQueryable<City> GetCities();
        IQueryable<City> GetCitiesByKeyword(string keyword);
        string ExportToReport();
        IQueryable<FlightListDto> GetFlightListDtoFromCityList(IQueryable<Route> routes, string direction);
    }
}
