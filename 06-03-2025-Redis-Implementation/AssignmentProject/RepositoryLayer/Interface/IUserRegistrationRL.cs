using ModelLayer.DTO;
namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        public bool RegisterUserRL(RegistrationDTO newUser);
        public List<AllUsersDTO> GetAllUsers();
        public LoginDTO LoginUserRL(LoginDTO login);
    }
}
