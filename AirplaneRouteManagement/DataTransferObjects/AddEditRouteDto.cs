using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.DataTransferObjects
{
    public class AddEditRouteDto
    {
        public int? CityId1 { get; set; }
        public int? CityId2 { get; set; }
        public string Operation { get; set; }
    }
}
