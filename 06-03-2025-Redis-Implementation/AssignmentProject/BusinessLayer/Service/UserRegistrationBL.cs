using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRegistrationRL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool RegisterUserBL(RegistrationDTO newUser)
        {
            try
            {
                logger.Info($"Business Layer - Registering new user with Email : {newUser.email}");
                return _userRegistrationRL.RegisterUserRL(newUser);
            }
            catch (Exception e)
            {
                logger.Error(e, $"Business Layer - Error registering user: {newUser.email}");
                throw new Exception(e.Message);
                //return false;
            }
        }

        public bool LoginUserBL(LoginDTO loginDTO)
        {
            logger.Info("Business Layer - Logging in user.");
            try
            {
                string frontendUsername = loginDTO.Email;
                string frontendPassword = loginDTO.Password;

                LoginDTO result = _userRegistrationRL.LoginUserRL(loginDTO);
                
                bool res = CheckUserPassword(frontendUsername, frontendPassword, result);
                logger.Info("Business Layer - User logged in successfully.");
                return res;
            }
            catch (Exception e)
            {
                logger.Error(e, "Business Layer - Error logging in user.");
                throw new Exception(e.Message);
                //return false;
            }
        }

        private bool CheckUserPassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            try
            {
                logger.Info("Business Layer - Checking user password.");
                if (result == null)
                {
                    logger.Warn("Business Layer - User not found.");
                    return false;
                }
                if (frontendUsername == result.Email && frontendPassword == result.Password)
                {
                    logger.Info("Business Layer - User password matched.");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                logger.Error(e, "Business Layer - Error checking user password.");
                throw new Exception(e.Message);
                //return false;
            }
        }

        public List<AllUsersDTO> GetAllUsers()
        {
            try
            {
                logger.Info("Business Layer - Fetching all registered users.");
                return _userRegistrationRL.GetAllUsers();
            }
            catch (Exception e)
            {
                logger.Error(e, "Business Layer - Error fetching all users.");
                throw new Exception(e.Message);
                //return null;
            }
        }
    }
}
