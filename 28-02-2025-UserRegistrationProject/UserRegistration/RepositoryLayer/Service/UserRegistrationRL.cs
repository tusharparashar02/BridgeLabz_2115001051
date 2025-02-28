using ModelLayer.DTO;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {
        private static List<RegistrationDTO> users = new List<RegistrationDTO>();
        public UserRegistrationRL()
        {
        }
        public bool RegisterUserRL(RegistrationDTO newUser)
        {
            if (newUser == null || string.IsNullOrEmpty(newUser.email) || string.IsNullOrEmpty(newUser.password))
            {
                return false;
            }

            // Add the new user to the list
            users.Add(newUser);
            return true;
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            return users;
        }
    }
}
