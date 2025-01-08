namespace Cruise_manager.Components.Data
{
    public class Reservation
    {
        public Reservation(string fName, string mName, string lName, string egn, string phone, string nationality, bool typeOfTicket)
        {
            FName = fName;
            MName = mName;
            LName = lName;
            EGN = egn;
            Phone = phone;
            Nationality = nationality;
            TypeOfTicket = typeOfTicket;
        }

        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string EGN { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public bool TypeOfTicket { get; set; }
    }
}
