using System.Xml.Linq;

namespace AirplaneRouteManagement.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int NodeId1 { get; set; }
        public int NodeId2 { get; set; }

        public override string ToString()
        {
            return NodeId1 + " - " + NodeId2;
        }
    }
}
