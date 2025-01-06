namespace Cruise_manager.Components.Data
{
    public class Workers
    {
        public Workers(string userName, string password, string email, string fname, string lname, string egn, string address, string phone, bool role)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Fname = fname;
            Lname = lname;
            EGN = egn;
            Address = address;
            Phone = phone;
            Role = role;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string EGN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Role { get; set; }
    }
}
