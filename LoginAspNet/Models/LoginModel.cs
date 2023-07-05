using System.ComponentModel.DataAnnotations;

namespace LoginAspNet.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Digite o login")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string? Password { get; set; }

        public bool Remember_Me { get; set;}
}
}
