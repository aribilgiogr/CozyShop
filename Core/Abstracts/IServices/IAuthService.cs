using Core.Concrete.DTOs;

namespace Core.Abstracts.IServices
{
    public interface IAuthService
    {
        // Authentication Operations
        AuthResponseDTO Register(RegisterDTO registerDto);
        AuthResponseDTO Login(LoginDTO loginDto);
        bool Logout(int userId);

        // Password Operations
        bool ChangePassword(int userId, ChangePasswordDTO changePasswordDto);
        bool ForgotPassword(string email);
        bool ResetPassword(string email, string token, string newPassword);

        // Token Operations
        AuthResponseDTO RefreshToken(string token);
        bool ValidateToken(string token);

        // User Validation
        bool IsEmailExists(string email);
        bool ValidateCredentials(string email, string password);
    }
}

