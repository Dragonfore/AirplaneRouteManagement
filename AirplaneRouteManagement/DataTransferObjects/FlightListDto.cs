using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.DataTransferObjects
{
    public class FlightListDto
    {
        public string CityName1 { get; set; }
        public string CityName2 { get; set; }
        public string Direction { get; set; }
        public int CityId1 { get; set; }
        public int CityId2 { get; set; }
        public int RouteId { get; set; }
        
        public override string ToString()
        {
            return CityName1 + " -> " + CityName2 + " - " + Direction;
        }
    }
}
