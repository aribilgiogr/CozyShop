using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.DTOs
{
    public class RegisterDTO
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, EmailAddress, StringLength(256)]
        public string Email { get; set; }

        [Required, MinLength(6), MaxLength(12), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare("Password"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Phone, StringLength(20)]
        public string PhoneNumber { get; set; }
    }

    public class LoginDTO {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ChangePasswordDTO {
        [Required, DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required, DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string NewPassword { get; set; }

        [Required,Compare("NewPassword"), DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
    public class AuthResponseDTO {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
