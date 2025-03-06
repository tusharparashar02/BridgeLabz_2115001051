using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using NLog;
using System.Text.Json;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly UserRegistrationContext _context;
        private readonly RedisCacheService _cacheService;
        public UserRegistrationRL(UserRegistrationContext context,RedisCacheService cacheService)
        {
            _context = context;
            _cacheService = cacheService;
        }
        public bool RegisterUserRL(RegistrationDTO newUser)
        {
            try
            {
                if (newUser == null || string.IsNullOrEmpty(newUser.email) || string.IsNullOrEmpty(newUser.password))
                {
                    logger.Warn("Invalid user data received for registration.");
                    return false;
                }

                var userEntity = new UserEntity
                {
                    Email = newUser.email,
                    FirstName = newUser.firstname,
                    LastName = newUser.lastname,
                    Password = newUser.password
                };
                // Add the new user to the database
                _context.Users.Add(userEntity);
                _context.SaveChanges();

                logger.Info($"User registered successfully! with email: {newUser.email}");

                return true;
            }
            catch (Exception e)
            {

                logger.Error(e, "Error in Repository Layer while registering user: {0}", newUser.email);
                throw new Exception(e.Message);
                //return false;
            }
        }

        public LoginDTO LoginUserRL(LoginDTO loginDTO)
        {
            logger.Info("Fetching user password from the database.");
            try
            {
                var result = _context.Users.FirstOrDefault<UserEntity>(user => user.Email == loginDTO.Email);
                if (result == null)
                {
                    logger.Warn("User not found in the database.");
                    return null;
                }

                loginDTO.Email = result.Email;
                loginDTO.Password = result.Password;
                logger.Info("User password fetched successfully.");
                return loginDTO;
            }
            catch (Exception e)
            {
                logger.Error(e, "Error in Repository Layer while fetching user password for email: {0}", loginDTO.Email);
                throw new Exception(e.Message);
                //return null;
            }
        }

        public List<AllUsersDTO> GetAllUsers()
        {
            try
            {
                var cacheKey = "usersList";
                var cachedData = _cacheService.GetCache(cacheKey);

                if (!string.IsNullOrEmpty(cachedData))
                {
                    logger.Info("Returning cached data for all users.");
                    // Return cached data
                    return JsonSerializer.Deserialize<List<AllUsersDTO>>(cachedData);
                }

                logger.Info("Fetching all users from the database.");
                var users = _context.Users.Select(user => new AllUsersDTO
                {
                    Id = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email
                }).ToList();

                logger.Info("Fetched all users from the database.");
                // Cache the result for 10 minutes
                _cacheService.SetCache(cacheKey, JsonSerializer.Serialize(users));

                logger.Info("Returning all users.");
                return users;
            }
            catch (Exception e)
            {
                logger.Error(e, "Error in Repository Layer while fetching all users.");
                throw new Exception(e.Message);
            }
        }
    }
}