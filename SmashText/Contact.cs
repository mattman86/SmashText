namespace SmashText
{
    internal class Contact
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}