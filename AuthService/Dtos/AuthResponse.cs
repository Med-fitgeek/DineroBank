using System.ComponentModel.DataAnnotations;

namespace AuthService.Dtos
{
    public class AuthResponse
    {

        public Guid Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool isActive { get; set; } = false;

        public string Token { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
