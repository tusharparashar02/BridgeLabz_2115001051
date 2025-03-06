using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Authorization;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userRegistrationBL;
        ResponseModel<RegistrationDTO> response;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(IUserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        /// <summary>
        /// Welcome message
        /// </summary>
        /// <returns>"Message"</returns>
        [HttpGet]
        public string Get()
        {
            return "Welcome to User Registration Portal!";
        }

        /// <summary>
        /// API to register a new user
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>"User registered Successfully"</returns>
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegistrationDTO newUser)
        {
            try
            {
                logger.Info($"API initiated to register new user with email: {newUser.email}");
                response = new ResponseModel<RegistrationDTO>();

                if (newUser == null)
                {
                    logger.Warn("Invalid user data received for registration.");
                    return BadRequest(new { Success = false, Message = "Invalid user data" });
                }

                bool isRegistered = _userRegistrationBL.RegisterUserBL(newUser);
                if (isRegistered)
                {
                    logger.Info($"User registered successfully! with email: {newUser.email}");
                    response.Success = true;
                    response.Message = $"User registered successfully! with email: {newUser.email}";
                    response.Data = newUser;
                    return Ok(response);
                }
                logger.Warn("User registration failed!");
                response.Success = false;
                response.Message = "User registration failed!";
                return BadRequest();
            }
            catch (Exception e)
            {
                logger.Error(e, $"Error registering user: {newUser.email}");
                response.Success = false;
                response.Message = e.Message;
                return BadRequest(response);
            }
        }

        /// <summary>
        /// API to login user
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns>"Tokens"</returns>
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            try
            {
                logger.Info("API initiated to login user.");
                bool result = _userRegistrationBL.LoginUserBL(loginDTO);

                if (!result)
                {
                    logger.Warn("Invalid credentials.");
                    return Unauthorized(new { message = "Invalid credentials" });
                }

                logger.Info("User logged in successfully.");
                var tokenService = HttpContext.RequestServices.GetRequiredService<TokenService>();
                logger.Info("Token generated successfully.");
                string token = tokenService.GenerateToken(loginDTO.Email);

                logger.Info("Token sent to user.");
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error logging in user.");
                return BadRequest(new { message = "An error occurred", error = ex.Message });
            }
        }

        /// <summary>
        /// API to fetch all registered users
        /// </summary>
        /// <returns>All Users</returns>
        [Authorize]
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            try
            {
               

                logger.Info("API initiated to fetch all registered users.");
                var response = new ResponseModel<List<AllUsersDTO>>();
                var users = _userRegistrationBL.GetAllUsers();

                response.Success = true;
                response.Message = "User list fetched successfully!";
                response.Data = users;

                return Ok(response);
            }
            catch (Exception e)
            {
                logger.Error(e, "Error fetching all users.");
                response.Success = false;
                response.Message = e.Message;
                return BadRequest(response);
            }
        }
    }
}
