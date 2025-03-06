using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        public bool RegisterUserBL(RegistrationDTO newUser);
        public bool LoginUserBL(LoginDTO loginDTO);
        public List<AllUsersDTO> GetAllUsers();
    }
}
