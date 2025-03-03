using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Interface
{
    public interface IUserRegistration
    {
        bool UserLoginBL(LoginDTO loginDTO);
        bool UserRegistrationBL(RegisterUserDTO registerUserDTO);
    }
}
