using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.DataTransferObjects
{
    public class DeleteCityDto
    {
        public string Operation { get; set; }
        public int? CityId { get; set; }
    }
}
