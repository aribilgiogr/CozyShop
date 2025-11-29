using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IAuthService
    {
        AuthResponseDTO Login(LoginDTO model);
        AuthResponseDTO Register(RegisterDTO model);
        void ForgotPassword(string email);
        bool ChangePassword(ChangePasswordDTO model);
    }
}
