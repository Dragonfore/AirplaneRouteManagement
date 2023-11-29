using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.DataTransferObjects
{
    public class AddEditCityDto
    {
        public string CityName { get; set; }
        public string CityDescription { get; set; }
        public string Operation { get; set; }
        public int? CityId { get; set; }
    }
}
