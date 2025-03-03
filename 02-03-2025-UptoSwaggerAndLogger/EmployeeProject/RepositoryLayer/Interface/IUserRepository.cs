using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IUserRepository
    {
        RegisterUserDTO RegisterUserRL(RegisterUserDTO registerUserDTO);
        LoginDTO LoginUserRL(LoginDTO loginDTO);
    }
}
