using RepositoryLayer.Service;
using ModelLayer.DTO;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool RegisterUserBL(RegistrationDTO newUser)
        {
            return _userRegistrationRL.RegisterUserRL(newUser);
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            return _userRegistrationRL.GetAllUsers();
        }
    }
}
