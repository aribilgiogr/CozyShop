using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class AuthService : IAuthService
    {
        public bool ChangePassword(ChangePasswordDTO model)
        {
            throw new NotImplementedException();
        }

        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public AuthResponseDTO Login(LoginDTO model)
        {
            throw new NotImplementedException();
        }

        public AuthResponseDTO Register(RegisterDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
