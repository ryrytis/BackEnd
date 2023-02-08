namespace API0103
{
    public class NewUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonalCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string AddressOfResidence { get; set; }
        public byte[] Photo { get; set; }

        public NewUser()
        {
        }

        public NewUser(string name, string surname, int personalCode, string phoneNo, string email, string address, byte[] photo)
        {
            Name = name;
            Surname = surname;
            PersonalCode = personalCode;
            PhoneNo = phoneNo;
            Email = email;
            AddressOfResidence = address;
            Photo = photo;
        }
    }
}
