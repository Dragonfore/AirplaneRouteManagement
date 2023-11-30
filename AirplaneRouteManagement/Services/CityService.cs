using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using AirplaneRouteManagement.Repositories;
using System.Linq;

namespace AirplaneRouteManagement.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public City AddEditCity(AddEditCityDto dto)
        {
            return _cityRepository.AddEditCity(dto);
        }
        
        public bool DeleteCity(DeleteCityDto dto)
        {
            return _cityRepository.DeleteCity(dto);
        }
        public IQueryable<City> GetCities()
        {
            return _cityRepository.GetCities();
        }
        public IQueryable<City> GetCitiesByKeyword(string keyword, int activeCityId)
        {
            return _cityRepository.GetCitiesByKeyword(keyword).Where(x => x.Id != activeCityId);
        }

        public IQueryable<City> GetCitiesExceptActive(int activeCityId)
        {
            return _cityRepository.GetCities().Where(x => x.Id != activeCityId);
        }

        public string ExportToReport()
        {
            return _cityRepository.ExportToReport();
        }

        public IQueryable<FlightListDto> GetFlightListDtoFromCityList(IQueryable<Route> routes, string direction)
        {
            return _cityRepository.GetFlightListDtoFromCityList(routes, direction);
        }
    }
}
