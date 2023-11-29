using AirplaneRouteManagement.Constants;
using AirplaneRouteManagement.Data;
using AirplaneRouteManagement.DataTransferObjects;
using AirplaneRouteManagement.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly RouteContext _routeContext;
        private readonly ILogger _logger;

        public CityRepository(RouteContext routeContext, ILoggerFactory logger)
        {
            _routeContext = routeContext;
            _logger = logger.CreateLogger(nameof(CityRepository));
        }

        public City AddEditCity(AddEditCityDto dto)
        {
            try
            {
                if (dto.Operation == AppConstants.AddCityType)
                {
                    var city = new City
                    {
                        Name = dto.CityName,
                        Description = dto.CityDescription,
                    };
                    var result = _routeContext.Cities.Add(city);
                    _routeContext.SaveChanges();

                    return result.Entity;
                }
                else if (dto.Operation != AppConstants.EditCityType)
                {
                    // Use of find over where/FirstOrDefault for Performance improvements
                    var city = _routeContext.Cities.Find(dto.CityId);
                    city.Name = dto.CityName;
                    city.Description = dto.CityDescription;
                    _routeContext.Cities.Update(city);
                    _routeContext.SaveChanges();

                    return city;
                }
                else
                {
                    _logger.LogWarning("Unable to Add or Edit City type due to invalid operation {operation} provided.", dto.Operation);
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return null;
            }
        }

        public bool DeleteCity(DeleteCityDto dto)
        {
            try
            {
                var cityToDelete = _routeContext.Cities.Find(dto.CityId);

                _routeContext.Cities.Remove(cityToDelete);
                _routeContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
        public IQueryable<City> GetCities()
        {
            return _routeContext.Cities.AsQueryable();
        }

        public IQueryable<City> GetCitiesByKeyword(string keyword)
        {
            return _routeContext.Cities.Where(x => x.Name.Contains(keyword));
        }
    }
}
