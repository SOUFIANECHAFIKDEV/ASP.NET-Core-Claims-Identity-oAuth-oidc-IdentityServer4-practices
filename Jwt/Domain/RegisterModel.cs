using System.ComponentModel.DataAnnotations;

namespace Jwt.Domain
{
    public class RegisterModel
    {
        [Required, StringLength(100)]
        public string Firstname { get; set; }
        [Required, StringLength(100)]
        public string Lastname { get; set; }
        [Required, StringLength(50)]
        public string Username { get; set; }
        [Required, StringLength(128)]
        public string Email { get; set; }
        [Required, StringLength(256)]
        public string Password { get; set; }
    }
}
