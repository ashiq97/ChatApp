using System.ComponentModel.DataAnnotations;

namespace ChattingApp.DTOs
{
    public class LoginDto
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
