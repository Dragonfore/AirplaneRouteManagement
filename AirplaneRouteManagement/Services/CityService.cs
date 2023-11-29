using AirplaneRouteManagement.Repositories;

namespace AirplaneRouteManagement.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

    }
}
