namespace Cruise_manager.Components.Data
{
    public class Cruises
    {
        public Cruises(string locationFrom, string locationTo, DateTime departureTime, DateTime arrivalTime, string cruiseType, string uniqueCruiseNumber, string capitanName, int passangerCap, int buisinessClassCap, int cruise_id)
        {
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            CruiseType = cruiseType;
            UniqueCruiseNumber = uniqueCruiseNumber;
            CapitanName = capitanName;
            PassangerCap = passangerCap;
            BuisinessClassCap = buisinessClassCap;
            Cruise_id = cruise_id;
        }
        public int Cruise_id { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string CruiseType { get; set; }
        public string UniqueCruiseNumber { get; set; }
        public string CapitanName { get; set; }
        public int PassangerCap { get; set; }
        public int BuisinessClassCap { get; set; }
    }
}
