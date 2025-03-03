using System;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;

namespace BusinessLayer.Service
{
    public class UserRegistration : IUserRegistration
    {
        private readonly IUserRepository _userRegistrationRL;
        private readonly ILogger<UserRegistration> _logger;

        public UserRegistration(IUserRepository userRegistrationRL, ILogger<UserRegistration> logger)
        {
            _userRegistrationRL = userRegistrationRL;
            _logger = logger;
        }

        public bool UserLoginBL(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Attempting user login for email: {email}", loginDTO.email);

                string email = loginDTO.email;
                string password = loginDTO.password;

                var user = _userRegistrationRL.LoginUserRL(loginDTO);
                bool result = CheckUser(user, email, password);

                if (result)
                {
                    _logger.LogInformation("User login successful: {email}", email);
                }
                else
                {
                    _logger.LogWarning("User login failed: Invalid credentials for {email}", email);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during user login for {email}", loginDTO.email);
                return false;
            }
        }

        public bool CheckUser(LoginDTO loginDTO, string email, string password)
        {
            try
            {
                if (loginDTO == null)
                {
                    _logger.LogWarning("User login failed: No user found for {email}", email);
                    return false;
                }

                bool isValid = loginDTO.email == email && loginDTO.password == password;
                _logger.LogInformation("User validation result for {email}: {result}", email, isValid);

                return isValid;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while checking user credentials for {email}", email);
                return false;
            }
        }

        public bool UserRegistrationBL(RegisterUserDTO registerUserDTO)
        {
            try
            {
                _logger.LogInformation("Attempting to register user: {email}", registerUserDTO.email);

                bool isRegistered = _userRegistrationRL.RegisterUserRL(registerUserDTO) != null;

                if (isRegistered)
                {
                    _logger.LogInformation("User registered successfully: {email}", registerUserDTO.email);
                }
                else
                {
                    _logger.LogWarning("User registration failed: Email already exists {email}", registerUserDTO.email);
                }

                return isRegistered;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during user registration for {email}", registerUserDTO.email);
                return false;
            }
        }
    }
}
