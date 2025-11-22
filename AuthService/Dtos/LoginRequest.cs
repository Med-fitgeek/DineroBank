using System.ComponentModel.DataAnnotations;

namespace AuthService.Dtos
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password{ get; set; }
    }
}
