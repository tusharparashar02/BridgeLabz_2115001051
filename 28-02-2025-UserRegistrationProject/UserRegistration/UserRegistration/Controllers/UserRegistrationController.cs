using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _userRegistrationBL;
        ResponseModel<RegistrationDTO> response;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome to User Registration Portal!";
        }

        // API to register a user
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegistrationDTO newUser)
        {
            try
            {
                response = new ResponseModel<RegistrationDTO>();
                bool isRegistered = _userRegistrationBL.RegisterUserBL(newUser);
                if (isRegistered)
                {
                    response.Success = true;
                    response.Message = $"User registered successfully! with email: {newUser.email}";
                    response.Data = newUser;
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "User registration failed!";
                return BadRequest();
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = e.Message;
                return BadRequest(response);
            }
        }

        // API to get all registered users
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var response = new ResponseModel<List<RegistrationDTO>>();
            List<RegistrationDTO> users = _userRegistrationBL.GetAllUsers();

            response.Success = true;
            response.Message = "User list fetched successfully!";
            response.Data = users;

            return Ok(response);
        }
    }
}
