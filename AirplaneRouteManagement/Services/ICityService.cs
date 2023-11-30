using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using System.Linq;

namespace AirplaneRouteManagement.Services
{
    public interface ICityService
    {
        City AddEditCity(AddEditCityDto dto);
        bool DeleteCity(DeleteCityDto dto);
        IQueryable<City> GetCities();
        IQueryable<City> GetCitiesByKeyword(string keyword, int activeCityId);
        IQueryable<City> GetCitiesExceptActive(int activeCityId);
        string ExportToReport();
    }
}
