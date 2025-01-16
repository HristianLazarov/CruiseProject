namespace Cruise_manager.Components.Data
{
    public class Reservation
    {
        public Reservation(int reservId, int cruiseId, string email)
        {
            ReservId = reservId;
            CruiseId = cruiseId;
            Email = email;
        }
        public int ReservId { get; set; }
        public int CruiseId { get; set; }
        public string Email { get; set; }
    }
}
