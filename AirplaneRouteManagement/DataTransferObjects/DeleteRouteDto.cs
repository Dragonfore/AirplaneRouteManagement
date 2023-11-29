using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneRouteManagement.DataTransferObjects
{
    public class DeleteRouteDto
    {
        public int? RouteId { get; set; }
        public string Operation { get; set; }
    }
}
