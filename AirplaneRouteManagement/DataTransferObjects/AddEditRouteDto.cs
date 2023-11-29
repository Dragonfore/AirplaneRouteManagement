namespace AirplaneRouteManagement.DataTransferObjects
{
    public class AddEditRouteDto
    {
        public int CityId1 { get; set; }
        public int CityId2 { get; set; }
        public string Operation { get; set; }
    }
}
