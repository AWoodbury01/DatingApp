namespace API.Entities
{
    // Creates a table in the db mimicing this class
    public class AppUser
    {
        public int ID { get; set; }

        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


    }
}