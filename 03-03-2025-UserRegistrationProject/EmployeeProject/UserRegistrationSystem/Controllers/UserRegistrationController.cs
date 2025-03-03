    using Microsoft.AspNetCore.Mvc;
    using ModelLayer.DTO;

    using BusinessLayer.Service;
    using BusinessLayer.Interface;

    namespace UserRegistrationSystem.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class UserRegistrationController : ControllerBase
        {
            private readonly IUserRegistration _userRegistration;
            private readonly ILogger<UserRegistrationController> _logger;
            ResponseDTO<RegisterUserDTO> responseDTO;

            public UserRegistrationController(IUserRegistration userRegistration, ILogger<UserRegistrationController> logger)
            {
                _userRegistration = userRegistration;
                _logger = logger;
            }
            [HttpGet]
            public string Get()
            {
            _logger.LogInformation("get method called");
                return "tushar";
            }

            [HttpGet("login")]
            public IActionResult GetUser(LoginDTO loginDTO)
            {
                try
                {
                    ResponseDTO<LoginDTO>  responseDTO = new ResponseDTO<LoginDTO>();

                    bool result = _userRegistration.UserLoginBL(loginDTO);

                    responseDTO.Success = result ;
                    responseDTO.Message = result ? "User Login Successfully!" : "User Can't Login!, Invalid username or password";
                    responseDTO.Data = result?loginDTO:null!;
                    
                    _logger.LogInformation($"{responseDTO.Message}");

                    return result ? Ok(responseDTO) : NotFound(responseDTO); ;

                }
                catch (Exception ex)
                {
                _logger.LogError(ex, "Error occured during login");
                    responseDTO.Success = false;
                    responseDTO.Message = ex.Message;
                    responseDTO.Data = null!;

                    return BadRequest(responseDTO);
                }
            }

            [HttpPost]

            public IActionResult Post([FromBody] RegisterUserDTO registerUserDTO)
            {
                try
                {
                    responseDTO = new ResponseDTO<RegisterUserDTO>();

                    bool result = _userRegistration.UserRegistrationBL(registerUserDTO);

                        responseDTO.Success = result;
                        responseDTO.Message = result?"User Registered Successfully!": "User Can't Register , Already exists e-mail!";
                        responseDTO.Data = result?registerUserDTO:null!;

                        _logger.LogInformation($"{responseDTO.Message}");
                        return result ? Ok(responseDTO): NotFound(responseDTO); ;
                    
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in registration");
                    responseDTO.Success = false;
                    responseDTO.Message = ex.Message;
                    responseDTO.Data = null!;

                    return BadRequest(responseDTO);
                }

            }

        }
    }
