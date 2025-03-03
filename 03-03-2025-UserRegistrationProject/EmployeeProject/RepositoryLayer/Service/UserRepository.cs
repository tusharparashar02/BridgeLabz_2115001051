using System;
using System.Collections.Generic;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;

namespace RepositoryLayer.Service
{
    public class UserRepository : IUserRepository
    {
        private static List<RegisterUserDTO> store = new List<RegisterUserDTO>();
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(ILogger<UserRepository> logger)
        {
            _logger = logger;
        }

        public RegisterUserDTO RegisterUserRL(RegisterUserDTO registerUserDTO)
        {
            try
            {
                _logger.LogInformation("Attempting to register user: {email}", registerUserDTO.email);

                foreach (var v in store)
                {
                    if (v.email == registerUserDTO.email)
                    {
                        _logger.LogWarning("User registration failed: Email already exists {email}", registerUserDTO.email);
                        return null;
                    }
                }

                store.Add(registerUserDTO);
                _logger.LogInformation("User registered successfully: {email}", registerUserDTO.email);

                return registerUserDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during user registration for {email}", registerUserDTO.email);
                return null;
            }
        }

        public LoginDTO LoginUserRL(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Attempting login for user: {email}", loginDTO.email);

                foreach (var v in store)
                {
                    if (v.email == loginDTO.email)
                    {
                        loginDTO.email = v.email;
                        loginDTO.password = v.password;

                        _logger.LogInformation("User login successful: {email}", loginDTO.email);
                        return loginDTO;
                    }
                }

                _logger.LogWarning("User login failed: No user found for {email}", loginDTO.email);
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during login for {email}", loginDTO.email);
                return null;
            }
        }
    }
}
