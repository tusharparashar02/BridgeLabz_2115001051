namespace ModelLayer.DTO
{
    public class RegistrationDTO
    {
        public  string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public  string password { get; set; }

        override
        public string ToString()
        {
            return $"Email: {email}, Name: {firstname} {lastname},Password: {password}";
        }
    }
}
